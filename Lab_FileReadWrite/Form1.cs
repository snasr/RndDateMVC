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
using System.Configuration;  //From "System.Configuration.DLL"

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessFile_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(@"C:\CC6\Output.txt");
                string line = sr.ReadLine();

                while (line != null)
                {
                    textBox1.Text += line;
                    line = sr.ReadLine();
                }

                sr.Close();
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string LoopCount = ConfigurationManager.AppSettings["LoopCount"];

                StreamWriter sw = new StreamWriter(@"C:\CC6\Output.txt", true);
                sw.WriteLine(System.DateTime.Now.ToString());
                sw.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox1.Text = "";
        }
    }
}
