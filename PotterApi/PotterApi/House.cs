using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterApi
{
    class House
    {
        public string Id { get; set; } = "unknown";
        public string Name { get; set; } = "unknown";
        public string Mascot { get; set; } = "unknown";
        public string HeadOfHouse { get; set; } = "unknown";
        public string HouseGhost { get; set; } = "unknown";
        public string Founder { get; set; } = "unknown";
        public string School { get; set; } = "unknown";

        public void Show() { Console.WriteLine("Name: " + Name); }
        public void ShowAll() { Console.WriteLine("Name: " + Name+ "\nMascot: " + Mascot+ "\nHeadOfHouse: " + HeadOfHouse+ "\nHouseGhost: " + HouseGhost+ "\nFounder: " + Founder+ "\nSchool: " + School); }
    }
}
