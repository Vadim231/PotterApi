using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PotterApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoCharacter;
            WebClient client = new WebClient();
            int caseNumber = 0;
            while (caseNumber != 5)
            {
                Console.WriteLine("\n1:Персонажи \n2:Шляпа \n3:Заклинания \n4:Факультеты \n5:Выход");
                if (!int.TryParse(Console.ReadLine(), out int res))
                {
                    Console.WriteLine("Введено неправильно значение");
                }
                else
                {
                    caseNumber = res;
                    switch (caseNumber)
                    {
                        case 1:
                            //Персонажи
                            infoCharacter = client.DownloadString(@"https://www.potterapi.com/v1/characters?key=$2a$10$ej3ReGEXJXtgS9HYNvK8eu01XUwctQNSs4vdUIFdjrBxEm3GeYtym");
                            var rootobject = JsonConvert.DeserializeObject<List<Characters>>(infoCharacter);
                            int characterIndex = 0;
                            foreach (var character in rootobject)
                            {
                                Console.WriteLine(characterIndex++);
                                character.ShowName();
                            }
                            int characterChoice;
                            if (!int.TryParse(Console.ReadLine(), out int res2))
                            {
                                Console.WriteLine("Введено неправильно значение");
                            }
                            else
                            {
                                characterChoice = res2;

                                try { rootobject[characterChoice].ShowAll(); }
                                catch (ArgumentOutOfRangeException) { Console.WriteLine("Выход за пределы"); }
                            }
                            break;
                        case 2:
                            //Шляпа
                            string infoHat = client.DownloadString(@"https://www.potterapi.com/v1/sortingHat?key=$2a$10$ej3ReGEXJXtgS9HYNvK8eu01XUwctQNSs4vdUIFdjrBxEm3GeYtym");
                            Console.WriteLine(infoHat);
                            break;
                        case 3:
                            //Заклинания
                            string infoSpells = client.DownloadString(@"https://www.potterapi.com/v1/spells?key=$2a$10$ej3ReGEXJXtgS9HYNvK8eu01XUwctQNSs4vdUIFdjrBxEm3GeYtym");
                            var rootObject3 = JsonConvert.DeserializeObject<List<Spell>>(infoSpells);
                            int spellIndex = 0;
                            foreach (var species in rootObject3)
                            {
                                Console.WriteLine(spellIndex++);
                                species.Show();
                            }
                            int spellChoice;
                            if (!int.TryParse(Console.ReadLine(), out int res3))
                            {
                                Console.WriteLine("Введено неправильно значение");
                            }
                            else
                            {
                                spellChoice = res3;
                                try { rootObject3[spellChoice].ShowAll(); }
                                catch (ArgumentOutOfRangeException) { Console.WriteLine("Выход за пределы"); }
                            }
                            break;
                        case 4:
                            //Факультеты
                            string infoHouses = client.DownloadString(@"https://www.potterapi.com/v1/houses?key=$2a$10$ej3ReGEXJXtgS9HYNvK8eu01XUwctQNSs4vdUIFdjrBxEm3GeYtym");

                            var rootObject4 = JsonConvert.DeserializeObject<List<House>>(infoHouses);
                            int houseIndex = 0;
                            foreach (var species in rootObject4)
                            {
                                Console.WriteLine(houseIndex++);
                                species.Show();
                            }
                            int houseChoice;
                            if (!int.TryParse(Console.ReadLine(), out int res4))
                            {
                                Console.WriteLine("Введено неправильно значение");
                            }
                            else
                            {
                                houseChoice = res4;
                                try { rootObject4[houseChoice].ShowAll(); }
                                catch (ArgumentOutOfRangeException) { Console.WriteLine("Выход за пределы"); }
                            }
                            break;
                        case 5: break;
                        default:
                            Console.WriteLine("Введено неправильно значение");
                            break;
                    }
                }
            }
            Console.WriteLine("Работа программы завершена");
            Console.ReadLine();
        }
    }
}
