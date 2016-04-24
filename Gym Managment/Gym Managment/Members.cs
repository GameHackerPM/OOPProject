using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Members
    {
        #region Properties
        private static int LastID = 1;
        public int ID { get; private set; }
        public string FirstName, LastName, Address;
        public int Contact_No, PlanType;
        public DateTime DateOfJoining;
        public double Amount;
        public Transactions Transaction;
        #endregion

        public Members(string FirstName, string LastName, int ContactNumber, string Address, int PlanType, double Amount, DateTime DateOfJoining)
        {
            ID = GetNextID();
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PlanType = PlanType;
            this.Amount = Amount;
            this.DateOfJoining = DateOfJoining;
            Contact_No = ContactNumber;
            Transaction = new Transactions(this);
        }

        private int GetNextID()
        {
            return LastID++;
        }

        public static int GetCount()
        {
            return Program.MembersList.Count;
        }
    }
}
