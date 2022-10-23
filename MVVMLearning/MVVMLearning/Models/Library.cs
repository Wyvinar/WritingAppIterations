using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace MVVMLearning.Models
{
    static class Library
    {
        private static List<Project> projects;
        private static List<Template> templates;
        private static string libraryFilepath;

        public static void OpenLibrary(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException();
            }
            libraryFilepath = filepath;
            string[] subdirectories = Directory.GetDirectories(filepath);
            foreach (string element in subdirectories)
            {
                projects.Add(CreateProjectElement(element));
            }
        }

        private static Project CreateProjectElement(string element)
        {
            Project project;
            Template tmplt = new Template();
            if (element == null)
            {
                throw new ArgumentNullException();
            }
            string title = Path.GetDirectoryName(element);

            project = new Project(title);
            return project;
        }

        #region Getters and Setters
        // The Getters and Setters for the Library class
        public static string GetLibraryFilePath()
        {
            return libraryFilepath;
        }

        public static List<Project> GetLibraryProjects()
        {
            return projects;
        }

        public static void SetLibraryFilePath(string filepath)
        {
            libraryFilepath = filepath;
        }

        public static void DeleteProject(string title)
        {
            foreach (Project element in projects)
            {
                if (element.GetTitle() == title)
                {
                    projects.Remove(element);
                }
            }
        }

        public static void AddProject(string title)
        {
            projects.Add(new Project(title));
        }
        #endregion
    }
}
