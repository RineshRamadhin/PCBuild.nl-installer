﻿using System;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Download_python f2 = new Download_python();
            f2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Download_rstudio f3 = new Download_rstudio();
            f3.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tijdelijke bestanden verwijderen?",
                       "PCBuild.nl - Opruimer",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information) == DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
