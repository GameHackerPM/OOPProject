using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Instructor
    {
        private static int LastID = 1;
        public int ID{get; private set;}
        public string FirstName, LastName, Address;
        public int ContactNo;
        public double Salary;
        public DateTime DateOfJoining;
        public int Schedule;
        public Instructor(string FirstName, string lastName, string address, int contactNo, double salary, DateTime dateOfJoining, int schedule)
        {
            ID = LastID++;
           this.FirstName = FirstName;
           LastName = lastName;
           Address = address;
           ContactNo = contactNo;
           Salary = salary;
           DateOfJoining = dateOfJoining;
           Schedule = schedule;          
        }

        public static int GetCount()
        {
            return Program.InstructorsList.Count ;
        }
        
      
    }
}
