using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Tracker
{
    public class Habit
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateAdded { get; set; }

        public Habit(string name)
        {
            Name = name;
            IsCompleted = false;
            DateAdded = DateTime.Now;
        }

        public override string ToString()
        {
            string status = IsCompleted ? "Completed" : "Not Completed";
            return $"{Name} - {status}";
        }
    }

}
