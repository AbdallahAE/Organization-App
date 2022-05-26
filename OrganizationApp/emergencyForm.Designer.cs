namespace OrganizationApp
{
    partial class emergencyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnterEmergencyMode = new System.Windows.Forms.Button();
            this.btnExitEmergencyMode = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emergency";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 380);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 4;
            // 
            // btnEnterEmergencyMode
            // 
            this.btnEnterEmergencyMode.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnEnterEmergencyMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnterEmergencyMode.FlatAppearance.BorderSize = 0;
            this.btnEnterEmergencyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterEmergencyMode.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnterEmergencyMode.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterEmergencyMode.Location = new System.Drawing.Point(0, 70);
            this.btnEnterEmergencyMode.Name = "btnEnterEmergencyMode";
            this.btnEnterEmergencyMode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEnterEmergencyMode.Size = new System.Drawing.Size(800, 254);
            this.btnEnterEmergencyMode.TabIndex = 5;
            this.btnEnterEmergencyMode.Text = "Enter Emergency Mode";
            this.btnEnterEmergencyMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnterEmergencyMode.UseVisualStyleBackColor = false;
            this.btnEnterEmergencyMode.Click += new System.EventHandler(this.btnEnterEmergencyMode_Click);
            // 
            // btnExitEmergencyMode
            // 
            this.btnExitEmergencyMode.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnExitEmergencyMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitEmergencyMode.FlatAppearance.BorderSize = 0;
            this.btnExitEmergencyMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitEmergencyMode.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitEmergencyMode.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExitEmergencyMode.Location = new System.Drawing.Point(0, 324);
            this.btnExitEmergencyMode.Name = "btnExitEmergencyMode";
            this.btnExitEmergencyMode.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExitEmergencyMode.Size = new System.Drawing.Size(800, 126);
            this.btnExitEmergencyMode.TabIndex = 6;
            this.btnExitEmergencyMode.Text = "Exit Emergency Mode";
            this.btnExitEmergencyMode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExitEmergencyMode.UseVisualStyleBackColor = false;
            this.btnExitEmergencyMode.Click += new System.EventHandler(this.btnExitEmergencyMode_Click);
            // 
            // emergencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitEmergencyMode);
            this.Controls.Add(this.btnEnterEmergencyMode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "emergencyForm";
            this.Text = "emergencyForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnEnterEmergencyMode;
        private Button btnExitEmergencyMode;
    }
}