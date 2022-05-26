namespace OrganizationApp
{
    partial class taskDashboardForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnAddTaskPanel = new System.Windows.Forms.Panel();
            this.btnApplyTask = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.ListViewTasks = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btnAddTaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 70);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCompleteTask);
            this.panel1.Controls.Add(this.btnRemoveTask);
            this.panel1.Controls.Add(this.btnAddTaskPanel);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(603, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 380);
            this.panel1.TabIndex = 7;
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleteTask.FlatAppearance.BorderSize = 0;
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteTask.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleteTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCompleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleteTask.Location = new System.Drawing.Point(0, 195);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCompleteTask.Size = new System.Drawing.Size(197, 42);
            this.btnCompleteTask.TabIndex = 4;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompleteTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompleteTask.UseVisualStyleBackColor = true;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveTask.FlatAppearance.BorderSize = 0;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemoveTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTask.Location = new System.Drawing.Point(0, 153);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRemoveTask.Size = new System.Drawing.Size(197, 42);
            this.btnRemoveTask.TabIndex = 3;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnAddTaskPanel
            // 
            this.btnAddTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(55)))));
            this.btnAddTaskPanel.Controls.Add(this.btnApplyTask);
            this.btnAddTaskPanel.Controls.Add(this.dtpDueDate);
            this.btnAddTaskPanel.Controls.Add(this.label3);
            this.btnAddTaskPanel.Controls.Add(this.txtTaskName);
            this.btnAddTaskPanel.Controls.Add(this.label2);
            this.btnAddTaskPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTaskPanel.Location = new System.Drawing.Point(0, 42);
            this.btnAddTaskPanel.Name = "btnAddTaskPanel";
            this.btnAddTaskPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddTaskPanel.Size = new System.Drawing.Size(197, 111);
            this.btnAddTaskPanel.TabIndex = 2;
            this.btnAddTaskPanel.Visible = false;
            // 
            // btnApplyTask
            // 
            this.btnApplyTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplyTask.Location = new System.Drawing.Point(5, 76);
            this.btnApplyTask.Name = "btnApplyTask";
            this.btnApplyTask.Size = new System.Drawing.Size(192, 23);
            this.btnApplyTask.TabIndex = 4;
            this.btnApplyTask.Text = "Apply";
            this.btnApplyTask.UseVisualStyleBackColor = true;
            this.btnApplyTask.Click += new System.EventHandler(this.btnApplyTask_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(5, 53);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(192, 23);
            this.dtpDueDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date:";
            // 
            // txtTaskName
            // 
            this.txtTaskName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaskName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTaskName.Location = new System.Drawing.Point(5, 15);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PlaceholderText = "Enter Task Name";
            this.txtTaskName.Size = new System.Drawing.Size(192, 23);
            this.txtTaskName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Task Name:";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Location = new System.Drawing.Point(0, 0);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddTask.Size = new System.Drawing.Size(197, 42);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // ListViewTasks
            // 
            this.ListViewTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ListViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListViewTasks.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ListViewTasks.Location = new System.Drawing.Point(0, 70);
            this.ListViewTasks.Name = "ListViewTasks";
            this.ListViewTasks.Size = new System.Drawing.Size(603, 380);
            this.ListViewTasks.TabIndex = 8;
            this.ListViewTasks.UseCompatibleStateImageBehavior = false;
            this.ListViewTasks.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewTasks_ColumnClick);
            // 
            // taskDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListViewTasks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taskDashboardForm";
            this.Text = "taskDashboardForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.btnAddTaskPanel.ResumeLayout(false);
            this.btnAddTaskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btnAddTask;
        private Panel btnAddTaskPanel;
        private DateTimePicker dtpDueDate;
        private Label label3;
        private TextBox txtTaskName;
        private Label label2;
        private Button btnCompleteTask;
        private Button btnRemoveTask;
        private Button btnApplyTask;
        private ListView ListViewTasks;
    }
}