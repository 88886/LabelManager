//This software is written by @stamen4o for GUI on Label Printer LP-50.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LP50Touch
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer _Timer = new System.Windows.Forms.Timer();
        void _Timer_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
        }


        public Form1()
        {
            InitializeComponent();
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var macAddr =
            (
                from nic in NetworkInterface.GetAllNetworkInterfaces()
                where nic.OperationalStatus == OperationalStatus.Up
                select nic.GetPhysicalAddress().ToString()
            ).FirstOrDefault();
            try
            {
                string userKey = System.IO.File.ReadAllText(@"C:\LP-50Touch\userKey.txt");
                string clientGen1 = macAddr.Substring(0, 6);
                string clientGen2 = macAddr.Substring(6);
                string genNew = clientGen2 + clientGen1;
                string genLast = genNew.Substring(1, 10);
                string genFinal = Reverse(genLast);
                string finalKey = genFinal + genFinal;
                if (userKey != finalKey)
                {
                    MessageBox.Show("Грешен ключ! Label Manager ID: " + macAddr);
                    Clipboard.SetText(macAddr);
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Проблем с базата!");
                this.Close();
            }


            _Timer.Interval = 1000;
            _Timer.Tick += new EventHandler(_Timer_Tick);
            _Timer.Start();

            label1.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\appleProduct.txt");
            label3.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherryProduct.txt");
            label4.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwiProduct.txt");
            label6.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonProduct.txt");
            label5.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearProduct.txt");
            label11.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberryProduct.txt");
            label10.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapeProduct.txt");
            label9.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachProduct.txt");
            label8.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananaProduct.txt");
            label7.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangeProduct.txt");
            label28.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberryProduct.txt");
            label15.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberryProduct.txt");
            label14.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrProduct.txt");
            label13.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotProduct.txt");
            label12.Text = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberryProduct.txt");


            //palette works:

            string boxColor1 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette1.txt");
            pictureBox13.BackColor = Color.FromName(boxColor1);
            label1.BackColor = Color.FromName(boxColor1);
            pictureBox1.BackColor = Color.FromName(boxColor1);

            string boxColor2 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette2.txt");
            pictureBox15.BackColor = Color.FromName(boxColor2);
            label3.BackColor = Color.FromName(boxColor2);
            pictureBox2.BackColor = Color.FromName(boxColor2);

            string boxColor3 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette3.txt");
            pictureBox17.BackColor = Color.FromName(boxColor3);
            label4.BackColor = Color.FromName(boxColor3);
            pictureBox3.BackColor = Color.FromName(boxColor3);

            string boxColor4 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette4.txt");
            pictureBox21.BackColor = Color.FromName(boxColor4);
            label6.BackColor = Color.FromName(boxColor4);
            pictureBox4.BackColor = Color.FromName(boxColor4);

            string boxColor5 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette5.txt");
            pictureBox19.BackColor = Color.FromName(boxColor5);
            label5.BackColor = Color.FromName(boxColor5);
            pictureBox5.BackColor = Color.FromName(boxColor5);

            string boxColor6 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette6.txt");
            pictureBox32.BackColor = Color.FromName(boxColor6);
            label11.BackColor = Color.FromName(boxColor6);
            pictureBox6.BackColor = Color.FromName(boxColor6);

            string boxColor7 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette7.txt");
            pictureBox30.BackColor = Color.FromName(boxColor7);
            label10.BackColor = Color.FromName(boxColor7);
            pictureBox7.BackColor = Color.FromName(boxColor7);

            string boxColor8 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette8.txt");
            pictureBox27.BackColor = Color.FromName(boxColor8);
            label9.BackColor = Color.FromName(boxColor8);
            pictureBox8.BackColor = Color.FromName(boxColor8);

            string boxColor9 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette9.txt");
            pictureBox25.BackColor = Color.FromName(boxColor9);
            label8.BackColor = Color.FromName(boxColor9);
            pictureBox9.BackColor = Color.FromName(boxColor9);

            string boxColor10 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette10.txt");
            pictureBox23.BackColor = Color.FromName(boxColor10);
            label7.BackColor = Color.FromName(boxColor10);
            pictureBox10.BackColor = Color.FromName(boxColor10);

            string boxColor11 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette11.txt");
            pictureBox42.BackColor = Color.FromName(boxColor11);
            label28.BackColor = Color.FromName(boxColor11);
            pictureBox18.BackColor = Color.FromName(boxColor11);

            string boxColor12 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette12.txt");
            pictureBox40.BackColor = Color.FromName(boxColor12);
            label15.BackColor = Color.FromName(boxColor12);
            pictureBox16.BackColor = Color.FromName(boxColor12);

            string boxColor13 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette13.txt");
            pictureBox38.BackColor = Color.FromName(boxColor13);
            label14.BackColor = Color.FromName(boxColor13);
            pictureBox14.BackColor = Color.FromName(boxColor13);

            string boxColor14 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette14.txt");
            pictureBox36.BackColor = Color.FromName(boxColor14);
            label13.BackColor = Color.FromName(boxColor14);
            pictureBox12.BackColor = Color.FromName(boxColor14);

            string boxColor15 = System.IO.File.ReadAllText(@"C:\LP-50Touch\UserInterface\Palette15.txt");
            pictureBox34.BackColor = Color.FromName(boxColor15);
            label12.BackColor = Color.FromName(boxColor15);
            pictureBox11.BackColor = Color.FromName(boxColor15);

            //product images:
            try
            {
                Bitmap image1 = (Bitmap) Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image1.gif",true);
                pictureBox1.Image = image1;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image2 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image2.gif", true);
                pictureBox2.Image = image2;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image3 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image3.gif", true);
                pictureBox3.Image = image3;
    
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image4 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image4.gif", true);
                pictureBox4.Image = image4;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image5 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image5.gif", true);
                pictureBox5.Image = image5;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image6 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image6.gif", true);
                pictureBox6.Image = image6;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image7 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image7.gif", true);
                pictureBox7.Image = image7;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image8 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image8.gif", true);
                pictureBox8.Image = image8;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image9 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image9.gif", true);
                pictureBox9.Image = image9;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image10 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image10.gif", true);
                pictureBox10.Image = image10;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image11 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image11.gif", true);
                pictureBox18.Image = image11;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image12 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image12.gif", true);
                pictureBox16.Image = image12;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image13 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image13.gif", true);
                pictureBox14.Image = image13;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image14 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image14.gif", true);
                pictureBox12.Image = image14;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }

            try
            {
                Bitmap image15 = (Bitmap)Image.FromFile(@"C:\LP-50Touch\UserInterface\Images\Image15.gif", true);
                pictureBox11.Image = image15;
            }
            catch (Exception)
            {

                MessageBox.Show("Снимките на артикулите не са заредени коректно.");
            }



        }


        //Initializing the counters for the Small, Middle and Large forms.
        int counterAppleS = 0;
        int counterAppleM = 0;
        int counterAppleL = 0;

        int counterCherryS = 0;
        int counterCherryM = 0;
        int counterCherryL = 0;

        int counterKiwiS = 0;
        int counterKiwiM = 0;
        int counterKiwiL = 0;

        int counterLemonS = 0;
        int counterLemonM = 0;
        int counterLemonL = 0;

        int counterPearS = 0;
        int counterPearM = 0;
        int counterPearL = 0;

        int counterOrangeS = 0;
        int counterOrangeM = 0;
        int counterOrangeL = 0;

        int counterBananaS = 0;
        int counterBananaM = 0;
        int counterBananaL = 0;

        int counterPeachS = 0;
        int counterPeachM = 0;
        int counterPeachL = 0;

        int counterGrapeS = 0;
        int counterGrapeM = 0;
        int counterGrapeL = 0;

        int counterBlackberryS = 0;
        int counterBlackberryM = 0;
        int counterBlackberryL = 0;

        int counterBlueberryS = 0;
        int counterBlueberryM = 0;
        int counterBlueberryL = 0;

        int counterApricotS = 0;
        int counterApricotM = 0;
        int counterApricotL = 0;

        int counterBlackcurrantS = 0;
        int counterBlackcurrantM = 0;
        int counterBlackcurrantL = 0;

        int counterStrawberryS = 0;
        int counterStrawberryM = 0;
        int counterStrawberryL = 0;

        int counterRaspberryS = 0;
        int counterRaspberryM = 0;
        int counterRaspberryL = 0;

        

        



        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort);
                port.Open();
                if (port.IsOpen)
                {
                    APPLES appleS = new APPLES();
                    string stringLoad = "FR\"APPLES\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string applesPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applesPrice.txt");
                    string applesBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applesBarcode.txt");
                    string applesName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applesName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(applesPrice);
                    port.WriteLine(applesBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(applesName);
                    port.WriteLine(stringSend);
                    counterAppleS++;
                    port.Close();
                    label16.Text = counterAppleS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort);
                port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"APPLEM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string applemPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applemPrice.txt");
                    string applemBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applemBarcode.txt");
                    string applemName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applemName.txt", Encoding.UTF8);
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(applemPrice);
                    port.WriteLine(applemBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(applemName);
                    port.WriteLine(stringSend);
                    counterAppleM++;
                    port.Close();
                    label17.Text = counterAppleM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort);
                port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"APPLEL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string applelPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applelPrice.txt");
                    string applelBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applelBarcode.txt");
                    string applelName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\applelName.txt", Encoding.UTF8);
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(applelPrice);
                    port.WriteLine(applelBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(applelName);
                    port.WriteLine(stringSend);
                    counterAppleL++;
                    port.Close();
                    label18.Text = counterAppleL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"CHERRYS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string cherrysPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrysPrice.txt");
                    string cherrysBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrysBarcode.txt");
                    string cherrysName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrysName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(cherrysPrice);
                    port.WriteLine(cherrysBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(cherrysName);
                    port.WriteLine(stringSend);
                    counterCherryS++;
                    port.Close();
                    label19.Text = counterCherryS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"CHERRYM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string cherrymPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrymPrice.txt");
                    string cherrymBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrymBarcode.txt");
                    string cherrymName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrymName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(cherrymPrice);
                    port.WriteLine(cherrymBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(cherrymName);
                    port.WriteLine(stringSend);
                    counterCherryM++;
                    port.Close();
                    label20.Text = counterCherryM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"CHERRYL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string cherrylPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrylPrice.txt");
                    string cherrylBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrylBarcode.txt");
                    string cherrylName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\cherrylName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(cherrylPrice);
                    port.WriteLine(cherrylBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(cherrylName);
                    port.WriteLine(stringSend);
                    counterCherryL++;
                    port.Close();
                    label21.Text = counterCherryL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"KIWIS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string kiwisPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwisPrice.txt");
                    string kiwisBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwisBarcode.txt");
                    string kiwisName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwisName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(kiwisPrice);
                    port.WriteLine(kiwisBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(kiwisName);
                    port.WriteLine(stringSend);
                    counterKiwiS++;
                    port.Close();
                    label23.Text = counterKiwiS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"KIWIM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string kiwimPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwimPrice.txt");
                    string kiwimBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwimBarcode.txt");
                    string kiwimName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwimName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(kiwimPrice);
                    port.WriteLine(kiwimBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(kiwimName);
                    port.WriteLine(stringSend);
                    counterKiwiM++;
                    port.Close();
                    label63.Text = counterKiwiM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"KIWIL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string kiwilPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwilPrice.txt");
                    string kiwilBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwilBarcode.txt");
                    string kiwilName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\kiwilName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(kiwilPrice);
                    port.WriteLine(kiwilBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(kiwilName);
                    port.WriteLine(stringSend);
                    counterKiwiL++;
                    port.Close();
                    label24.Text = counterKiwiL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"LEMONS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string lemonsPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonsPrice.txt");
                    string lemonsBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonsBarcode.txt");
                    string lemonsName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonsName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(lemonsPrice);
                    port.WriteLine(lemonsBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(lemonsName);
                    port.WriteLine(stringSend);
                    counterLemonS++;
                    port.Close();
                    label25.Text = counterLemonS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"LEMONM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string lemonmPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonmPrice.txt");
                    string lemonmBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonmBarcode.txt");
                    string lemonmName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonmName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(lemonmPrice);
                    port.WriteLine(lemonmBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(lemonmName);
                    port.WriteLine(stringSend);
                    counterLemonM++;
                    port.Close();
                    label26.Text = counterLemonM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"LEMONL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string lemonlPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonlPrice.txt");
                    string lemonlBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonlBarcode.txt");
                    string lemonlName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\lemonlName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(lemonlPrice);
                    port.WriteLine(lemonlBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(lemonlName);
                    port.WriteLine(stringSend);
                    counterLemonL++;
                    port.Close();
                    label27.Text = counterLemonL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEARS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string pearsPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearsPrice.txt");
                    string pearsBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearsBarcode.txt");
                    string pearsName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearsName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(pearsPrice);
                    port.WriteLine(pearsBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(pearsName);
                    port.WriteLine(stringSend);
                    counterPearS++;
                    port.Close();
                    label30.Text = counterPearS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEARM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string pearmPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearmPrice.txt");
                    string pearmBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearmBarcode.txt");
                    string pearmName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearmName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(pearmPrice);
                    port.WriteLine(pearmBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(pearmName);
                    port.WriteLine(stringSend);
                    counterPearM++;
                    port.Close();
                    label31.Text = counterPearM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEARL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string pearlPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearlPrice.txt");
                    string pearlBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearlBarcode.txt");
                    string pearlName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\pearlName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(pearlPrice);
                    port.WriteLine(pearlBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(pearlName);
                    port.WriteLine(stringSend);
                    counterPearL++;
                    port.Close();
                    label32.Text = counterPearL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"ORANGEL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string orangelPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangelPrice.txt");
                    string orangelBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangelBarcode.txt");
                    string orangelName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangelName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(orangelPrice);
                    port.WriteLine(orangelBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(orangelName);
                    port.WriteLine(stringSend);
                    counterOrangeL++;
                    port.Close();
                    label33.Text = counterOrangeL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"ORANGEM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string orangemPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangemPrice.txt");
                    string orangemBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangemBarcode.txt");
                    string orangemName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangemName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(orangemPrice);
                    port.WriteLine(orangemBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(orangemName);
                    port.WriteLine(stringSend);
                    counterOrangeM++;
                    port.Close();
                    label34.Text = counterOrangeM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"ORANGES\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string orangesPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangesPrice.txt");
                    string orangesBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangesBarcode.txt");
                    string orangesName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\orangesName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(orangesPrice);
                    port.WriteLine(orangesBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(orangesName);
                    port.WriteLine(stringSend);
                    counterOrangeS++;
                    port.Close();
                    label35.Text = counterOrangeS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BANANAL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bananalPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananalPrice.txt");
                    string bananalBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananalBarcode.txt");
                    string bananalName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananalName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bananalPrice);
                    port.WriteLine(bananalBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bananalName);
                    port.WriteLine(stringSend);
                    counterBananaL++;
                    port.Close();
                    label36.Text = counterBananaL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BANANAM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bananamPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananamPrice.txt");
                    string bananamBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananamBarcode.txt");
                    string bananamName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananamName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bananamPrice);
                    port.WriteLine(bananamBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bananamName);
                    port.WriteLine(stringSend);
                    counterBananaM++;
                    port.Close();
                    label37.Text = counterBananaM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BANANAS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bananasPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananasPrice.txt");
                    string bananasBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananasBarcode.txt");
                    string bananasName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bananasName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bananasPrice);
                    port.WriteLine(bananasBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bananasName);
                    port.WriteLine(stringSend);
                    counterBananaS++;
                    port.Close();
                    label38.Text = counterBananaS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEACHL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string peachlPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachlPrice.txt");
                    string peachlBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachlBarcode.txt");
                    string peachlName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachlName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(peachlPrice);
                    port.WriteLine(peachlBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(peachlName);
                    port.WriteLine(stringSend);
                    counterPeachL++;
                    port.Close();
                    label39.Text = counterPeachL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEACHM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string peachmPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachmPrice.txt");
                    string peachmBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachmBarcode.txt");
                    string peachmName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachmName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(peachmPrice);
                    port.WriteLine(peachmBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(peachmName);
                    port.WriteLine(stringSend);
                    counterPeachM++;
                    port.Close();
                    label40.Text = counterPeachM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"PEACHS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string peachsPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachsPrice.txt");
                    string peachsBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachsBarcode.txt");
                    string peachsName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\peachsName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(peachsPrice);
                    port.WriteLine(peachsBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(peachsName);
                    port.WriteLine(stringSend);
                    counterPeachS++;
                    port.Close();
                    label41.Text = counterPeachS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); 
                port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"GRAPEL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string grapelPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapelPrice.txt");
                    string grapelBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapelBarcode.txt");
                    string grapelName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapelName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(grapelPrice);
                    port.WriteLine(grapelBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(grapelName);
                    port.WriteLine(stringSend);
                    counterGrapeL++;
                    port.Close();
                    label42.Text = counterGrapeL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"GRAPEM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string grapemPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapemPrice.txt");
                    string grapemBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapemBarcode.txt");
                    string grapemName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapemName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(grapemPrice);
                    port.WriteLine(grapemBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(grapemName);
                    port.WriteLine(stringSend);
                    counterGrapeM++;
                    port.Close();
                    label43.Text = counterGrapeM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"GRAPES\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string grapesPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapesPrice.txt");
                    string grapesBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapesBarcode.txt");
                    string grapesName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\grapesName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(grapesPrice);
                    port.WriteLine(grapesBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(grapesName);
                    port.WriteLine(stringSend);
                    counterGrapeS++;
                    port.Close();
                    label44.Text = counterGrapeS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BBERRYL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bberrylPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrylPrice.txt");
                    string bberrylBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrylBarcode.txt");
                    string bberrylName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrylName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bberrylPrice);
                    port.WriteLine(bberrylBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bberrylName);
                    port.WriteLine(stringSend);
                    counterBlackberryL++;
                    port.Close();
                    label62.Text = counterBlackberryL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BBERRYM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bberrymPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrymPrice.txt");
                    string bberrymBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrymBarcode.txt");
                    string bberrymName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrymName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bberrymPrice);
                    port.WriteLine(bberrymBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bberrymName);
                    port.WriteLine(stringSend);
                    counterBlackberryM++;
                    port.Close();
                    label61.Text = counterBlackberryM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BBERRYS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bberrysPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrysPrice.txt");
                    string bberrysBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrysBarcode.txt");
                    string bberrysName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bberrysName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bberrysPrice);
                    port.WriteLine(bberrysBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bberrysName);
                    port.WriteLine(stringSend);
                    counterBlackberryS++;
                    port.Close();
                    label60.Text = counterBlackberryS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"RBERRYS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string rberrysPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrysPrice.txt");
                    string rberrysBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrysBarcode.txt");
                    string rberrysName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrysName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(rberrysPrice);
                    port.WriteLine(rberrysBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(rberrysName);
                    port.WriteLine(stringSend);
                    counterRaspberryS++;
                    port.Close();
                    label59.Text = counterRaspberryS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"RBERRYM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string rberrymPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrymPrice.txt");
                    string rberrymBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrymBarcode.txt");
                    string rberrymName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrymName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(rberrymPrice);
                    port.WriteLine(rberrymBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(rberrymName);
                    port.WriteLine(stringSend);
                    counterRaspberryM++;
                    port.Close();
                    label58.Text = counterRaspberryM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"RBERRYL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string rberrylPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrylPrice.txt");
                    string rberrylBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrylBarcode.txt");
                    string rberrylName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\rberrylName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(rberrylPrice);
                    port.WriteLine(rberrylBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(rberrylName);
                    port.WriteLine(stringSend);
                    counterRaspberryL++;
                    port.Close();
                    label57.Text = counterRaspberryL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"SBERRYS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string sberrysPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrysPrice.txt");
                    string sberrysBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrysBarcode.txt");
                    string sberrysName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrysName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(sberrysPrice);
                    port.WriteLine(sberrysBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(sberrysName);
                    port.WriteLine(stringSend);
                    counterStrawberryS++;
                    port.Close();
                    label47.Text = counterStrawberryS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"SBERRYM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string sberrymPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymPrice.txt");
                    string sberrymBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymBarcode.txt");
                    string sberrymName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrymName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(sberrymPrice);
                    port.WriteLine(sberrymBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(sberrymName);
                    port.WriteLine(stringSend);
                    counterStrawberryM++;
                    port.Close();
                    label45.Text = counterStrawberryM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"SBERRYL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string sberrylPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrylPrice.txt");
                    string sberrylBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrylBarcode.txt");
                    string sberrylName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\sberrylName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(sberrylPrice);
                    port.WriteLine(sberrylBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(sberrylName);
                    port.WriteLine(stringSend);
                    counterStrawberryL++;
                    port.Close();
                    label46.Text = counterStrawberryL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BCURRS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bcurrsPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrsPrice.txt");
                    string bcurrsBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrsBarcode.txt");
                    string bcurrsName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrsName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bcurrsPrice);
                    port.WriteLine(bcurrsBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bcurrsName);
                    port.WriteLine(stringSend);
                    counterBlackcurrantS++;
                    port.Close();
                    label48.Text = counterBlackcurrantS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BCURRM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bcurrmPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrmPrice.txt");
                    string bcurrmBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrmBarcode.txt");
                    string bcurrmName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrmName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bcurrmPrice);
                    port.WriteLine(bcurrmBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bcurrmName);
                    port.WriteLine(stringSend);
                    counterBlackcurrantM++;
                    port.Close();
                    label49.Text = counterBlackcurrantM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BCURRL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string bcurrlPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrlPrice.txt");
                    string bcurrlBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrlBarcode.txt");
                    string bcurrlName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\bcurrlName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(bcurrlPrice);
                    port.WriteLine(bcurrlBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(bcurrlName);
                    port.WriteLine(stringSend);
                    counterBlackcurrantL++;
                    port.Close();
                    label50.Text = counterBlackcurrantL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"APRICOTS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string apricotsPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotsPrice.txt");
                    string apricotsBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotsBarcode.txt");
                    string apricotsName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotsName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(apricotsPrice);
                    port.WriteLine(apricotsBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(apricotsName);
                    port.WriteLine(stringSend);
                    counterApricotS++;
                    port.Close();
                    label51.Text = counterApricotS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"APRICOTM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string apricotmPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotmPrice.txt");
                    string apricotmBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotmBarcode.txt");
                    string apricotmName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotmName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(apricotmPrice);
                    port.WriteLine(apricotmBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(apricotmName);
                    port.WriteLine(stringSend);
                    counterApricotM++;
                    port.Close();
                    label52.Text = counterApricotM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"APRICOTL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string apricotlPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotlPrice.txt");
                    string apricotlBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotlBarcode.txt");
                    string apricotlName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\apricotlName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(apricotlPrice);
                    port.WriteLine(apricotlBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(apricotlName);
                    port.WriteLine(stringSend);
                    counterApricotL++;
                    port.Close();
                    label53.Text = counterApricotL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BLBERRYS\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string blberrysPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrysPrice.txt");
                    string blberrysBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrysBarcode.txt");
                    string blberrysName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrysName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(blberrysPrice);
                    port.WriteLine(blberrysBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(blberrysName);
                    port.WriteLine(stringSend);
                    counterBlueberryS++;
                    port.Close();
                    label54.Text = counterBlueberryS.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BLBERRYM\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string blberrymPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrymPrice.txt");
                    string blberrymBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrymBarcode.txt");
                    string blberrymName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrymName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(blberrymPrice);
                    port.WriteLine(blberrymBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(blberrymName);
                    port.WriteLine(stringSend);
                    counterBlueberryM++;
                    port.Close();
                    label55.Text = counterBlueberryM.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try
            {
                string comPort = System.IO.File.ReadAllText(@"C:\LP-50Touch\comPort.txt");
                SerialPort port = new SerialPort("COM" + comPort); port.Open();
                if (port.IsOpen)
                {
                    string stringLoad = "FR\"BLBERRYL\"";
                    string stringSend = "P1,1";
                    string varLP = "?";
                    string blberrylPrice = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrylPrice.txt");
                    string blberrylBarcode = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrylBarcode.txt");
                    string blberrylName = System.IO.File.ReadAllText(@"C:\LP-50Touch\PriceList\blberrylName.txt");
                    string dateTimeLP = DateTime.Now.ToString("dd MMMM yyyy - HH:mm");
                    port.WriteLine(stringLoad);
                    port.WriteLine(varLP);
                    port.WriteLine(dateTimeLP);
                    port.WriteLine(blberrylPrice);
                    port.WriteLine(blberrylBarcode);
                    port.Encoding = System.Text.Encoding.GetEncoding(866);
                    port.WriteLine(blberrylName);
                    port.WriteLine(stringSend);
                    counterBlueberryL++;
                    port.Close();
                    label56.Text = counterBlueberryL.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Изберете COM !");
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminLogin menu = new AdminLogin();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();
        }


    }
}

