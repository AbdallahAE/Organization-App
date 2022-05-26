namespace OrganizationApp
{
    public partial class Form1 : Form
    {
        static Form _fTask = new taskDashboardForm();
        static Form _fApps = new blockedAppsForm();
        static Form _fStore = new storeForm();
        static Form _fSettings = new settingsForm();
        public static Form _fEmergency = new emergencyForm();
        static Form _fPassword = new passwordForm();
        public Form1()
        {
            InitializeComponent();
            loadform(_fEmergency);
            loadform(_fSettings);
            loadform(_fStore);
            loadform(_fApps);
            loadform(_fTask);
        }

        public void loadform(object Form)
        {
            //this.MainPanel.Controls.Clear();
            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
            f.BringToFront();
        }
        public static void showForm(Form form)
        {
            form.BringToFront();
        }
        private void btnTasks_Click(object sender, EventArgs e)
        {
            showForm(_fTask);
        }

        private void btnBlockedApps_Click(object sender, EventArgs e)
        {
            showForm(_fApps);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            showForm(_fStore);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            showForm(_fSettings);            
        }

        private void btnEmergency_Click(object sender, EventArgs e)
        {
            _fPassword.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            storeForm.Points = Properties.Settings.Default.storePoints;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.storePoints = storeForm.Points;
            Properties.Settings.Default.Save();
        }
    }
}