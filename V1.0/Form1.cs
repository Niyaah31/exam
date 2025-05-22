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

            // Check for empty inputs
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

            // Add to list
            listBoxTasks.Items.Add(taskName + " - Due: " + dueDate.ToShortDateString());

            // Clear fields
            txtTask.Clear();
            txtDueDate.Clear();
        }

    }
}
