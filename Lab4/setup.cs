using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;
using Microsoft.VisualBasic;
using System.IO;
using System.Reflection;
using Lab4;


namespace Lab4
{
    public class setups
    {
        public const string DatabaseFilename = "employees.db";

        public static string DatabasePath
        {
            get
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                DirectoryInfo directory = new(baseDirectory);

                while (directory.Name != "Lab4")
                {
                    directory = directory.Parent;
                }

                baseDirectory = directory.Parent.FullName;
                string dDirectory = Path.Combine(baseDirectory, "Data");

                return Path.Combine(dDirectory, DatabaseFilename);
            }
        }
    }


}
