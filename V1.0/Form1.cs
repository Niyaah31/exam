using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = txtTask.Text.Trim();
            string dueDateText = txtDueDate.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrWhiteSpace(taskName) || string.IsNullOrWhiteSpace(dueDateText))
            {
                MessageBox.Show("Task name and due date cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate date format
            DateTime dueDate;
            if (!DateTime.TryParse(dueDateText, out dueDate))
            {
                MessageBox.Show("Please enter a valid date in the format MM/DD/YYYY.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add task to the list
            listBoxTasks.Items.Add(taskName + " - Due: " + dueDate.ToShortDateString());

            // Clear inputs
            txtTask.Clear();
            txtDueDate.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTask.Clear();
            txtDueDate.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    
    }
}
