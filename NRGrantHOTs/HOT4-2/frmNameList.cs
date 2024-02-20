using System.Net.Http.Headers;
using System.Xml.Serialization;

namespace HOT4_2
{
    public partial class frmNameList : Form
    {
        private List<string> namesList = new List<string>();

        public frmNameList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckInput();
            if (keepGoing)
            {
                string nameEntry = txtNameEntry.Text.Trim();
                namesList.Add(nameEntry);
                UpdateNamesList();
                txtNameEntry.Text = string.Empty;
            }
        }

        private bool CheckInput()
        {
            bool retVal = true;
            string nameEntry = txtNameEntry.Text.Trim();

            if (nameEntry == "")
            {
                MessageBox.Show("You must enter a name.", "Error: Input Empty");
                retVal = false;
            }

            if (namesList.Exists(name => name.Equals(nameEntry, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Name already exists in the list.", "Error: Duplicate Entry");
                retVal = false;
            }

            return retVal;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckInput();
            if (keepGoing)
            {
                keepGoing = CheckListSelection();
                if (keepGoing)
                {
                    string nameEntry = txtNameEntry.Text.Trim();
                    int selectedIndex = listView1.SelectedIndex;

                    namesList[selectedIndex] = nameEntry;
                    UpdateNamesList();
                    txtNameEntry.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool keepGoing = CheckListSelection();
            if(keepGoing)
            {
                DialogResult dialog = MessageBox.Show($"Do you really want to delete {namesList[listView1.SelectedIndex]}?", "Delete Name?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    namesList.RemoveAt(listView1.SelectedIndex);
                    UpdateNamesList();
                    txtNameEntry.Clear();
                }
            } 
        }

        private bool CheckListSelection()
        {
            bool retVal = true;

            if (listView1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a name to Update or Delete.", "Error: No Name Selected");
                retVal = false;
            }

            return retVal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            namesList.Clear();
            UpdateNamesList();
            txtNameEntry.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Exit The Program?", "EXIT NOW?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateNamesList()
        {
            listView1.Items.Clear();
            listView1.Items.AddRange(namesList.ToArray());
        }
    }
}
