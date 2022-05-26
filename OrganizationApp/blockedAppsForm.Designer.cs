namespace OrganizationApp
{
    partial class blockedAppsForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListBoxBlockedApps = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveApp = new System.Windows.Forms.Button();
            this.btnAddAppPanel = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBlockApp = new System.Windows.Forms.Button();
            this.listViewTaskManager = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddApp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timUpdate = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.btnAddAppPanel.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blocked Apps";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.ListBoxBlockedApps);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 380);
            this.panel1.TabIndex = 3;
            // 
            // ListBoxBlockedApps
            // 
            this.ListBoxBlockedApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ListBoxBlockedApps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxBlockedApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxBlockedApps.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxBlockedApps.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ListBoxBlockedApps.FormattingEnabled = true;
            this.ListBoxBlockedApps.ItemHeight = 20;
            this.ListBoxBlockedApps.Location = new System.Drawing.Point(0, 0);
            this.ListBoxBlockedApps.Name = "ListBoxBlockedApps";
            this.ListBoxBlockedApps.Size = new System.Drawing.Size(498, 380);
            this.ListBoxBlockedApps.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveApp);
            this.panel3.Controls.Add(this.btnAddAppPanel);
            this.panel3.Controls.Add(this.btnAddApp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(498, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 380);
            this.panel3.TabIndex = 0;
            // 
            // btnRemoveApp
            // 
            this.btnRemoveApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveApp.FlatAppearance.BorderSize = 0;
            this.btnRemoveApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveApp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveApp.Location = new System.Drawing.Point(0, 311);
            this.btnRemoveApp.Name = "btnRemoveApp";
            this.btnRemoveApp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRemoveApp.Size = new System.Drawing.Size(302, 42);
            this.btnRemoveApp.TabIndex = 4;
            this.btnRemoveApp.Text = "Remove App";
            this.btnRemoveApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveApp.UseVisualStyleBackColor = true;
            this.btnRemoveApp.Click += new System.EventHandler(this.btnRemoveApp_Click);
            // 
            // btnAddAppPanel
            // 
            this.btnAddAppPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnAddAppPanel.Controls.Add(this.btnRefresh);
            this.btnAddAppPanel.Controls.Add(this.btnBlockApp);
            this.btnAddAppPanel.Controls.Add(this.listViewTaskManager);
            this.btnAddAppPanel.Controls.Add(this.label2);
            this.btnAddAppPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAppPanel.Location = new System.Drawing.Point(0, 42);
            this.btnAddAppPanel.Name = "btnAddAppPanel";
            this.btnAddAppPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddAppPanel.Size = new System.Drawing.Size(302, 269);
            this.btnAddAppPanel.TabIndex = 3;
            this.btnAddAppPanel.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Location = new System.Drawing.Point(5, 243);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(297, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBlockApp
            // 
            this.btnBlockApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlockApp.Location = new System.Drawing.Point(5, 220);
            this.btnBlockApp.Name = "btnBlockApp";
            this.btnBlockApp.Size = new System.Drawing.Size(297, 23);
            this.btnBlockApp.TabIndex = 5;
            this.btnBlockApp.Text = "Block";
            this.btnBlockApp.UseVisualStyleBackColor = true;
            this.btnBlockApp.Click += new System.EventHandler(this.btnBlockApp_Click);
            // 
            // listViewTaskManager
            // 
            this.listViewTaskManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.listViewTaskManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewTaskManager.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewTaskManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.listViewTaskManager.Location = new System.Drawing.Point(5, 30);
            this.listViewTaskManager.Name = "listViewTaskManager";
            this.listViewTaskManager.Size = new System.Drawing.Size(297, 190);
            this.listViewTaskManager.TabIndex = 0;
            this.listViewTaskManager.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please run the application that you would like to block\r\nthen procede to select t" +
    "hat application in the list below.";
            // 
            // btnAddApp
            // 
            this.btnAddApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddApp.FlatAppearance.BorderSize = 0;
            this.btnAddApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddApp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddApp.Location = new System.Drawing.Point(0, 0);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddApp.Size = new System.Drawing.Size(302, 42);
            this.btnAddApp.TabIndex = 2;
            this.btnAddApp.Text = "Add App";
            this.btnAddApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddApp.UseVisualStyleBackColor = true;
            this.btnAddApp.Click += new System.EventHandler(this.btnAddApp_Click);
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
            // timUpdate
            // 
            this.timUpdate.Tick += new System.EventHandler(this.timUpdate_Tick);
            // 
            // blockedAppsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "blockedAppsForm";
            this.Text = "blockedAppsForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.btnAddAppPanel.ResumeLayout(false);
            this.btnAddAppPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddApp;
        private Button btnRemoveApp;
        private Panel btnAddAppPanel;
        private ListView listViewTaskManager;
        private Label label2;
        private Button btnBlockApp;
        private Button btnRefresh;
        private ListBox ListBoxBlockedApps;
        private System.Windows.Forms.Timer timUpdate;
    }
}