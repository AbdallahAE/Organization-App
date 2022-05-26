namespace OrganizationApp
{
    public partial class passwordForm : Form
    {
        public static string password = Properties.Settings.Default.emergencyPassword;
        public passwordForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == password)
            {
                txtPassword.Clear();
                MessageBox.Show("Password Correct! Gained Access", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1.showForm(Form1._fEmergency);
                Hide();
            }
            else
            {
                MessageBox.Show("Password Incorrect! Please Try Again", "Emergency", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            Hide();
        }
    }
}
