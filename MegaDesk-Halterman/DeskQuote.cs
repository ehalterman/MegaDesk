using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Halterman
{
    class DeskQuote
    {
        public static string name = AddQuote.customerName;
        public static int deskWidth = Int32.Parse(AddQuote.deskWidth);
        public static int deskDepth = Int32.Parse(AddQuote.deskDepth);
        public static int drawers = Int32.Parse(AddQuote.drawers);
        public static string material = AddQuote.material;
        public static int shipping = Int32.Parse(AddQuote.shipping);
        public static int area = deskWidth * deskDepth;


        public static int totalCost()
        {
            return 200 + Desk.AreaCost(area) + Desk.drawerCost(drawers) + Desk.materialCost(material) + Desk.RushCost(shipping, area);

        }

    }
}
