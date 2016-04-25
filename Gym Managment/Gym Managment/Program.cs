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
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MembersList.Add(new Members("Ahmed", "Ossama", 01068514542, "3 Street Alhakam baamr allah, Shobra, Egypt.", 1, 10100, DateTime.Now));
            MembersList.Add(new Members("Mariam", "Ossama", 0106985414, "3 Street Alhakam baamr allah, Shobra, Egypt.", 3, 2154, DateTime.Now.AddMonths(4)));
            MembersList.Add(new Members("Heba", "Gamal", 0106541654, "18 Street Elmo3az Mohamed, Giza, Egypt.", 2, 2654, DateTime.Now.AddMonths(1)));
            MembersList.Add(new Members("Hanaa", "Salem", 0106216578, "3 Street Korba Street, Shobra, Egypt.", 1, 1548, DateTime.Now.AddMonths(3)));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
