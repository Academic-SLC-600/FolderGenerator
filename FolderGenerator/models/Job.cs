using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderGenerator.models
{
    abstract class Job
    {
        public string Initial { get; set; }
        public string Gen { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Type { get; set; }

    }
}
