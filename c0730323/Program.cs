using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730323
{
    class Program
    {
        static void Main(string[] args)
        {



        }
        class Countryside
        {
            
            village Alst;
            village Maeland;
            village schenig;
                public void initializemap()
            { 
                 Alst = new village();
                Alst.VillageName = "Alst";
                 Maeland = new village();
                Maeland.VillageName = " Maeland";
                Maeland.isAstrildeHere = true;
                schenig = new village();
                schenig.VillageName = "schenig";

                Alst.Nextvillage = Maeland;
                Maeland.Nextvillage = schenig;
                schenig.Nextvillage = Alst;

            }
            public void FindAstrilde()
            {
                 village CurrentVillage = this.Maeland;
                if (CurrentVillage.isAstrildeHere)
                {
                    Console.WriteLine("hugi Found astrilde!!! Celebrations! XOXO");
                }
                village NextVillage;
                NextVillage = CurrentVillage.Nextvillage;
            }
        }
        class village
        {
            public village Previousvillage;
            public village Nextvillage;
            public string VillageName;
            public bool isAstrildeHere = false;

            public village() { }
        }
    }
}
