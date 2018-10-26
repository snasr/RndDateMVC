using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfiniteLoopNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //private void btnStart_Click(object sender, EventArgs e)
        //{

        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            int counter = 0;

            try
            {                
                while (true)
                {
                   tbNum.Text = counter++.ToString();

                    //Technique #1
                    int Result = counter * counter;
                    tbNumSqaured.Text = Result.ToString();

                    //Technique #2
                    tbNumSqaured.Text = (counter * counter).ToString();

                    Application.DoEvents();
                }                
            }
            catch (OverflowException ofex)
            {
                MessageBox.Show("An overflow exception has occurred; counter=" + counter.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General Exception has occurred: " + ex.Message);
            }

        }
    }
}
