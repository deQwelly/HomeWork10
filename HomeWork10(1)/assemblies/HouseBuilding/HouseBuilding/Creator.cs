using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuildingLibruary
{
    public class Creator
    {
        private static Hashtable houseTable = new Hashtable();

        private Creator() { }

        public static House CreateHouse(uint heigh, uint storeys, uint appartments, uint entrances)
        {
            House house = new House(heigh, storeys, appartments, entrances);
            houseTable.Add(house.Number, house);
            return house;
        }

        public static void RemoveHouse(uint number)
        {
            if (houseTable.ContainsKey(number))
            {
                houseTable.Remove(number);
                Console.WriteLine("Здание успешно снесено");
            }
            else
            {
                Console.WriteLine("Здания с таким номером не существует");
            }
        }
    }
}
