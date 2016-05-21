using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_Managment
{
    public class Equipment
    {
        private static int LastID = Properties.Settings.Default.LastEquipment;
        public int ID { get; private set; }
        public string NameOfInstrument;
        public string Company;
        public int total_Quantity;
        public int price_per_Quantity;
        public int total_price;
        public DateTime Date;
        public Equipment(string Name_Of_Instrument, int Total_Quantity, int Price_per_Quantity, DateTime date, string name_of_company)
        {
            ID = GetNextID();
            NameOfInstrument = Name_Of_Instrument;
            total_Quantity = Total_Quantity;
            price_per_Quantity = Price_per_Quantity;
            total_price = Get_Total_price(Total_Quantity, Price_per_Quantity);
            Date = date;
            Company = name_of_company;
            Properties.Settings.Default.LastEquipment = LastID;
            Properties.Settings.Default.Save();
        }

        private int GetNextID()
        {
            return LastID++;
        }
        public int Get_Total_price(int t, int p)
        {
            total_price = t * p;
            return total_price;
        }
        public static int GetCount()
        {
            return Program.EquipmentsList.Count;
        }
    }
}
