using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class Form1 : Form
    {
        ProcessesScheduling myScheduling;
        public Form1()
        {
            InitializeComponent();
            myScheduling = new ProcessesScheduling();

        }
        public Form1(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            Form_Menu form2 = new Form_Menu(myScheduling);
            form2.Show();
            form2.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();  
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_project_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
