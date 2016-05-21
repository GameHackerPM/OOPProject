using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Plan_Courses
    {
        private static int lastID = Properties.Settings.Default.LastPlan_Source;
        public int ID { get; private set; }
        public string planname;
        public int plantype;
        public double amount;
        public string details;

        public Plan_Courses(string planname ,int plantype, double amount, string details)
        {
            ID = GetNextID();
            this.planname = planname;
            this.plantype = plantype;
            this.amount = amount;
            this.details = details;
            Properties.Settings.Default.LastPlan_Source = lastID;
            Properties.Settings.Default.Save();
        }

        private int GetNextID()
        {
            return lastID++;
        }
    }
}
