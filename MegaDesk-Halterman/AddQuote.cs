using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Halterman
{
    public partial class AddQuote : Form
    {
        public static string customerName;
        public static string deskWidth;
        public static string deskDepth;
        public static string drawers;
        public static string material;
        public static string shipping;


        public AddQuote()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string customerName = Console.ReadLine();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            nameInput.Text = customerName;
            widthInput.Text = deskWidth;
            depthInput.Text = deskDepth;
            drawersInput.Text = drawers;
            desktopInput.Text = material;
            shippingInput.Text = shipping;



            var displayQuotes = new DisplayQuote();
            displayQuotes.Show();
        }
    }
}
