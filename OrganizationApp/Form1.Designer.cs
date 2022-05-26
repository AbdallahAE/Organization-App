namespace OrganizationApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sideMenu = new System.Windows.Forms.Panel();
            this.btnEmergency = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnBlockedApps = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.sideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.sideMenu.Controls.Add(this.btnEmergency);
            this.sideMenu.Controls.Add(this.btnSettings);
            this.sideMenu.Controls.Add(this.btnStore);
            this.sideMenu.Controls.Add(this.btnBlockedApps);
            this.sideMenu.Controls.Add(this.btnTasks);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 0);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(217, 577);
            this.sideMenu.TabIndex = 0;
            // 
            // btnEmergency
            // 
            this.btnEmergency.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEmergency.FlatAppearance.BorderSize = 0;
            this.btnEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmergency.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmergency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEmergency.Image = ((System.Drawing.Image)(resources.GetObject("btnEmergency.Image")));
            this.btnEmergency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmergency.Location = new System.Drawing.Point(0, 535);
            this.btnEmergency.Name = "btnEmergency";
            this.btnEmergency.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmergency.Size = new System.Drawing.Size(217, 42);
            this.btnEmergency.TabIndex = 4;
            this.btnEmergency.Text = "Emergency";
            this.btnEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmergency.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmergency.UseVisualStyleBackColor = true;
            this.btnEmergency.Click += new System.EventHandler(this.btnEmergency_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 126);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(217, 42);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = " Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnStore
            // 
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnStore.Image = ((System.Drawing.Image)(resources.GetObject("btnStore.Image")));
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Location = new System.Drawing.Point(0, 84);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(217, 42);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = " Store";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnBlockedApps
            // 
            this.btnBlockedApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlockedApps.FlatAppearance.BorderSize = 0;
            this.btnBlockedApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockedApps.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBlockedApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBlockedApps.Image = ((System.Drawing.Image)(resources.GetObject("btnBlockedApps.Image")));
            this.btnBlockedApps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockedApps.Location = new System.Drawing.Point(0, 42);
            this.btnBlockedApps.Name = "btnBlockedApps";
            this.btnBlockedApps.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBlockedApps.Size = new System.Drawing.Size(217, 42);
            this.btnBlockedApps.TabIndex = 1;
            this.btnBlockedApps.Text = " Blocked Apps";
            this.btnBlockedApps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockedApps.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlockedApps.UseVisualStyleBackColor = true;
            this.btnBlockedApps.Click += new System.EventHandler(this.btnBlockedApps_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(0, 0);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTasks.Size = new System.Drawing.Size(217, 42);
            this.btnTasks.TabIndex = 0;
            this.btnTasks.Text = "Tasks Dashboard";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(217, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(744, 577);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(961, 577);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.sideMenu);
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organization App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel sideMenu;
        private Button btnEmergency;
        private Button btnSettings;
        private Button btnStore;
        private Button btnBlockedApps;
        private Button btnTasks;
        private Panel MainPanel;
    }
}