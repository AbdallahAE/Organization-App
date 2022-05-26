namespace OrganizationApp
{
    public partial class settingsForm : Form
    {
        public settingsForm()
        {
            InitializeComponent();
            txtSettingsPassword.Text = Properties.Settings.Default.emergencyPassword;
            txtSettingsFreeTime.Text = Properties.Settings.Default.storeMinutesToBlock.ToString();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            if (txtSettingsPassword.Text != "" && txtSettingsFreeTime.Text != "")
            {
                Properties.Settings.Default.emergencyPassword = txtSettingsPassword.Text;
                passwordForm.password = txtSettingsPassword.Text;
                Properties.Settings.Default.storeMinutesToBlock = int.Parse(txtSettingsFreeTime.Text);
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings Saved!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill in the blanks!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
