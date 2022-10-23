using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MVVMLearning.Models
{
    internal class Category
    {
        protected string title;
        protected List<Document> documents;
        protected DocumentTemplate defaultTemplate;
        protected List<Category> childCategories;
        protected string parentFilepath;

        public Category(string title, string parentFilePath, DocumentTemplate defaultTemplate)
        {
            this.title = title;
            this.parentFilepath = parentFilePath;
            this.defaultTemplate = defaultTemplate;
            childCategories = new List<Category>();
            documents = new List<Document>();
        }

        public Category(string title, string parentFilepath)
        {
            this.title=title;
            this.parentFilepath=parentFilepath;
        }

        #region Getters and Setters
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }

        #endregion

    }
}
