using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Supplier
    {
        private static int lastlD = Properties.Settings.Default.LastSupplier;
       public int ID { get; private set; }
       public string Name, Company, Address;
       public int Contact_No, Equipment;

       public Supplier(string Name, int ContactNumber, string Address, string Company, int Equipment)
       {
           ID = GetNextID();
           this.Name = Name;
           this.Contact_No = ContactNumber;
           this.Address = Address;
           this.Company = Company;
           this.Equipment = Equipment;
           Properties.Settings.Default.LastSupplier = lastlD;
           Properties.Settings.Default.Save();
       }

       private int GetNextID()
       {
           return lastlD++;

       }
       public static int GetCount()
       {
           return Program.SupplierList.Count;
       }
    }
}
