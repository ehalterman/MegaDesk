using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Halterman
{
    
    class Desk
    {

        public static int AreaCost(int area)
        { 
           if (area > 1000)
            {
                return (area - 1000);
            }
           else
            {
                return 0;
            }
        }
        public static int RushCost(int shipping, int area)
        {
            if (shipping == 3)
            {
                if (area < 1000)
                {
                    return 60;
                }
                else if (1000 <= area && area <= 2000)
                {
                    return 70;
                }
                else
                {
                    return 80;
                }
            }
            else if (shipping == 5)
            {
                if (area < 1000)
                {
                    return 40;
                }
                else if (1000 <= area && area <= 2000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (shipping == 7)
            {
                if (area < 1000)
                {
                    return 30;
                }
                else if (1000 <= area && area <= 2000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            else
            {
                return 0;
            }
        }
    public static int materialCost(string material)
        {
            if (material == "Oak")
            {
                return 200;
            }
            else if (material == "Laminate")
            {
                return 100;
            }
            else if (material == "Pine")
            {
                return 50;
            }
            else if (material == "Rosewood")
            {
                return 300;
            }
            else if (material == "Veneer")
            {
                return 125;
            }
            else
            {
                return 0;
            }
        } 
        public static int drawerCost(int drawers)
        {
            return drawers * 50;
        }
    }
}
