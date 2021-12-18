using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_Scheduling
{
    public partial class Form_Menu : Form
    {
        ProcessesScheduling myScheduling;
        public Form_Menu(ProcessesScheduling myScheduling)
        {
            InitializeComponent();
            this.myScheduling = myScheduling;
            
            setContent();
        }

        public Form_Menu()
        {
            InitializeComponent();
        }

        public void setContent()
        {
            // Set value in content form Object.
            numeric_numProcess.Value = myScheduling.getNumberProcess();
            checkBox_FCFS.Checked = myScheduling.getFlagFCFS();
            checkBox_SJF_P.Checked = myScheduling.getFlagSJF_P();
            checkBox_SJF_N.Checked = myScheduling.getFlagSJF_N();
            checkBox_Priority_P.Checked = myScheduling.getFlagPriority_P();
            checkBox_Priority_N.Checked = myScheduling.getFlagPriority_N();
            checkBox_RR.Checked = myScheduling.getFlagRR();
        }

        public void check_AllCheckboxNotChecked()
        {
            bool FCFS = checkBox_FCFS.Checked;
            bool SJF_P = checkBox_SJF_P.Checked;
            bool SJF_N = checkBox_SJF_N.Checked;
            bool Priority_P = checkBox_Priority_P.Checked;
            bool Priority_N = checkBox_Priority_N.Checked;
            bool RR = checkBox_RR.Checked;
            if (!FCFS && !SJF_P && !SJF_N && !Priority_P && !Priority_N && !RR)
            {
                btn_ok_number_of_process.Enabled = false;
            }
            else
            {
                btn_ok_number_of_process.Enabled = true;
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(myScheduling);
            form.Show();
            form.Location = this.Location;
            //form2.StartPosition = this.StartPosition;
            Hide();
        }

        private void btn_ok_number_of_process_Click(object sender, EventArgs e)
        {
            // Set number of Process to Object.
            myScheduling.setNumberProcess((int)numeric_numProcess.Value);

            // Set checked box to Object.
            bool FCFS = checkBox_FCFS.Checked;
            bool SJF_P = checkBox_SJF_P.Checked;
            bool SJF_N = checkBox_SJF_N.Checked;
            bool Priority_P = checkBox_Priority_P.Checked;
            bool Priority_N = checkBox_Priority_N.Checked;
            bool RR = checkBox_RR.Checked;
            myScheduling.setFlag_Algorithm(FCFS, SJF_P, SJF_N, Priority_P, Priority_N, RR);

            // Navigate Page.
            Input_Form form = new Input_Form(myScheduling);
            form.Show();
            form.Location = this.Location;
            Hide();
        }

        

        private void checkBox_FCFS_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_SJF_P_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_SJF_N_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_Priority_P_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_Priority_N_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void checkBox_RR_CheckedChanged(object sender, EventArgs e)
        {
            check_AllCheckboxNotChecked();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }


        private void lbl_language_Click(object sender, EventArgs e)
        {

        }

        

        
        
    }
}
