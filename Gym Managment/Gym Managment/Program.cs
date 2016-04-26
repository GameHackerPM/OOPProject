using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gym_Managment
{
    static class Program
    {
        public static string Username = "admin";
        public static string Password = "admin";

        #region Lists/Database
        public static List<Members> MembersList = new List<Members>();
        public static List<Transactions> TransactionsList = new List<Transactions>();
        //public static List<Suppliers> SupplierList = new List<Suppliers>();
        public static List<Instructor> InstructorsList = new List<Instructor>();
        public static List<Equipment> EquipmentsList = new List<Equipment>();
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        //Members member11 =new Members();
        //MembersList.Add(member11);
            MembersList.Add(new Members("Ahmed", "Ossama", 01068514542, "3 Street Alhakam baamr allah, Shobra, Egypt.", 1, 10100, DateTime.Now));
            MembersList.Add(new Members("Mariam", "Ossama", 0106985414, "3 Street Alhakam baamr allah, Shobra, Egypt.", 3, 2154, DateTime.Now.AddMonths(4)));
            MembersList.Add(new Members("Heba", "Gamal", 0106541654, "18 Street Elmo3az Mohamed, Giza, Egypt.", 2, 2654, DateTime.Now.AddMonths(1)));
            MembersList.Add(new Members("Hanaa", "Salem", 0106216578, "3 Street Korba Street, Shobra, Egypt.", 1, 1548, DateTime.Now.AddMonths(3)));
            
            Instructor I1 = new Instructor("gamal", "soliman", "14street elrahma", 011596556, 900, DateTime.Now, 1);
            Instructor I2 = new Instructor("samy", "baher", "14street elsafa", 0115968496, 1200, DateTime.Now, 0);
            Instructor I3 = new Instructor("ibrahim", "samir", "14street elmarwa", 012759496, 4000, DateTime.Now, 2);
            InstructorsList.Add(I1);
            InstructorsList.Add(I2);
            InstructorsList.Add(I3);
           
            Equipment E1 = new Equipment("WheelSport1", 10, 1000, DateTime.Now.AddMonths(1),"sport_company");
            Equipment E2 = new Equipment("ElectricTreadmill", 13, 1200, DateTime.Now, "fitenss_company");
            EquipmentsList.Add(E1);
            EquipmentsList.Add(E2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
