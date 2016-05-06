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
        public static List<Supplier> SupplierList = new List<Supplier>();
        public static List<Plan_Courses> Plan_CoursesList = new List<Plan_Courses>();
        public static List<Employee> EmployeesList = new List<Employee>();

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

            TransactionsList.Add(new Transactions(MembersList[0], 10100, DateTime.Now));
            TransactionsList.Add(new Transactions(MembersList[1], 2154, DateTime.Now.AddMonths(4)));
            TransactionsList.Add(new Transactions(MembersList[2], 2654, DateTime.Now.AddMonths(1)));
            TransactionsList.Add(new Transactions(MembersList[3], 1548, DateTime.Now.AddMonths(3)));

            Instructor I1 = new Instructor("Aya", "Khaled", "14street elrahma", 011596556, 900, DateTime.Now.AddMonths(4), (int)Instructor.ScheduleTypes.Evening);
            Instructor I2 = new Instructor("Heba", "Gamal", "14street elsafa", 0115968496, 1200, DateTime.Now.AddYears(1), (int)Instructor.ScheduleTypes.FullDay);
            Instructor I3 = new Instructor("Ahmed", "Osama", "14street elmarwa", 012759496, 4000, DateTime.Now.AddDays(15), (int)Instructor.ScheduleTypes.Morning);
            Instructor I4 = new Instructor("wafaa", "mohamed", "17street elasher ", 0127254896, 2000, DateTime.Now.AddHours(23), (int)Instructor.ScheduleTypes.FullDay);
            InstructorsList.Add(I1);
            InstructorsList.Add(I2);
            InstructorsList.Add(I3);
            InstructorsList.Add(I4);

            Employee Emp1 = new Employee("Mohamed", "Mostafa", "12street elwafaa", 018865856, 5000, DateTime.Now.AddDays(12));
            Employee Emp2 = new Employee("Ramy", "Ayman", "13street eldegwy", 018648951, 1100, DateTime.Now);
            Employee Emp3 = new Employee("Alaa", "Mohamed", "19street elfayz", 018613794, 1200, DateTime.Now.AddMonths(2));
            Employee Emp4 = new Employee("Ahlam", "Ali", "20street elmo3z", 010579243,2300, DateTime.Now);
            Employee Emp5 = new Employee("Basant", "taye3", "19street elfayz", 018613794, 1200, DateTime.Now.AddYears(1));

            EmployeesList.Add(Emp1);
            EmployeesList.Add(Emp2);
            EmployeesList.Add(Emp3);
            EmployeesList.Add(Emp4);
            EmployeesList.Add(Emp5);



           
            Equipment E1 = new Equipment("WheelSport1", 10, 1000, DateTime.Now.AddMonths(1),"sport_company");
            Equipment E2 = new Equipment("ElectricTreadmill", 13, 1200, DateTime.Now, "fitenss_company");
            EquipmentsList.Add(E1);
            EquipmentsList.Add(E2);


            Supplier s1 = new Supplier("mariam", 01111695040, "cairo", " toshiba", 1);
            Supplier s2 = new Supplier("aya", 0101050304, "alharm", "sharp", 1);
            SupplierList.Add(s1);
            SupplierList.Add(s2);

            Plan_Courses p1 = new Plan_Courses("sauna course", 1, 32.43 ,"details1");
            Plan_Courses p2 = new Plan_Courses("Aaroopeix course", 2,98.65, "details2");
            Plan_Courses p3 = new Plan_Courses("BodyBuilding course", 3, 98.65, "details3");
            Plan_CoursesList.Add(p1);
            Plan_CoursesList.Add(p2);
            Plan_CoursesList.Add(p3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
