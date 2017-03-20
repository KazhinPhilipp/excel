using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_AddFile_Click(object sender, EventArgs e)
        {
            loadXmlFile();
        }

        private void loadXmlFile()
        {
            string pathCatalog = "xml";
            DirectoryInfo directoryXml = new DirectoryInfo(pathCatalog);

            if (!directoryXml.Exists)
            {
                directoryXml.Create();
            }

            string pathFileXml = "xml/EmployeesFiles.xml";
            FileStream fileXml = new FileStream(pathFileXml, FileMode.OpenOrCreate);



            fileXml.Close();
            
        }
    }
}
