using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Transactions
    {
        #region Properties
        private static int LastID = 1;
        public int ID { get; private set; }
        public string MemberName;
        public int MemberID;
        private double _amount;
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
                Member.Amount += value;
            }
        }
        public DateTime DateOfPay;
        private Members Member;
        #endregion

        public Transactions(Members Member)
        {
            ID = GetNextID();
            MemberName = Member.FirstName + " " + Member.LastName;
            MemberID = Member.ID;
        }

        public Transactions(Members Member, double Amount, DateTime DateOfPay)
        {
            ID = GetNextID();
            MemberName = Member.FirstName + " " + Member.LastName;
            MemberID = Member.ID;
            this.Amount = Amount;
            this.DateOfPay = DateOfPay;
        }

        private int GetNextID()
        {
            return LastID++;
        }
    }
}
