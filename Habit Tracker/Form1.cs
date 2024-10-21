using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Habit_Tracker
{
    public partial class Form1 : Form
    {
        private List<Habit> habits = new List<Habit>(); // List to store habits
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            string habitName = txtHabitName.Text;

            if (!string.IsNullOrEmpty(habitName))
            {
                Habit newHabit = new Habit(habitName);
                habits.Add(newHabit);

                // Update the ListBox with the new habit
                lstHabits.Items.Add(newHabit);
                txtHabitName.Clear(); // Clear the input field after adding

                lblStatus.Text = $"Added habit: {habitName}";
            }
            else
            {
                MessageBox.Show("Please enter a habit name.");
            }
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if(lstHabits.SelectedItem!=null)
            {
                Habit selectedHabit = (Habit)lstHabits.SelectedItem;
                selectedHabit.IsCompleted = chkCompleted.Checked;

                lstHabits.Items[lstHabits.SelectedIndex]=selectedHabit;
                lblStatus.Text = $"Habit '{selectedHabit.Name}' marked as {(selectedHabit.IsCompleted ? "Completed" : "Not Completed")}";
            }
            else
            {
                MessageBox.Show("Select an item to mark as completed.");
            }
        }
    }
}
