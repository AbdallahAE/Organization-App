namespace OrganizationApp
{
    public partial class emergencyForm : Form
    {

        public static bool emergencyEnabled = false;
        public emergencyForm()
        {
            InitializeComponent();
        }
        private void btnEnterEmergencyMode_Click(object sender, EventArgs e)
        {
            emergencyEnabled = true;
            MessageBox.Show("Emergency Mode Activated", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnExitEmergencyMode_Click(object sender, EventArgs e)
        {
            emergencyEnabled = false;
            MessageBox.Show("Emergency Mode Diactivated", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
