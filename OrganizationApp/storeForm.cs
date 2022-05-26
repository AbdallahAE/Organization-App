namespace OrganizationApp
{
    public partial class storeForm : Form
    {
        public static bool buytimeEnabled = false;
        private static int _points;
        bool enableTimer = false;
        public static int minutesToBlock = Properties.Settings.Default.storeMinutesToBlock;
        int SecondsToBlock;
        public static int Points
        {
            get { return _points; }
            set { _points = value; }
        }
        public storeForm()
        {
            InitializeComponent();
            
        }

        private void btnBuyTime_Click(object sender, EventArgs e)
        {
            if (Points > 0)
            {
                SecondsToBlock = 60 * minutesToBlock;
                btnBuyTime.Enabled = false;
                enableTimer = true;
                Points -= 1;
                buytimeEnabled = true;
                MessageBox.Show("Baught " + minutesToBlock + " minutes of free time", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Not enough points", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelPoints.Text = Points.ToString();
            minutesToBlock = Properties.Settings.Default.storeMinutesToBlock;
            btnBuyTime.Text = "Purchase " + minutesToBlock + " Minutes";
            if (enableTimer)
            {
                if (SecondsToBlock > 0)
                {
                    SecondsToBlock--;
                    int minutes = SecondsToBlock / 60;
                    int seconds = SecondsToBlock - (minutes * 60);
                    labelTimer.Text = minutes.ToString() + ":" + seconds.ToString();
                }
                else
                {
                    enableTimer = false;
                    btnBuyTime.Enabled = true;
                    buytimeEnabled = false;
                    MessageBox.Show("Free time's up! Get back to work", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    labelTimer.Text = "00:00";
                    SecondsToBlock = 60 * minutesToBlock;
                }
            }
        }
    }
}
