using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PCBuild.nl_Installer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (!Directory.Exists(@"C:\PCBuild.nl\"))
                Directory.CreateDirectory(@"C:\PCBuild.nl\");
        }

        /// <summary>
        /// opent form Download_neo4j
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Download_neo4j f1 = new Download_neo4j();
            f1.Show();
        }
    }
}
