using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MVVMLearning.Models
{
    internal class Project : Category
    {
        private Image coverImage;

        #region Constructors
        // constructor for creating a new Project
        public Project(string title, Image coverImage, ProjectTemplate template, DocumentTemplate defaultTemplate) : base(title, defaultTemplate)
        {
            this.coverImage = coverImage;
        }

        // constructor for loading a Project from storage into the library
        public Project(string title, string parentFilepath) : base(title, parentFilepath)
        {

        }

        #endregion
    }
}
