namespace CPU_Scheduling
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.numeric_numProcess = new System.Windows.Forms.NumericUpDown();
            this.groupBox_numberProcess = new System.Windows.Forms.GroupBox();
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.checkBox_FCFS = new System.Windows.Forms.CheckBox();
            this.checkBox_SJF_P = new System.Windows.Forms.CheckBox();
            this.checkBox_RR = new System.Windows.Forms.CheckBox();
            this.groupbox_algorithm = new System.Windows.Forms.GroupBox();
            this.lbl_Priority_N = new System.Windows.Forms.Label();
            this.checkBox_Priority_N = new System.Windows.Forms.CheckBox();
            this.lbl_Priority_P = new System.Windows.Forms.Label();
            this.checkBox_Priority_P = new System.Windows.Forms.CheckBox();
            this.lbl_SJF_N = new System.Windows.Forms.Label();
            this.checkBox_SJF_N = new System.Windows.Forms.CheckBox();
            this.lbl_RR = new System.Windows.Forms.Label();
            this.lbl_SJF_P = new System.Windows.Forms.Label();
            this.lbl_FCFS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).BeginInit();
            this.groupBox_numberProcess.SuspendLayout();
            this.groupbox_algorithm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.SkyBlue;
            this.btn_back.Location = new System.Drawing.Point(16, 624);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 52);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // numeric_numProcess
            // 
            this.numeric_numProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numeric_numProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_numProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_numProcess.ForeColor = System.Drawing.SystemColors.GrayText;
            this.numeric_numProcess.Location = new System.Drawing.Point(35, 47);
            this.numeric_numProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numeric_numProcess.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numeric_numProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.Name = "numeric_numProcess";
            this.numeric_numProcess.Size = new System.Drawing.Size(600, 56);
            this.numeric_numProcess.TabIndex = 4;
            this.numeric_numProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_numProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_numberProcess
            // 
            this.groupBox_numberProcess.Controls.Add(this.numeric_numProcess);
            this.groupBox_numberProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_numberProcess.ForeColor = System.Drawing.Color.Gray;
            this.groupBox_numberProcess.Location = new System.Drawing.Point(85, 17);
            this.groupBox_numberProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_numberProcess.Name = "groupBox_numberProcess";
            this.groupBox_numberProcess.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_numberProcess.Size = new System.Drawing.Size(669, 127);
            this.groupBox_numberProcess.TabIndex = 6;
            this.groupBox_numberProcess.TabStop = false;
            this.groupBox_numberProcess.Text = "Number of process";
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(85, 452);
            this.btn_ok_number_of_process.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(669, 57);
            this.btn_ok_number_of_process.TabIndex = 5;
            this.btn_ok_number_of_process.Text = "Next";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // checkBox_FCFS
            // 
            this.checkBox_FCFS.AutoSize = true;
            this.checkBox_FCFS.Checked = true;
            this.checkBox_FCFS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FCFS.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_FCFS.Location = new System.Drawing.Point(35, 47);
            this.checkBox_FCFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_FCFS.Name = "checkBox_FCFS";
            this.checkBox_FCFS.Size = new System.Drawing.Size(96, 41);
            this.checkBox_FCFS.TabIndex = 19;
            this.checkBox_FCFS.Text = "FCFS";
            this.checkBox_FCFS.UseVisualStyleBackColor = true;
            this.checkBox_FCFS.CheckedChanged += new System.EventHandler(this.checkBox_FCFS_CheckedChanged);
            // 
            // checkBox_SJF_P
            // 
            this.checkBox_SJF_P.AutoSize = true;
            this.checkBox_SJF_P.Checked = true;
            this.checkBox_SJF_P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SJF_P.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SJF_P.Location = new System.Drawing.Point(35, 101);
            this.checkBox_SJF_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_SJF_P.Name = "checkBox_SJF_P";
            this.checkBox_SJF_P.Size = new System.Drawing.Size(218, 41);
            this.checkBox_SJF_P.TabIndex = 20;
            this.checkBox_SJF_P.Text = "SJF preemptive";
            this.checkBox_SJF_P.UseVisualStyleBackColor = true;
            this.checkBox_SJF_P.CheckedChanged += new System.EventHandler(this.checkBox_SJF_P_CheckedChanged);
            // 
            // checkBox_RR
            // 
            this.checkBox_RR.AutoSize = true;
            this.checkBox_RR.Checked = true;
            this.checkBox_RR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RR.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RR.Location = new System.Drawing.Point(35, 210);
            this.checkBox_RR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_RR.Name = "checkBox_RR";
            this.checkBox_RR.Size = new System.Drawing.Size(71, 41);
            this.checkBox_RR.TabIndex = 21;
            this.checkBox_RR.Text = "RR";
            this.checkBox_RR.UseVisualStyleBackColor = true;
            this.checkBox_RR.CheckedChanged += new System.EventHandler(this.checkBox_RR_CheckedChanged);
            // 
            // groupbox_algorithm
            // 
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.checkBox_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_P);
            this.groupbox_algorithm.Controls.Add(this.checkBox_Priority_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_N);
            this.groupbox_algorithm.Controls.Add(this.checkBox_SJF_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_RR);
            this.groupbox_algorithm.Controls.Add(this.lbl_SJF_P);
            this.groupbox_algorithm.Controls.Add(this.lbl_FCFS);
            this.groupbox_algorithm.Controls.Add(this.checkBox_RR);
            this.groupbox_algorithm.Controls.Add(this.checkBox_SJF_P);
            this.groupbox_algorithm.Controls.Add(this.checkBox_FCFS);
            this.groupbox_algorithm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_algorithm.ForeColor = System.Drawing.Color.Gray;
            this.groupbox_algorithm.Location = new System.Drawing.Point(85, 151);
            this.groupbox_algorithm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupbox_algorithm.Name = "groupbox_algorithm";
            this.groupbox_algorithm.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupbox_algorithm.Size = new System.Drawing.Size(669, 278);
            this.groupbox_algorithm.TabIndex = 24;
            this.groupbox_algorithm.TabStop = false;
            this.groupbox_algorithm.Text = "Algorithm";
            // 
            // lbl_Priority_N
            // 
            this.lbl_Priority_N.AutoSize = true;
            this.lbl_Priority_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_N.Location = new System.Drawing.Point(357, 192);
            this.lbl_Priority_N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Priority_N.Name = "lbl_Priority_N";
            this.lbl_Priority_N.Size = new System.Drawing.Size(222, 19);
            this.lbl_Priority_N.TabIndex = 30;
            this.lbl_Priority_N.Text = "Priority Scheduling Nonpreemptive";
            // 
            // checkBox_Priority_N
            // 
            this.checkBox_Priority_N.AutoSize = true;
            this.checkBox_Priority_N.Checked = true;
            this.checkBox_Priority_N.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Priority_N.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Priority_N.Location = new System.Drawing.Point(336, 156);
            this.checkBox_Priority_N.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Priority_N.Name = "checkBox_Priority_N";
            this.checkBox_Priority_N.Size = new System.Drawing.Size(312, 41);
            this.checkBox_Priority_N.TabIndex = 29;
            this.checkBox_Priority_N.Text = "Priority nonpreemptive";
            this.checkBox_Priority_N.UseVisualStyleBackColor = true;
            this.checkBox_Priority_N.CheckedChanged += new System.EventHandler(this.checkBox_Priority_N_CheckedChanged);
            // 
            // lbl_Priority_P
            // 
            this.lbl_Priority_P.AutoSize = true;
            this.lbl_Priority_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Priority_P.Location = new System.Drawing.Point(56, 192);
            this.lbl_Priority_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Priority_P.Name = "lbl_Priority_P";
            this.lbl_Priority_P.Size = new System.Drawing.Size(196, 19);
            this.lbl_Priority_P.TabIndex = 28;
            this.lbl_Priority_P.Text = "Priority Scheduling Preemptive";
            // 
            // checkBox_Priority_P
            // 
            this.checkBox_Priority_P.AutoSize = true;
            this.checkBox_Priority_P.Checked = true;
            this.checkBox_Priority_P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Priority_P.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Priority_P.Location = new System.Drawing.Point(35, 156);
            this.checkBox_Priority_P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Priority_P.Name = "checkBox_Priority_P";
            this.checkBox_Priority_P.Size = new System.Drawing.Size(266, 41);
            this.checkBox_Priority_P.TabIndex = 27;
            this.checkBox_Priority_P.Text = "Priority preemptive";
            this.checkBox_Priority_P.UseVisualStyleBackColor = true;
            this.checkBox_Priority_P.CheckedChanged += new System.EventHandler(this.checkBox_Priority_P_CheckedChanged);
            // 
            // lbl_SJF_N
            // 
            this.lbl_SJF_N.AutoSize = true;
            this.lbl_SJF_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_N.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_N.Location = new System.Drawing.Point(364, 137);
            this.lbl_SJF_N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SJF_N.Name = "lbl_SJF_N";
            this.lbl_SJF_N.Size = new System.Drawing.Size(214, 19);
            this.lbl_SJF_N.TabIndex = 26;
            this.lbl_SJF_N.Text = "Shortest Job First Nonpreemptive";
            // 
            // checkBox_SJF_N
            // 
            this.checkBox_SJF_N.AutoSize = true;
            this.checkBox_SJF_N.Checked = true;
            this.checkBox_SJF_N.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_SJF_N.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SJF_N.Location = new System.Drawing.Point(336, 101);
            this.checkBox_SJF_N.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_SJF_N.Name = "checkBox_SJF_N";
            this.checkBox_SJF_N.Size = new System.Drawing.Size(264, 41);
            this.checkBox_SJF_N.TabIndex = 25;
            this.checkBox_SJF_N.Text = "SJF nonpreemptive";
            this.checkBox_SJF_N.UseVisualStyleBackColor = true;
            this.checkBox_SJF_N.CheckedChanged += new System.EventHandler(this.checkBox_SJF_N_CheckedChanged);
            // 
            // lbl_RR
            // 
            this.lbl_RR.AutoSize = true;
            this.lbl_RR.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RR.ForeColor = System.Drawing.Color.Gray;
            this.lbl_RR.Location = new System.Drawing.Point(56, 246);
            this.lbl_RR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RR.Name = "lbl_RR";
            this.lbl_RR.Size = new System.Drawing.Size(88, 19);
            this.lbl_RR.TabIndex = 24;
            this.lbl_RR.Text = "Round Robin";
            // 
            // lbl_SJF_P
            // 
            this.lbl_SJF_P.AutoSize = true;
            this.lbl_SJF_P.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SJF_P.ForeColor = System.Drawing.Color.Gray;
            this.lbl_SJF_P.Location = new System.Drawing.Point(56, 137);
            this.lbl_SJF_P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SJF_P.Name = "lbl_SJF_P";
            this.lbl_SJF_P.Size = new System.Drawing.Size(188, 19);
            this.lbl_SJF_P.TabIndex = 23;
            this.lbl_SJF_P.Text = "Shortest Job First Preemptive";
            // 
            // lbl_FCFS
            // 
            this.lbl_FCFS.AutoSize = true;
            this.lbl_FCFS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FCFS.ForeColor = System.Drawing.Color.Gray;
            this.lbl_FCFS.Location = new System.Drawing.Point(56, 81);
            this.lbl_FCFS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FCFS.Name = "lbl_FCFS";
            this.lbl_FCFS.Size = new System.Drawing.Size(138, 19);
            this.lbl_FCFS.TabIndex = 22;
            this.lbl_FCFS.Text = "First come First serve";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_ok_number_of_process);
            this.panel1.Controls.Add(this.groupbox_algorithm);
            this.panel1.Controls.Add(this.groupBox_numberProcess);
            this.panel1.Location = new System.Drawing.Point(96, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 526);
            this.panel1.TabIndex = 25;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPU_Scheduling.Properties.Resources.BG_Blur;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.Text = "Visual Processes Scheduling";
            this.Load += new System.EventHandler(this.Form_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).EndInit();
            this.groupBox_numberProcess.ResumeLayout(false);
            this.groupbox_algorithm.ResumeLayout(false);
            this.groupbox_algorithm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.NumericUpDown numeric_numProcess;
        private System.Windows.Forms.GroupBox groupBox_numberProcess;
        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.CheckBox checkBox_FCFS;
        private System.Windows.Forms.CheckBox checkBox_SJF_P;
        private System.Windows.Forms.CheckBox checkBox_RR;
        private System.Windows.Forms.GroupBox groupbox_algorithm;
        private System.Windows.Forms.Label lbl_RR;
        private System.Windows.Forms.Label lbl_SJF_P;
        private System.Windows.Forms.Label lbl_FCFS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Priority_N;
        private System.Windows.Forms.CheckBox checkBox_Priority_N;
        private System.Windows.Forms.Label lbl_Priority_P;
        private System.Windows.Forms.CheckBox checkBox_Priority_P;
        private System.Windows.Forms.Label lbl_SJF_N;
        private System.Windows.Forms.CheckBox checkBox_SJF_N;
    }
}