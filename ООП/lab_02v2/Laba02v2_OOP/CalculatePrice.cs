using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba02v2_OOP
{
    class CalculatePrice
    {
        public static int Price()
        {
            int priceLaboratory = 0;
            string jsonFilePath = "Computer.json";
            string json = File.ReadAllText(jsonFilePath);

            List<Computer> computers = JsonConvert.DeserializeObject<List<Computer>>(json);

            foreach (var computer in computers)
            {
                switch (computer.typeComputer)
                {
                    case "Workstation ":
                        priceLaboratory += 250;
                        break;
                    case "Server ":
                        priceLaboratory += 500;
                        break;
                    case "Laptop ":
                        priceLaboratory += 200;
                        break;
                    default:
                        priceLaboratory += 0;
                        break;
                }

                switch (computer.typeRAM)
                {
                    case "DDR3":
                        priceLaboratory += 350;
                        break;
                    case "DDR4":
                        priceLaboratory += 700;
                        break;
                    case "DDR5":
                        priceLaboratory += 1000;
                        break;
                    default:
                        priceLaboratory += 0;
                        break;
                }


                try
                {
                    priceLaboratory += computer.sizeRam * 10;
                }
                catch { }


                switch (computer.typeMemory)
                {
                    case "HDD":
                        priceLaboratory += 200;
                        break;
                    case "SSD":
                        priceLaboratory += 500;
                        break;
                    default:
                        priceLaboratory += 0;
                        break;
                }

                try
                {
                    priceLaboratory += computer.sizeMemory;
                }
                catch { }
            }

            return priceLaboratory;
        }
    }
}
