using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using FolderGenerator.models;

namespace FolderGenerator
{
    public partial class FolderGenerator : Form
    {
        private List<Correction> Corrections = new List<Correction>();
        private List<CaseMaking> CaseMakings = new List<CaseMaking>();

        public FolderGenerator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDownload.Enabled = false;
            btnChooseExcel.Enabled = false;
            btnChooseDestination.Enabled = false;
            btnGenerate.Enabled = false;
            txtExcelPath.Text = txtDestinationPath.Text = "";
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDownload.Enabled = true;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            int index = cbType.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Please choose template type!");
                return;
            }

            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Job List");
                    worksheet.Cell("A1").Value = "Initial";
                    worksheet.Cell("B1").Value = "Gen";
                    worksheet.Cell("C1").Value = "Course Code";
                    worksheet.Cell("D1").Value = "Course Name";
                    if (index == 0)
                    {
                        worksheet.Cell("E1").Value = "Correction Type";
                        worksheet.Cell("F1").Value = "Class";
                    }
                    else
                    {
                        worksheet.Cell("E1").Value = "Case Type";
                    }
                    string timestamp = DateTime.Now.ToString("yyMMdd HHmm");
                    workbook.SaveAs("TEMPLATE " + timestamp + " Import Job List.xlsx");

                    MessageBox.Show("Successfully download template");
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckExcelTemplate(List<string> headers, IXLRow template)
        {
            int index = 1;
            foreach (var item in headers)
            {
                if (!item.Equals(template.Cell(index++).Value))
                {
                    return false;
                }
            }
            return true;
        }

        private void HandleExcelTemplate()
        {
            List<string> headers = new List<string>() { "Initial", "Gen", "Course Code", "Course Name" };

            var workbook = new XLWorkbook(txtExcelPath.Text);
            var template = workbook.Worksheet(1).RowsUsed().First();
            var sheet = workbook.Worksheet(1).RowsUsed().Skip(1);

            if (cbGenerateType.SelectedIndex == 0)
            {
                headers.Add("Correction Type");
                headers.Add("Class");
                if (!CheckExcelTemplate(headers, template))
                {
                    MessageBox.Show("Invalid excel template file!");
                    return;
                }

                foreach (var item in sheet)
                {
                    Corrections.Add(new Correction()
                    {
                        Initial = item.Cell(1).Value.ToString(),
                        Gen = item.Cell(2).Value.ToString(),
                        CourseCode = item.Cell(3).Value.ToString(),
                        CourseName = item.Cell(4).Value.ToString(),
                        Type = item.Cell(5).Value.ToString(),
                        Class = item.Cell(6).Value.ToString(),
                    });
                }
            }
            else
            {
                headers.Add("Case Type");
                if (!CheckExcelTemplate(headers, template))
                {
                    MessageBox.Show("Invalid excel template file!");
                    return;
                }

                foreach (var item in sheet)
                {
                    int var = CaseMakings.Where(
                        x => x.Initial.Equals(item.Cell(1).Value.ToString()) &&
                            x.Gen.Equals(item.Cell(2).Value.ToString()) &&
                            x.CourseCode.Equals(item.Cell(3).Value.ToString()) &&
                            x.CourseName.Equals(item.Cell(4).Value.ToString()) &&
                            x.Type.Equals(item.Cell(5).Value.ToString())
                     ).ToList().Count + 1;
                    CaseMakings.Add(new CaseMaking()
                    {
                        Initial = item.Cell(1).Value.ToString(),
                        Gen = item.Cell(2).Value.ToString(),
                        CourseCode = item.Cell(3).Value.ToString(),
                        CourseName = item.Cell(4).Value.ToString(),
                        Type = item.Cell(5).Value.ToString(),
                        Var = var
                    });
                }
            }
        }

        private void btnChooseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Excel Files|*.xlsx;";
            openFile.Title = "Choose Template Excel File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                txtExcelPath.Text = openFile.InitialDirectory + openFile.FileName;
                HandleExcelTemplate();
            }
        }

        private void btnChooseDestination_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDestinationPath.Text = folderBrowser.SelectedPath + "\\";
            }
        }

        private void CreateDirectory(Job job, string end)
        {
            string root = txtDestinationPath.Text + job.Type + "\\" + job.CourseCode + "-" + job.CourseName + "\\";
            string readme = root + "ReadMe";
            string target = root + job.Initial + job.Gen + "\\" + end;
            if (!Directory.Exists(readme))
            {
                Directory.CreateDirectory(readme);
            }
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }
        }

        private void GenerateFolder()
        {
            if (cbGenerateType.SelectedIndex == 0)
            {
                foreach (var item in Corrections)
                {
                    CreateDirectory(item, item.Class);
                }
            }
            else
            {
                foreach (var item in CaseMakings)
                {
                    CreateDirectory(item, "Var" + item.Var);
                }
            }

            MessageBox.Show("Successfully generate folder");
            Application.Restart();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtExcelPath.Text) || String.IsNullOrEmpty(txtDestinationPath.Text))
            {
                MessageBox.Show("Please choose excel template or detination path first!");
                return;
            }

            GenerateFolder();
        }

        private void cbGenerateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChooseExcel.Enabled = true;
            btnChooseDestination.Enabled = true;
            btnGenerate.Enabled = true;
            txtExcelPath.Text = txtDestinationPath.Text = "";
        }
    }
}
