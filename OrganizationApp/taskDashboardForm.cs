using System.Collections;
using System.Text;

namespace OrganizationApp
{
    public partial class taskDashboardForm : Form
    {
        public taskDashboardForm()
        {
            InitializeComponent();
            createListView();
            loadlisttask(ListViewTasks);
        }
        private void removeSelectedTask()
        {
            try
            {
                if (ListViewTasks.SelectedItems[0] != null)
                {
                    if (MessageBox.Show("Are you Sure?", "Remove Task", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        ListViewTasks.Items.Remove(ListViewTasks.SelectedItems[0]);
                }
            }
            catch
            {
                return;
            }
        }
        private void completeSelectedTask()
        {
            try
            {
                if (ListViewTasks.SelectedItems[0].SubItems[2].Text != "Complete")
                {
                    if (MessageBox.Show("Did you really finish? Don't lie, this is for your own good!", "Complete task"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        ListViewTasks.SelectedItems[0].SubItems[2].Text = "Complete";
                        ListViewTasks.SelectedItems[0].ForeColor = Color.LightGreen;
                        MessageBox.Show("Congrats! You got some points in the store!", "Store", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        storeForm.Points += 1;
                    }
                }
                else
                {
                    MessageBox.Show("Already Completed!", "Complete task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                return;
            }
        }
        private void createListView()
        {
            ListViewTasks.View = View.Details;
            ListViewTasks.FullRowSelect = true;
            ListViewTasks.Columns.Add("Task Name", 230).Tag = typeof(string);
            ListViewTasks.Columns.Add("Due Date", 200).Tag = typeof(DateTime);
            ListViewTasks.Columns.Add("Status", 120).Tag = typeof(string);
        }
        private void addItemToListView(String taskName, String duedate, DateTimePicker dateTimePicker, String status)
        {
            if (txtTaskName.Text == "")
                return;
            String[] values = { taskName, duedate, status };
            Color color = Color.Blue;
            if (dateTimePicker.Value.Date < DateTime.Now.Date)
            {
                values[2] = "Over Due";
                color = Color.Red;
            }
            else if (dateTimePicker.Value.Date == DateTime.Now.Date)
            {
                values[2] = "Due Today";
                color = Color.Blue;
            }
            else
            {
                values[2] = "Incomplete";
                color = Color.Blue;
            }
            ListViewItem item = new ListViewItem(values, -1, color, Color.Empty, null);
            ListViewTasks.Items.Add(item);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (btnAddTaskPanel.Visible == false)
            {
                btnAddTaskPanel.Visible = true;
            }
            else
            {
                btnAddTaskPanel.Visible = false;
            }
        }

        private void btnApplyTask_Click(object sender, EventArgs e)
        {
            addItemToListView(txtTaskName.Text, dtpDueDate.Text, dtpDueDate, "");
            txtTaskName.Clear();
            dtpDueDate.ResetText();
            savelisttask(ListViewTasks);
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            removeSelectedTask();
            savelisttask(ListViewTasks);
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            completeSelectedTask();
            savelisttask(ListViewTasks);
        }



        private async void savelisttask(ListView listView)
        {
            using (TextWriter writer = new StreamWriter(new FileStream("TaskList.txt", FileMode.Create), Encoding.UTF8))
            {
                foreach (ListViewItem item in listView.Items)
                {
                    await writer.WriteLineAsync(item.SubItems[0].Text + "," + item.SubItems[1].Text + "," + item.SubItems[2].Text);
                }
            }
        }
        private void loadlisttask(ListView listView)
        {
            List<string> data;
            try
            {
                data = File.ReadAllLines("TaskList.txt").ToList();
            }
            catch
            {
                return;
            }
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (items.Last() == "Incomplete")
                {
                    listView.Items.Add(new ListViewItem(items, -1, Color.Blue, Color.Empty, null));
                }
                else if (items.Last() == "Over Due")
                {
                    listView.Items.Add(new ListViewItem(items, -1, Color.Red, Color.Empty, null));
                }
                else if (items.Last() == "Due Today")
                {
                    listView.Items.Add(new ListViewItem(items, -1, Color.Blue, Color.Empty, null));
                }
                else if (items.Last() == "Complete")
                {
                    listView.Items.Add(new ListViewItem(items, -1, Color.LightGreen, Color.Empty, null));
                }
            }
        }
        public void setblockedAppsEnabled(string text1, string text2, int coloumn)
        {
            int a = 0;
            if (emergencyForm.emergencyEnabled)
                blockedAppsForm.blockedAppsEnabled = false;
            else
            {
                if (storeForm.buytimeEnabled)
                {
                    blockedAppsForm.blockedAppsEnabled = false;
                }
                else
                {
                    foreach (ListViewItem item in ListViewTasks.Items)
                    {
                        if (item.SubItems[coloumn].Text == text1 || item.SubItems[coloumn].Text == text2)
                        {
                            a++;
                        }
                    }
                    if (a == 0)
                    {
                        blockedAppsForm.blockedAppsEnabled = false;
                    }
                    else
                    {
                        blockedAppsForm.blockedAppsEnabled = true;

                    }
                }
            }
        }

        private void ListViewTasks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            int sortColumn = -1;
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                ListViewTasks.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (ListViewTasks.Sorting == SortOrder.Ascending)
                    ListViewTasks.Sorting = SortOrder.Descending;
                else
                    ListViewTasks.Sorting = SortOrder.Ascending;
            }
            Type type = ListViewTasks.Columns[e.Column].Tag as Type;
            ListViewTasks.ListViewItemSorter = new ListViewItemComparer(e.Column, ListViewTasks.Sorting, type);
        }
        public class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;
            private Type columnType;
            public ListViewItemComparer()
            {
                this.col = 0;
                this.order = SortOrder.Ascending;
                this.columnType = null;
            }
            public ListViewItemComparer(int column, SortOrder order, Type type)
            {
                this.col = column;
                this.order = order;
                this.columnType = type;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;
                if (columnType == null || columnType == typeof(String))
                {
                    returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                        ((ListViewItem)y).SubItems[col].Text);
                }
                else if (columnType == typeof(DateTime))
                {
                    returnVal = DateTime.Compare(DateTime.Parse(((ListViewItem)x).SubItems[col].Text),
                                                 DateTime.Parse(((ListViewItem)y).SubItems[col].Text));
                }
                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }
                return returnVal;
            }
        }
    }
}
