using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gym_Managment
{
    static class Program
    {
        public static string Username = "";

        #region Lists/Database
        public static MembersCollection MembersList = new MembersCollection();
        public static TransactionsCollection TransactionsList = new TransactionsCollection();
        public static InstructorsCollection InstructorsList = new InstructorsCollection();
        public static EquipmentsCollection EquipmentsList = new EquipmentsCollection();
        public static SuppliersCollection SupplierList = new SuppliersCollection();
        public static Plan_CoursesCollection Plan_CoursesList = new Plan_CoursesCollection();
        public static EmployeesCollection EmployeesList = new EmployeesCollection();
        public static List<string> AllMembers;
        public static List<string> AllTransactions;
        public static List<string> AllInstructors;
        public static List<string> AllEquipments;
        public static List<string> AllSuppliers;
        public static List<string> AllPlan_Courses;
        public static List<string> AllEmployees;
        #endregion


        public static ulong ToDateTimeInt(DateTime dt)
        {
            return ulong.Parse(dt.ToString("yyyyMMddHHmmss"));
        }
        public static DateTime FromDateTimeInt(ulong val)
        {
            return new DateTime(
               (Int32)(val / 10000000000),
               (Int32)((val % 10000000000) / 100000000),
               (Int32)((val % 100000000) / 1000000),
               (Int32)((val % 1000000) / 10000),
               (Int32)((val % 10000) / 100),
               (Int32)(val % 100));
        }
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Load System
            if (!File.Exists("Database//Members.txt"))
            {
                List<string> membersToAdd = new List<string>();

                MembersList.Add(new Members("Ahmed", "Ossama", 01068514542, "3 Street Alhakam baamr allah, Shobra, Egypt.", 1, 10100, DateTime.Now));
                MembersList.Add(new Members("Mariam", "Ossama", 0106985414, "3 Street Alhakam baamr allah, Shobra, Egypt.", 3, 2154, DateTime.Now.AddMonths(4)));
                MembersList.Add(new Members("Heba", "Gamal", 0106541654, "18 Street Elmo3az Mohamed, Giza, Egypt.", 2, 2654, DateTime.Now.AddMonths(1)));
                MembersList.Add(new Members("Hanaa", "Salem", 0106216578, "3 Street Korba Street, Shobra, Egypt.", 1, 1548, DateTime.Now.AddMonths(3)));

                foreach (Members member in MembersList)
                {
                    membersToAdd.Add(member.FirstName + "~" + member.LastName + "~" + member.Contact_No + "~" + member.Address + "~" + member.PlanType + "~" + member.Amount + "~" + ToDateTimeInt(member.DateOfJoining));
                }
                File.WriteAllLines("Database//Members.txt", membersToAdd.ToArray());
                AllMembers = new List<string>(File.ReadAllLines("Database//Members.txt"));
            }
            else
            {
                AllMembers = new List<string>(File.ReadAllLines("Database//Members.txt"));
                foreach (string line in AllMembers)
                {
                    string member = line.Trim();
                    string[] data = member.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Members newMember = new Members(data[0], data[1], int.Parse(data[2]), data[3].ToString(), int.Parse(data[4]), double.Parse(data[5]), FromDateTimeInt(ulong.Parse(data[6])));
                    MembersList.Add(newMember);
                }
            }

            if (!File.Exists("Database//Transactions.txt"))
            {
                List<string> transactionsToAdd = new List<string>();

                TransactionsList.Add(new Transactions(MembersList[0], 10100, DateTime.Now));
                TransactionsList.Add(new Transactions(MembersList[1], 2154, DateTime.Now.AddMonths(4)));
                TransactionsList.Add(new Transactions(MembersList[2], 2654, DateTime.Now.AddMonths(1)));
                TransactionsList.Add(new Transactions(MembersList[3], 1548, DateTime.Now.AddMonths(3)));

                foreach (Transactions transaction in TransactionsList)
                {
                    transactionsToAdd.Add(transaction.MemberName + "~" + transaction.Amount + "~" + ToDateTimeInt(transaction.DateOfPay));
                }
                File.WriteAllLines("Database//Transactions.txt", transactionsToAdd.ToArray());
                AllTransactions = new List<string>(File.ReadAllLines("Database//Transactions.txt"));
            }
            else
            {
                AllTransactions = new List<string>(File.ReadAllLines("Database//Transactions.txt"));
                foreach (string line in AllTransactions)
                {
                    string transaction = line.Trim();
                    string[] data = transaction.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Members Member = null;
                    foreach (Members member in MembersList)
                    {
                        if (member.FirstName + " " + member.LastName == data[0])
                            Member = member;
                    }
                    Transactions newTransaction = new Transactions(Member, double.Parse(data[1]), FromDateTimeInt(ulong.Parse(data[2])));
                    TransactionsList.Add(newTransaction);
                }
            }

            if (!File.Exists("Database//Instructors.txt"))
            {
                List<string> instructorsToAdd = new List<string>();

                Instructor In1 = new Instructor("Aya", "Khaled", "14street elrahma", 011596556, 900, DateTime.Now.AddMonths(4), (int)Instructor.ScheduleTypes.Evening);
                Instructor In2 = new Instructor("Heba", "Gamal", "14street elsafa", 0115968496, 1200, DateTime.Now.AddYears(1), (int)Instructor.ScheduleTypes.FullDay);
                Instructor In3 = new Instructor("Ahmed", "Osama", "14street elmarwa", 012759496, 4000, DateTime.Now.AddDays(15), (int)Instructor.ScheduleTypes.Morning);
                Instructor In4 = new Instructor("wafaa", "mohamed", "17street elasher ", 0127254896, 2000, DateTime.Now.AddHours(23), (int)Instructor.ScheduleTypes.FullDay);
                InstructorsList.Add(In1);
                InstructorsList.Add(In2);
                InstructorsList.Add(In3);
                InstructorsList.Add(In4);

                foreach (Instructor instructor in InstructorsList)
                {
                    instructorsToAdd.Add(instructor.FirstName + "~" + instructor.LastName + "~" + instructor.Address + "~" + instructor.ContactNo + "~" + instructor.Salary + "~" + ToDateTimeInt(instructor.DateOfJoining) + "~" + instructor.Schedule);
                }
                File.WriteAllLines("Database//Insturctors.txt", instructorsToAdd.ToArray());
                AllInstructors = instructorsToAdd;
            }
            else
            {
                AllInstructors = new List<string>(File.ReadAllLines("Database//Instructors.txt"));
                foreach (string line in AllInstructors)
                {
                    string instructor = line.Trim();
                    string[] data = instructor.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Instructor newInstructor = new Instructor(data[0], data[1], data[2], int.Parse(data[3]), double.Parse(data[4]), FromDateTimeInt(ulong.Parse(data[5])), int.Parse(data[6]));
                    InstructorsList.Add(newInstructor);
                }
            }

            if (!File.Exists("Database//Equipments.txt"))
            {
                List<string> equipmentsToAdd = new List<string>();

                Equipment E1 = new Equipment("WheelSport1", 10, 1000, DateTime.Now.AddMonths(1), "sport_company");
                Equipment E2 = new Equipment("ElectricTreadmill", 13, 1200, DateTime.Now, "fitenss_company");
                EquipmentsList.Add(E1);
                EquipmentsList.Add(E2);

                foreach (Equipment equipment in EquipmentsList)
                {
                    equipmentsToAdd.Add(equipment.NameOfInstrument + "~" + equipment.total_Quantity + "~" + equipment.price_per_Quantity + "~" + ToDateTimeInt(equipment.Date) + "~" + equipment.Company);
                }

                File.WriteAllLines("Database//Equipments.txt", equipmentsToAdd.ToArray());
                AllEquipments = new List<string>(File.ReadAllLines("Database//Equipments.txt"));
            }
            else
            {
                AllEquipments = new List<string>(File.ReadAllLines("Database//Equipments.txt"));
                foreach (string line in AllEquipments)
                {
                    string equipment = line.Trim();
                    string[] data = equipment.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Equipment newEquipment = new Equipment(data[0], int.Parse(data[1]), int.Parse(data[2]), FromDateTimeInt(ulong.Parse(data[3])), data[4]);
                    EquipmentsList.Add(newEquipment);
                }
            }

            if (!File.Exists("Database//Suppliers.txt"))
            {
                List<string> suppliersToAdd = new List<string>();

                Supplier s1 = new Supplier("mariam", 01111695040, "cairo", " toshiba", 1);
                Supplier s2 = new Supplier("aya", 0101050304, "alharm", "sharp", 1);
                SupplierList.Add(s1);
                SupplierList.Add(s2);

                foreach (Supplier supplier in SupplierList)
                {
                    suppliersToAdd.Add(supplier.Name + "~" + supplier.Contact_No + "~" + supplier.Address + "~" + supplier.Company + "~" + supplier.Equipment);
                }

                File.WriteAllLines("Database//Suppliers.txt", suppliersToAdd.ToArray());
                AllSuppliers = new List<string>(File.ReadAllLines("Database//Suppliers.txt"));
            }
            else
            {
                AllSuppliers = new List<string>(File.ReadAllLines("Database//Suppliers.txt"));
                foreach (string line in AllSuppliers)
                {
                    string supplier = line.Trim();
                    string[] data = supplier.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Supplier newSupplier = new Supplier(data[0], int.Parse(data[1]), data[2], data[3], int.Parse(data[4]));
                    SupplierList.Add(newSupplier);
                }
            }

            if (!File.Exists("Database//Plan_Courses.txt"))
            {
                List<string> plansToAdd = new List<string>();

                Plan_Courses p1 = new Plan_Courses("sauna course", 1, 32.43, "details1");
                Plan_Courses p2 = new Plan_Courses("Aaroopeix course", 2, 98.65, "details2");
                Plan_Courses p3 = new Plan_Courses("BodyBuilding course", 3, 98.65, "details3");
                Plan_CoursesList.Add(p1);
                Plan_CoursesList.Add(p2);
                Plan_CoursesList.Add(p3);

                foreach (Plan_Courses plan in Plan_CoursesList)
                {
                    plansToAdd.Add(plan.planname + "~" + plan.plantype + "~" + plan.amount + "~" + plan.details);
                }

                File.WriteAllLines("Database//Plan_Courses.txt", plansToAdd.ToArray());
                AllPlan_Courses = new List<string>(File.ReadAllLines("Database//Plan_Courses.txt"));
            }
            else
            {
                AllPlan_Courses = new List<string>(File.ReadAllLines("Database//Plan_Courses.txt"));
                foreach (string line in AllPlan_Courses)
                {
                    string plan_courses = line.Trim();
                    string[] data = plan_courses.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Plan_Courses newPlan_Courses = new Plan_Courses(data[0], int.Parse(data[1]), double.Parse(data[2]), data[3]);
                    Plan_CoursesList.Add(newPlan_Courses);
                }
            }

            if (!File.Exists("Database//Employees.txt"))
            {
                List<string> employeesToAdd = new List<string>();
                Employee Emp1 = new Employee("Mohamed", "Mostafa", "mohamed", "123", "12street elwafaa", 018865856, 5000, DateTime.Now.AddDays(12));
                Employee Emp2 = new Employee("Ramy", "Ayman", "ramy", "123", "13street eldegwy", 018648951, 1100, DateTime.Now);
                Employee Emp3 = new Employee("Alaa", "Mohamed", "alaa", "alaa", "19street elfayz", 018613794, 1200, DateTime.Now.AddMonths(2));
                Employee Emp4 = new Employee("Ahlam", "Ali", "ahlam", "ahlam", "20street elmo3z", 010579243, 2300, DateTime.Now);
                Employee Emp5 = new Employee("Basant", "taye3", "basant", "basent", "19street elfayz", 018613794, 1200, DateTime.Now.AddYears(1));

                EmployeesList.Add(Emp1);
                EmployeesList.Add(Emp2);
                EmployeesList.Add(Emp3);
                EmployeesList.Add(Emp4);
                EmployeesList.Add(Emp5);

                foreach (Employee employee in EmployeesList)
                {
                    employeesToAdd.Add(employee.FirstName + "~" + employee.LastName + "~" + employee.Username + "~" + employee.Password + "~" + employee.Address + "~" + employee.Contact_num + "~" + employee.Salary + "~" + ToDateTimeInt(employee.DateOfJoining));
                }
                File.WriteAllLines("Database//Employees.txt", employeesToAdd.ToArray());
                AllEmployees = new List<string>(File.ReadAllLines("Database//Employees.txt"));
            }
            else
            {
                AllEmployees = new List<string>(File.ReadAllLines("Database//Employees.txt"));
                foreach (string line in AllEmployees)
                {
                    string employee = line.Trim();
                    string[] data = employee.Split(new string[] { "~", /*" "*/ }, StringSplitOptions.RemoveEmptyEntries);
                    Employee newEmployee = new Employee(data[0], data[1], data[2], data[3], data[4], int.Parse(data[5]), double.Parse(data[6]), FromDateTimeInt(ulong.Parse(data[7])));
                    EmployeesList.Add(newEmployee);
                }
            }
            #endregion

            #region Old Database
            //MembersList.Add(new Members("Ahmed", "Ossama", 01068514542, "3 Street Alhakam baamr allah, Shobra, Egypt.", 1, 10100, DateTime.Now));
            //MembersList.Add(new Members("Mariam", "Ossama", 0106985414, "3 Street Alhakam baamr allah, Shobra, Egypt.", 3, 2154, DateTime.Now.AddMonths(4)));
            //MembersList.Add(new Members("Heba", "Gamal", 0106541654, "18 Street Elmo3az Mohamed, Giza, Egypt.", 2, 2654, DateTime.Now.AddMonths(1)));
            //MembersList.Add(new Members("Hanaa", "Salem", 0106216578, "3 Street Korba Street, Shobra, Egypt.", 1, 1548, DateTime.Now.AddMonths(3)));
            
            //TransactionsList.Add(new Transactions(MembersList[0], 10100, DateTime.Now));
            //TransactionsList.Add(new Transactions(MembersList[1], 2154, DateTime.Now.AddMonths(4)));
            //TransactionsList.Add(new Transactions(MembersList[2], 2654, DateTime.Now.AddMonths(1)));
            //TransactionsList.Add(new Transactions(MembersList[3], 1548, DateTime.Now.AddMonths(3)));

            //Instructor I1 = new Instructor("Aya", "Khaled", "14street elrahma", 011596556, 900, DateTime.Now.AddMonths(4), (int)Instructor.ScheduleTypes.Evening);
            //Instructor I2 = new Instructor("Heba", "Gamal", "14street elsafa", 0115968496, 1200, DateTime.Now.AddYears(1), (int)Instructor.ScheduleTypes.FullDay);
            //Instructor I3 = new Instructor("Ahmed", "Osama", "14street elmarwa", 012759496, 4000, DateTime.Now.AddDays(15), (int)Instructor.ScheduleTypes.Morning);
            //Instructor I4 = new Instructor("wafaa", "mohamed", "17street elasher ", 0127254896, 2000, DateTime.Now.AddHours(23), (int)Instructor.ScheduleTypes.FullDay);
            //InstructorsList.Add(I1);
            //InstructorsList.Add(I2);
            //InstructorsList.Add(I3);
            //InstructorsList.Add(I4);

            //Employee Emp1 = new Employee("Mohamed", "Mostafa", "mohamed" , "123" ,"12street elwafaa", 018865856, 5000, DateTime.Now.AddDays(12));
            //Employee Emp2 = new Employee("Ramy", "Ayman", "ramy" ,"123", "13street eldegwy", 018648951, 1100, DateTime.Now);
            //Employee Emp3 = new Employee("Alaa", "Mohamed", "alaa", "alaa", "19street elfayz", 018613794, 1200, DateTime.Now.AddMonths(2));
            //Employee Emp4 = new Employee("Ahlam", "Ali", "ahlam", "ahlam", "20street elmo3z", 010579243, 2300, DateTime.Now);
            //Employee Emp5 = new Employee("Basant", "taye3", "basant", "basent", "19street elfayz", 018613794, 1200, DateTime.Now.AddYears(1));

            //EmployeesList.Add(Emp1);
            //EmployeesList.Add(Emp2);
            //EmployeesList.Add(Emp3);
            //EmployeesList.Add(Emp4);
            //EmployeesList.Add(Emp5);
           
            //Equipment E1 = new Equipment("WheelSport1", 10, 1000, DateTime.Now.AddMonths(1),"sport_company");
            //Equipment E2 = new Equipment("ElectricTreadmill", 13, 1200, DateTime.Now, "fitenss_company");
            //EquipmentsList.Add(E1);
            //EquipmentsList.Add(E2);

            //Supplier s1 = new Supplier("mariam", 01111695040, "cairo", " toshiba", 1);
            //Supplier s2 = new Supplier("aya", 0101050304, "alharm", "sharp", 1);
            //SupplierList.Add(s1);
            //SupplierList.Add(s2);

            //Plan_Courses p1 = new Plan_Courses("sauna course", 1, 32.43 ,"details1");
            //Plan_Courses p2 = new Plan_Courses("Aaroopeix course", 2,98.65, "details2");
            //Plan_Courses p3 = new Plan_Courses("BodyBuilding course", 3, 98.65, "details3");
            //Plan_CoursesList.Add(p1);
            //Plan_CoursesList.Add(p2);
            //Plan_CoursesList.Add(p3);
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
