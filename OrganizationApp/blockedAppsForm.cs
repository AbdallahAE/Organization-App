using System.Diagnostics;
using System.Text;

namespace OrganizationApp
{
    public partial class blockedAppsForm : Form
    {
        List<Process> processList = new List<Process>();
        List<string> blockedApplicationsProcessName = new List<string>();
        List<string> blockedApplicationsTitleName = new List<string>();
        public static bool blockedAppsEnabled;
        
        public blockedAppsForm()
        {
            InitializeComponent();
            createTaskManager();
            timUpdate.Interval = 1000;
            timUpdate.Tick += new EventHandler(timUpdate_Tick);
            timUpdate.Start();
            loadblockedappslist(ListBoxBlockedApps);
        }
        private void createTaskManager()
        {
            listViewTaskManager.Clear();
            processList.Clear();
            listViewTaskManager.View = View.Details;
            listViewTaskManager.FullRowSelect = true;
            listViewTaskManager.Columns.Add("Application", 150);
            listViewTaskManager.Columns.Add("Status", 100);

            foreach (Process p in Process.GetProcesses())
            {
                try
                {
                    if (p.MainWindowTitle.Length > 0)
                    {
                        processList.Add(p);
                        String status = p.Responding ? "Running" : "Not Responding";
                        ListViewItem item = new ListViewItem(p.MainWindowTitle);
                        item.SubItems.Add(status);
                        listViewTaskManager.Items.Add(item);
                    }
                }
                catch { }
            }
        }
        private void btnAddApp_Click(object sender, EventArgs e)
        {
            if (btnAddAppPanel.Visible == false)
            {
                btnAddAppPanel.Visible = true;
            }
            else
            {
                btnAddAppPanel.Visible = false;
            }
        }
        private async void btnBlockApp_Click(object sender, EventArgs e)
        {
            try
            {
                blockedApplicationsTitleName.Add(processList[listViewTaskManager.SelectedIndices[0]].MainWindowTitle);
                blockedApplicationsProcessName.Add(processList[listViewTaskManager.SelectedIndices[0]].ProcessName);
            }
            catch
            {
                return;
            }
            saveblockedappslist();
            addAppToBlockList();
            processList.Clear();
            await Task.Delay(500);
            createTaskManager();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            createTaskManager();
        }

        private void addAppToBlockList()
        {
            ListBoxBlockedApps.Items.Add(blockedApplicationsTitleName.Last());
        }
        private void removeSelectedApp()
        {
            try
            {
                if (MessageBox.Show("Are you Sure?", "Remove Block App", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    for(int i = 0; i < blockedApplicationsProcessName.Count; i++)
                    {
                        if (blockedApplicationsTitleName[i] == ListBoxBlockedApps.SelectedItem.ToString())
                        {
                            blockedApplicationsTitleName.Remove(blockedApplicationsTitleName[i]);
                            blockedApplicationsProcessName.Remove(blockedApplicationsProcessName[i]);
                        }
                    }
                    ListBoxBlockedApps.Items.Remove(ListBoxBlockedApps.SelectedItems[0]);
                    saveblockedappslist();
                }
            }
            catch
            {
                return;
            }
        }
        private void btnRemoveApp_Click(object sender, EventArgs e)
        {
            removeSelectedApp();
           
        }
        private void blockAppBlockList()
        {            
            foreach(Process p in Process.GetProcesses())
            {
                for(int i = 0; i < blockedApplicationsProcessName.Count; i++)
                {
                    if (p.ProcessName == blockedApplicationsProcessName[i])
                    {
                        p.Kill();
                    }
                }
            }
        }

        private void timUpdate_Tick(object sender, EventArgs e)
        {
            taskDashboardForm taskDashboard = new taskDashboardForm();
            taskDashboard.setblockedAppsEnabled("Due Today", "Over Due", 2);
            if (blockedAppsEnabled)
                blockAppBlockList();
        }
        private async void saveblockedappslist()
        {
            using (TextWriter writer = new StreamWriter(new FileStream("BlockedAppsList.txt", FileMode.Create), Encoding.UTF8))
            {
                for (int i = 0; i < blockedApplicationsProcessName.Count; i++)
                {
                    await writer.WriteLineAsync(blockedApplicationsTitleName[i] + "," + blockedApplicationsProcessName[i]);
                }
            }
        }
        private void loadblockedappslist(ListBox listBox)
        {
            listBox.Items.Clear();
            List<string> data;
            try
            {
                data = File.ReadAllLines("BlockedAppsList.txt").ToList();
            }
            catch
            {
                return;
            }
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                listBox.Items.Add(items[0]);

                Thread.Sleep(10);
                blockedApplicationsTitleName.Add(items[0]);
                blockedApplicationsProcessName.Add(items[1]);
            }
        }
        
    }
}
