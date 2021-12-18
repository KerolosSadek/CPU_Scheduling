namespace CPU_Scheduling
{
    partial class Form1
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
            this.lbl_projectName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.panel_project = new System.Windows.Forms.Panel();
            this.panel_project.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_projectName
            // 
            this.lbl_projectName.AutoSize = true;
            this.lbl_projectName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_projectName.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_projectName.ForeColor = System.Drawing.Color.White;
            this.lbl_projectName.Location = new System.Drawing.Point(84, 190);
            this.lbl_projectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_projectName.Name = "lbl_projectName";
            this.lbl_projectName.Size = new System.Drawing.Size(842, 106);
            this.lbl_projectName.TabIndex = 0;
            this.lbl_projectName.Text = "Processes Scheduling";
            this.lbl_projectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(113, 295);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(805, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scheduling Algorithms in Operating system ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_next.Location = new System.Drawing.Point(408, 474);
            this.btn_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(232, 95);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel_project
            // 
            this.panel_project.BackColor = System.Drawing.Color.Transparent;
            this.panel_project.Controls.Add(this.label1);
            this.panel_project.Controls.Add(this.lbl_projectName);
            this.panel_project.Location = new System.Drawing.Point(3, 37);
            this.panel_project.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_project.Name = "panel_project";
            this.panel_project.Size = new System.Drawing.Size(1044, 430);
            this.panel_project.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPU_Scheduling.Properties.Resources.BG_Blur;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panel_project);
            this.Controls.Add(this.btn_next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visual Processes Scheduling ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_project.ResumeLayout(false);
            this.panel_project.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_projectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel panel_project;
    }
}

