using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    class Employee
    {
        private static int LastID = 1;
        public int ID {get; private set; }
        public string FirstName, LastName, Address;
        public string Username, Password; //ADD this !
        public int Contact_num;
        public double Salary;
        public DateTime DateOfJoining;

        public Employee(string firstname,string lastname, string username, string password, string Address,int contact_num,double salary ,DateTime DateOfJoining)
        {
            ID = LastID++;
            FirstName = firstname;
            LastName = lastname;
            this.Address=Address;
            Contact_num = contact_num;
            Salary = salary;
            this.DateOfJoining = DateOfJoining;
            Username = username;
            Password = password;

        }
        public static int Getcount()
        {
            return Program.EmployeesList.Count;
        }

    }
}
