using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LP50Touch
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.AcceptButton = button47;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            APPLEL menu = new APPLEL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            APPLEM menu = new APPLEM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            APPLES menu = new APPLES();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            CHERRYL menu = new CHERRYL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            CHERRYM menu = new CHERRYM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            CHERRYS menu = new CHERRYS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            KIWIL menu = new KIWIL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KIWIM menu = new KIWIM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KIWIS menu = new KIWIS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LEMONL menu = new LEMONL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LEMONМ menu = new LEMONМ();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LEMONS menu = new LEMONS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PEARL menu = new PEARL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PEARM menu = new PEARM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PEARS menu = new PEARS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ORANGEL menu = new ORANGEL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ORANGEM menu = new ORANGEM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ORANGES menu = new ORANGES();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BANANAL menu = new BANANAL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BANANAM menu = new BANANAM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BANANAS menu = new BANANAS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            PEACHL menu = new PEACHL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            PEACHM menu = new PEACHM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            PEACHS menu = new PEACHS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            GRAPEL menu = new GRAPEL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GRAPEM menu = new GRAPEM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            GRAPES menu = new GRAPES();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            BBERRYL menu = new BBERRYL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            BBERRYM menu = new BBERRYM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            BBERRYS menu = new BBERRYS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            RBERRYS menu = new RBERRYS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            RBERRYM menu = new RBERRYM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            RBERRYL menu = new RBERRYL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            SBERRYS menu = new SBERRYS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            SBERRYM menu = new SBERRYM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            SBERRYL menu = new SBERRYL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            BCURRS menu = new BCURRS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            BCURRM menu = new BCURRM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            BCURRL menu = new BCURRL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            APRICOTS menu = new APRICOTS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            APRICOTM menu = new APRICOTM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            APRICOTL menu = new APRICOTL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            BLBERRYS menu = new BLBERRYS();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            BLBERRYM menu = new BLBERRYM();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            BLBERRYL menu = new BLBERRYL();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }
        private void AdminMenu_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\appleProduct.txt");
            textBox17.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherryProduct.txt");
            textBox18.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwiProduct.txt");
            textBox19.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonProduct.txt");
            textBox20.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearProduct.txt");
            textBox6.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangeProduct.txt");
            textBox7.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananaProduct.txt");
            textBox8.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachProduct.txt");
            textBox9.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapeProduct.txt");
            textBox10.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberryProduct.txt");
            textBox11.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberryProduct.txt");
            textBox12.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberryProduct.txt");
            textBox13.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrProduct.txt");
            textBox14.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotProduct.txt");
            textBox15.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberryProduct.txt");

            textBox16.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");

            


            //product 1...
            string buttonsColor1 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt");
            button1.BackColor = Color.FromName(buttonsColor1);
            button21.BackColor = Color.FromName(buttonsColor1);
            button20.BackColor = Color.FromName(buttonsColor1);
            //product 2...
            string buttonsColor2 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt");
            button19.BackColor = Color.FromName(buttonsColor2);
            button17.BackColor = Color.FromName(buttonsColor2);
            button18.BackColor = Color.FromName(buttonsColor2);
            //product 3...
            string buttonsColor3 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt");
            button16.BackColor = Color.FromName(buttonsColor3);
            button14.BackColor = Color.FromName(buttonsColor3);
            button15.BackColor = Color.FromName(buttonsColor3);
            //product 4...
            string buttonsColor4 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt");
            button13.BackColor = Color.FromName(buttonsColor4);
            button11.BackColor = Color.FromName(buttonsColor4);
            button12.BackColor = Color.FromName(buttonsColor4);
            //product 5...
            string buttonsColor5 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt");
            button10.BackColor = Color.FromName(buttonsColor5);
            button8.BackColor = Color.FromName(buttonsColor5);
            button9.BackColor = Color.FromName(buttonsColor5);
            //product 6...
            string buttonsColor6 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt");
            button30.BackColor = Color.FromName(buttonsColor6);
            button28.BackColor = Color.FromName(buttonsColor6);
            button29.BackColor = Color.FromName(buttonsColor6);
            //product 7...
            string buttonsColor7 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt");
            button27.BackColor = Color.FromName(buttonsColor7);
            button25.BackColor = Color.FromName(buttonsColor7);
            button26.BackColor = Color.FromName(buttonsColor7);
            //product 8...
            string buttonsColor8 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt");
            button24.BackColor = Color.FromName(buttonsColor8);
            button22.BackColor = Color.FromName(buttonsColor8);
            button23.BackColor = Color.FromName(buttonsColor8);
            //product 9...
            string buttonsColor9 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt");
            button7.BackColor = Color.FromName(buttonsColor9);
            button5.BackColor = Color.FromName(buttonsColor9);
            button6.BackColor = Color.FromName(buttonsColor9);
            //product 10...
            string buttonsColor10 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt");
            button4.BackColor = Color.FromName(buttonsColor10);
            button2.BackColor = Color.FromName(buttonsColor10);
            button3.BackColor = Color.FromName(buttonsColor10);
            //product 11...
            string buttonsColor11 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt");
            button45.BackColor = Color.FromName(buttonsColor11);
            button43.BackColor = Color.FromName(buttonsColor11);
            button44.BackColor = Color.FromName(buttonsColor11);
            //product 12...
            string buttonsColor12 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt");
            button42.BackColor = Color.FromName(buttonsColor12);
            button40.BackColor = Color.FromName(buttonsColor12);
            button41.BackColor = Color.FromName(buttonsColor12);
            //product 13...
            string buttonsColor13 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt");
            button39.BackColor = Color.FromName(buttonsColor13);
            button37.BackColor = Color.FromName(buttonsColor13);
            button38.BackColor = Color.FromName(buttonsColor13);
            //product 14...
            string buttonsColor14 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt");
            button36.BackColor = Color.FromName(buttonsColor14);
            button35.BackColor = Color.FromName(buttonsColor14);
            button34.BackColor = Color.FromName(buttonsColor14);
            //product 15...
            string buttonsColor15 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt");
            button33.BackColor = Color.FromName(buttonsColor15);
            button31.BackColor = Color.FromName(buttonsColor15);
            button32.BackColor = Color.FromName(buttonsColor15);

            
           
        }
        
        
        private void button47_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\appleProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\appleProduct.txt", textBox1.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\cherryProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\cherryProduct.txt",textBox17.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\kiwiProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\kiwiProduct.txt",textBox18.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\lemonProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\lemonProduct.txt",textBox19.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\pearProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\pearProduct.txt",textBox20.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bberryProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bberryProduct.txt",textBox10.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\grapeProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\grapeProduct.txt",textBox9.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\peachProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\peachProduct.txt",textBox8.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bananaProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bananaProduct.txt",textBox7.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\orangeProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\orangeProduct.txt",textBox6.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\rberryProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\rberryProduct.txt",textBox11.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\sberryProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\sberryProduct.txt",textBox12.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bcurrProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\bcurrProduct.txt", textBox13.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\apricotProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\apricotProduct.txt", textBox14.Text);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\blberryProduct.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\PriceList\blberryProduct.txt",textBox15.Text);


            string comNumber = textBox16.Text;
            
            System.IO.File.WriteAllText(@"C:\LP-50Touch\comPort.txt", string.Empty);
            System.IO.File.WriteAllText(@"C:\LP-50Touch\comPort.txt", comNumber);

            
            
            this.Close();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //first palette...

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSlateBlue;
            button20.BackColor = Color.MediumSlateBlue;
            button21.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt",string.Empty);
            string palette1 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt",palette1);
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button20.BackColor = Color.Orange;
            button21.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Violet;
            button20.BackColor = Color.Violet;
            button21.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button20.BackColor = Color.Yellow;
            button21.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Turquoise;
            button20.BackColor = Color.Turquoise;
            button21.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.SkyBlue;
            button20.BackColor = Color.SkyBlue;
            button21.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Magenta;
            button20.BackColor = Color.Magenta;
            button21.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.MistyRose;
            button20.BackColor = Color.MistyRose;
            button21.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
            button20.BackColor = Color.Lime;
            button21.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
            button20.BackColor = Color.Gold;
            button21.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Thistle;
            button20.BackColor = Color.Thistle;
            button21.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button20.BackColor = Color.Aqua;
            button21.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.PeachPuff;
            button20.BackColor = Color.PeachPuff;
            button21.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.GreenYellow;
            button20.BackColor = Color.GreenYellow;
            button21.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.PaleGoldenrod;
            button20.BackColor = Color.PaleGoldenrod;
            button21.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", string.Empty);
            string palette1 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt", palette1);
        }
        //here comes the 2nd pallette...
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.MediumSlateBlue;
            button17.BackColor = Color.MediumSlateBlue;
            button18.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Orange;
            button17.BackColor = Color.Orange;
            button18.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Violet;
            button17.BackColor = Color.Violet;
            button18.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);

        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Yellow;
            button17.BackColor = Color.Yellow;
            button18.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Turquoise;
            button17.BackColor = Color.Turquoise;
            button18.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.SkyBlue;
            button17.BackColor = Color.SkyBlue;
            button18.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Magenta;
            button17.BackColor = Color.Magenta;
            button18.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.MistyRose;
            button17.BackColor = Color.MistyRose;
            button18.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Lime;
            button17.BackColor = Color.Lime;
            button18.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Gold;
            button17.BackColor = Color.Gold;
            button18.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Thistle;
            button17.BackColor = Color.Thistle;
            button18.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Aqua;
            button17.BackColor = Color.Aqua;
            button18.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.PeachPuff;
            button17.BackColor = Color.PeachPuff;
            button18.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.GreenYellow;
            button17.BackColor = Color.GreenYellow;
            button18.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.PaleGoldenrod;
            button17.BackColor = Color.PaleGoldenrod;
            button18.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", string.Empty);
            string palette2 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt", palette2);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image1.gif");
                File.Copy(sourceFile,@"C:\LP-50Touch\UserInterface\Images\image1.gif");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image2.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image2.gif");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            toolTip1.Show("От тези бутони можете да заредите ваша снимка за съответния артикул.", button63);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            toolTip3.Show("От тези бутони можете да смените името, баркода и цената на съответния артикул.", button66);
        }

        private void pictureBox244_Click(object sender, EventArgs e)
        {
            toolTip2.Show("От тези бутони можете да изберете цвят за съответните артикулни бутони.", pictureBox244);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            toolTip5.Show("От тези бутони можете да смените името, баркода и цената на съответния артикул.", button64);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            toolTip4.Show("От тези бутони можете да смените името, баркода и цената на съответния артикул.", button65);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image3.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image3.gif");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image4.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image4.gif");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image5.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image5.gif");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image6.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image6.gif");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image7.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image7.gif");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image8.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image8.gif");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image9.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image9.gif");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image10.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image10.gif");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image11.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image11.gif");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image12.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image12.gif");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image13.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image13.gif");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image14.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image14.gif");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "GIF files|*.gif";
            openFileDialog1.FileName = "Изберете файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string sourceFile = openFileDialog1.FileName;
                string sourceFolder = Path.GetDirectoryName(sourceFile);
                File.Delete(@"C:\LP-50Touch\UserInterface\Images\image15.gif");
                File.Copy(sourceFile, @"C:\LP-50Touch\UserInterface\Images\image15.gif");
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.MediumSlateBlue;
            button14.BackColor = Color.MediumSlateBlue;
            button15.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Orange;
            button14.BackColor = Color.Orange;
            button15.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3= "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Violet;
            button14.BackColor = Color.Violet;
            button15.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Yellow;
            button14.BackColor = Color.Yellow;
            button15.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Turquoise;
            button14.BackColor = Color.Turquoise;
            button15.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.SkyBlue;
            button14.BackColor = Color.SkyBlue;
            button15.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Magenta;
            button14.BackColor = Color.Magenta;
            button15.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.MistyRose;
            button14.BackColor = Color.MistyRose;
            button15.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Lime;
            button14.BackColor = Color.Lime;
            button15.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Gold;
            button14.BackColor = Color.Gold;
            button15.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Thistle;
            button14.BackColor = Color.Thistle;
            button15.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Aqua;
            button14.BackColor = Color.Aqua;
            button15.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.PeachPuff;
            button14.BackColor = Color.PeachPuff;
            button15.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.GreenYellow;
            button14.BackColor = Color.GreenYellow;
            button15.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.PaleGoldenrod;
            button14.BackColor = Color.PaleGoldenrod;
            button15.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", string.Empty);
            string palette3 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt", palette3);
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.MediumSlateBlue;
            button11.BackColor = Color.MediumSlateBlue;
            button12.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Orange;
            button11.BackColor = Color.Orange;
            button12.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Violet;
            button11.BackColor = Color.Violet;
            button12.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Yellow;
            button11.BackColor = Color.Yellow;
            button12.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Turquoise;
            button11.BackColor = Color.Turquoise;
            button12.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.SkyBlue;
            button11.BackColor = Color.SkyBlue;
            button12.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Magenta;
            button11.BackColor = Color.Magenta;
            button12.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.MistyRose;
            button11.BackColor = Color.MistyRose;
            button12.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Lime;
            button11.BackColor = Color.Lime;
            button12.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Gold;
            button11.BackColor = Color.Gold;
            button12.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Thistle;
            button11.BackColor = Color.Thistle;
            button12.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Aqua;
            button11.BackColor = Color.Aqua;
            button12.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.PeachPuff;
            button11.BackColor = Color.PeachPuff;
            button12.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.GreenYellow;
            button11.BackColor = Color.GreenYellow;
            button12.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.PaleGoldenrod;
            button11.BackColor = Color.PaleGoldenrod;
            button12.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", string.Empty);
            string palette4 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt", palette4);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.MediumSlateBlue;
            button8.BackColor = Color.MediumSlateBlue;
            button9.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Orange;
            button8.BackColor = Color.Orange;
            button9.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Violet;
            button8.BackColor = Color.Violet;
            button9.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Yellow;
            button8.BackColor = Color.Yellow;
            button9.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Turquoise;
            button8.BackColor = Color.Turquoise;
            button9.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.SkyBlue;
            button8.BackColor = Color.SkyBlue;
            button9.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Magenta;
            button8.BackColor = Color.Magenta;
            button9.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.MistyRose;
            button8.BackColor = Color.MistyRose;
            button9.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Lime;
            button8.BackColor = Color.Lime;
            button9.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Gold;
            button8.BackColor = Color.Gold;
            button9.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Thistle;
            button8.BackColor = Color.Thistle;
            button9.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Aqua;
            button8.BackColor = Color.Aqua;
            button9.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.PeachPuff;
            button8.BackColor = Color.PeachPuff;
            button9.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.GreenYellow;
            button8.BackColor = Color.GreenYellow;
            button9.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.PaleGoldenrod;
            button8.BackColor = Color.PaleGoldenrod;
            button9.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", string.Empty);
            string palette5 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt", palette5);
        }

        private void pictureBox141_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.MediumSlateBlue;
            button28.BackColor = Color.MediumSlateBlue;
            button29.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox139_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Orange;
            button28.BackColor = Color.Orange;
            button29.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox142_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Violet;
            button28.BackColor = Color.Violet;
            button29.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox144_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Yellow;
            button28.BackColor = Color.Yellow;
            button29.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox148_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Turquoise;
            button28.BackColor = Color.Turquoise;
            button29.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox140_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.SkyBlue;
            button28.BackColor = Color.SkyBlue;
            button29.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox146_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Magenta;
            button28.BackColor = Color.Magenta;
            button29.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox150_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.MistyRose;
            button28.BackColor = Color.MistyRose;
            button29.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox145_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Lime;
            button28.BackColor = Color.Lime;
            button29.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox149_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Gold;
            button28.BackColor = Color.Gold;
            button29.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox143_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Thistle;
            button28.BackColor = Color.Thistle;
            button29.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox147_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.Aqua;
            button28.BackColor = Color.Aqua;
            button29.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox151_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.PeachPuff;
            button28.BackColor = Color.PeachPuff;
            button29.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox152_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.GreenYellow;
            button28.BackColor = Color.GreenYellow;
            button29.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox153_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.PaleGoldenrod;
            button28.BackColor = Color.PaleGoldenrod;
            button29.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", string.Empty);
            string palette6 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt", palette6);
        }

        private void pictureBox229_Click(object sender, EventArgs e)
        {
            toolTip6.Show("От това поле може да смените името на съответния артикул.", pictureBox229);
        }

        private void pictureBox126_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.MediumSlateBlue;
            button25.BackColor = Color.MediumSlateBlue;
            button26.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox124_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Orange;
            button25.BackColor = Color.Orange;
            button26.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox127_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Violet;
            button25.BackColor = Color.Violet;
            button26.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox129_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Yellow;
            button25.BackColor = Color.Yellow;
            button26.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox133_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Turquoise;
            button25.BackColor = Color.Turquoise;
            button26.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox125_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.SkyBlue;
            button25.BackColor = Color.SkyBlue;
            button26.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox131_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Magenta;
            button25.BackColor = Color.Magenta;
            button26.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox135_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.MistyRose;
            button25.BackColor = Color.MistyRose;
            button26.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox130_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Lime;
            button25.BackColor = Color.Lime;
            button26.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox134_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Gold;
            button25.BackColor = Color.Gold;
            button26.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox128_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Thistle;
            button25.BackColor = Color.Thistle;
            button26.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox132_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Aqua;
            button25.BackColor = Color.Aqua;
            button26.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox136_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.PeachPuff;
            button25.BackColor = Color.PeachPuff;
            button26.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox137_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.GreenYellow;
            button25.BackColor = Color.GreenYellow;
            button26.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox138_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.PaleGoldenrod;
            button25.BackColor = Color.PaleGoldenrod;
            button26.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", string.Empty);
            string palette7 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt", palette7);
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.MediumSlateBlue;
            button22.BackColor = Color.MediumSlateBlue;
            button23.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Orange;
            button22.BackColor = Color.Orange;
            button23.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Violet;
            button22.BackColor = Color.Violet;
            button23.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Yellow;
            button22.BackColor = Color.Yellow;
            button23.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox118_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Turquoise;
            button22.BackColor = Color.Turquoise;
            button23.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.SkyBlue;
            button22.BackColor = Color.SkyBlue;
            button23.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox116_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Magenta;
            button22.BackColor = Color.Magenta;
            button23.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox120_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.MistyRose;
            button22.BackColor = Color.MistyRose;
            button23.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Lime;
            button22.BackColor = Color.Lime;
            button23.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox119_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Gold;
            button22.BackColor = Color.Gold;
            button23.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Thistle;
            button22.BackColor = Color.Thistle;
            button23.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox117_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Aqua;
            button22.BackColor = Color.Aqua;
            button23.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox121_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.PeachPuff;
            button22.BackColor = Color.PeachPuff;
            button23.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox122_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.GreenYellow;
            button22.BackColor = Color.GreenYellow;
            button23.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox123_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.PaleGoldenrod;
            button22.BackColor = Color.PaleGoldenrod;
            button23.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", string.Empty);
            string palette8 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt", palette8);
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.MediumSlateBlue;
            button5.BackColor = Color.MediumSlateBlue;
            button6.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Orange;
            button5.BackColor = Color.Orange;
            button6.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Violet;
            button5.BackColor = Color.Violet;
            button6.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Turquoise;
            button5.BackColor = Color.Turquoise;
            button6.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.SkyBlue;
            button5.BackColor = Color.SkyBlue;
            button6.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Magenta;
            button5.BackColor = Color.Magenta;
            button6.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.MistyRose;
            button5.BackColor = Color.MistyRose;
            button6.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lime;
            button5.BackColor = Color.Lime;
            button6.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gold;
            button5.BackColor = Color.Gold;
            button6.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Thistle;
            button5.BackColor = Color.Thistle;
            button6.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Aqua;
            button5.BackColor = Color.Aqua;
            button6.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.PeachPuff;
            button5.BackColor = Color.PeachPuff;
            button6.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.GreenYellow;
            button5.BackColor = Color.GreenYellow;
            button6.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.PaleGoldenrod;
            button5.BackColor = Color.PaleGoldenrod;
            button6.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", string.Empty);
            string palette9 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt", palette9);
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.MediumSlateBlue;
            button2.BackColor = Color.MediumSlateBlue;
            button3.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Violet;
            button2.BackColor = Color.Violet;
            button3.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Turquoise;
            button2.BackColor = Color.Turquoise;
            button3.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.SkyBlue;
            button2.BackColor = Color.SkyBlue;
            button3.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Magenta;
            button2.BackColor = Color.Magenta;
            button3.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.MistyRose;
            button2.BackColor = Color.MistyRose;
            button3.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lime;
            button2.BackColor = Color.Lime;
            button3.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gold;
            button2.BackColor = Color.Gold;
            button3.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Thistle;
            button2.BackColor = Color.Thistle;
            button3.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Aqua;
            button2.BackColor = Color.Aqua;
            button3.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.PeachPuff;
            button2.BackColor = Color.PeachPuff;
            button3.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.GreenYellow;
            button2.BackColor = Color.GreenYellow;
            button3.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.PaleGoldenrod;
            button2.BackColor = Color.PaleGoldenrod;
            button3.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", string.Empty);
            string palette10 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt", palette10);
        }

        private void pictureBox216_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.MediumSlateBlue;
            button43.BackColor = Color.MediumSlateBlue;
            button44.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox214_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Orange;
            button43.BackColor = Color.Orange;
            button44.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox217_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Violet;
            button43.BackColor = Color.Violet;
            button44.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox219_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Yellow;
            button43.BackColor = Color.Yellow;
            button44.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox223_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Turquoise;
            button43.BackColor = Color.Turquoise;
            button44.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox215_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.SkyBlue;
            button43.BackColor = Color.SkyBlue;
            button44.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox221_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Magenta;
            button43.BackColor = Color.Magenta;
            button44.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox225_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.MistyRose;
            button43.BackColor = Color.MistyRose;
            button44.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox220_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Lime;
            button43.BackColor = Color.Lime;
            button44.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox224_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Gold;
            button43.BackColor = Color.Gold;
            button44.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox218_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Thistle;
            button43.BackColor = Color.Thistle;
            button44.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox222_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.Aqua;
            button43.BackColor = Color.Aqua;
            button44.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox226_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.PeachPuff;
            button43.BackColor = Color.PeachPuff;
            button44.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox227_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.GreenYellow;
            button43.BackColor = Color.GreenYellow;
            button44.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox228_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.PaleGoldenrod;
            button43.BackColor = Color.PaleGoldenrod;
            button44.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", string.Empty);
            string palette11 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt", palette11);
        }

        private void pictureBox201_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.MediumSlateBlue;
            button40.BackColor = Color.MediumSlateBlue;
            button41.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox199_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Orange;
            button40.BackColor = Color.Orange;
            button41.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox202_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Violet;
            button40.BackColor = Color.Violet;
            button41.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox204_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Yellow;
            button40.BackColor = Color.Yellow;
            button41.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox208_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Turquoise;
            button40.BackColor = Color.Turquoise;
            button41.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox200_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.SkyBlue;
            button40.BackColor = Color.SkyBlue;
            button41.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox206_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Magenta;
            button40.BackColor = Color.Magenta;
            button41.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox210_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.MistyRose;
            button40.BackColor = Color.MistyRose;
            button41.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox205_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Lime;
            button40.BackColor = Color.Lime;
            button41.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox209_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Gold;
            button40.BackColor = Color.Gold;
            button41.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox203_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Thistle;
            button40.BackColor = Color.Thistle;
            button41.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox207_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.Aqua;
            button40.BackColor = Color.Aqua;
            button41.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox211_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.PeachPuff;
            button40.BackColor = Color.PeachPuff;
            button41.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox212_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.GreenYellow;
            button40.BackColor = Color.GreenYellow;
            button41.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox213_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.PaleGoldenrod;
            button40.BackColor = Color.PaleGoldenrod;
            button41.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", string.Empty);
            string palette12 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt", palette12);
        }

        private void pictureBox186_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.MediumSlateBlue;
            button37.BackColor = Color.MediumSlateBlue;
            button38.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox184_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Orange;
            button37.BackColor = Color.Orange;
            button38.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox187_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Violet;
            button37.BackColor = Color.Violet;
            button38.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox189_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Yellow;
            button37.BackColor = Color.Yellow;
            button38.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox193_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Turquoise;
            button37.BackColor = Color.Turquoise;
            button38.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox185_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.SkyBlue;
            button37.BackColor = Color.SkyBlue;
            button38.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox191_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Magenta;
            button37.BackColor = Color.Magenta;
            button38.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox195_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.MistyRose;
            button37.BackColor = Color.MistyRose;
            button38.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox190_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Lime;
            button37.BackColor = Color.Lime;
            button38.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox194_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Gold;
            button37.BackColor = Color.Gold;
            button38.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox188_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Thistle;
            button37.BackColor = Color.Thistle;
            button38.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox192_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.Aqua;
            button37.BackColor = Color.Aqua;
            button38.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox196_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.PeachPuff;
            button37.BackColor = Color.PeachPuff;
            button38.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox197_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.GreenYellow;
            button37.BackColor = Color.GreenYellow;
            button38.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox198_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.PaleGoldenrod;
            button37.BackColor = Color.PaleGoldenrod;
            button38.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", string.Empty);
            string palette13 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt", palette13);
        }

        private void pictureBox171_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.MediumSlateBlue;
            button34.BackColor = Color.MediumSlateBlue;
            button35.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox169_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Orange;
            button34.BackColor = Color.Orange;
            button35.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox172_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Violet;
            button34.BackColor = Color.Violet;
            button35.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox174_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Yellow;
            button34.BackColor = Color.Yellow;
            button35.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox178_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Turquoise;
            button34.BackColor = Color.Turquoise;
            button35.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox170_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.SkyBlue;
            button34.BackColor = Color.SkyBlue;
            button35.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox176_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Magenta;
            button34.BackColor = Color.Magenta;
            button35.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox180_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.MistyRose;
            button34.BackColor = Color.MistyRose;
            button35.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox175_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Lime;
            button34.BackColor = Color.Lime;
            button35.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox179_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Gold;
            button34.BackColor = Color.Gold;
            button35.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox173_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Thistle;
            button34.BackColor = Color.Thistle;
            button35.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox177_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.Aqua;
            button34.BackColor = Color.Aqua;
            button35.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox181_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.PeachPuff;
            button34.BackColor = Color.PeachPuff;
            button35.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox182_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.GreenYellow;
            button34.BackColor = Color.GreenYellow;
            button35.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox183_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.PaleGoldenrod;
            button34.BackColor = Color.PaleGoldenrod;
            button35.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", string.Empty);
            string palette14 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt", palette14);
        }

        private void pictureBox156_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.MediumSlateBlue;
            button31.BackColor = Color.MediumSlateBlue;
            button32.BackColor = Color.MediumSlateBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "MediumSlateBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox154_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Orange;
            button31.BackColor = Color.Orange;
            button32.BackColor = Color.Orange;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Orange";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox157_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Violet;
            button31.BackColor = Color.Violet;
            button32.BackColor = Color.Violet;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Violet";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox159_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Yellow;
            button31.BackColor = Color.Yellow;
            button32.BackColor = Color.Yellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Yellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox163_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Turquoise;
            button31.BackColor = Color.Turquoise;
            button32.BackColor = Color.Turquoise;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Turquoise";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox155_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.SkyBlue;
            button31.BackColor = Color.SkyBlue;
            button32.BackColor = Color.SkyBlue;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "SkyBlue";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox161_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Magenta;
            button31.BackColor = Color.Magenta;
            button32.BackColor = Color.Magenta;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Magenta";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox165_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.MistyRose;
            button31.BackColor = Color.MistyRose;
            button32.BackColor = Color.MistyRose;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "MistyRose";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox160_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Lime;
            button31.BackColor = Color.Lime;
            button32.BackColor = Color.Lime;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Lime";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox164_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Gold;
            button31.BackColor = Color.Gold;
            button32.BackColor = Color.Gold;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Gold";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox158_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Thistle;
            button31.BackColor = Color.Thistle;
            button32.BackColor = Color.Thistle;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Thistle";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox162_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.Aqua;
            button31.BackColor = Color.Aqua;
            button32.BackColor = Color.Aqua;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "Aqua";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox166_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.PeachPuff;
            button31.BackColor = Color.PeachPuff;
            button32.BackColor = Color.PeachPuff;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "PeachPuff";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox167_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.GreenYellow;
            button31.BackColor = Color.GreenYellow;
            button32.BackColor = Color.GreenYellow;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "GreenYellow";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

        private void pictureBox168_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.PaleGoldenrod;
            button31.BackColor = Color.PaleGoldenrod;
            button32.BackColor = Color.PaleGoldenrod;

            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", string.Empty);
            string palette15 = "PaleGoldenrod";
            System.IO.File.WriteAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt", palette15);
        }

       



    }
}
