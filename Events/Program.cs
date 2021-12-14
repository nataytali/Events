using System;
using System.Windows.Forms;
using System.Drawing;

namespace Events
{
    public delegate void DelEventHandler();

    class Program : Form
    {


        public Program()
        {

            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Hit Me";
            btn.Location = new Point(100, 100);

            btn.Click += new EventHandler(onClcik);

        }     

        public void onClcik(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());

            Console.ReadLine();
        }
    }

}
