using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MVVMLearning.Models
{
    internal class Template
    {
        protected string name;
        protected string filepath;
        
        public Template(string name, string filepath)
        {
            this.name = name;
            this.filepath = filepath;
        }
    }

    internal class DocumentTemplate : Template
    {
        Document documentTemplate;
        
        public DocumentTemplate(string name, string filepath, Document documentTemplate ) : base(name, filepath)
        {
            this.documentTemplate = documentTemplate;
        }

    }

    internal class ProjectTemplate : Template
    {

    }
}
