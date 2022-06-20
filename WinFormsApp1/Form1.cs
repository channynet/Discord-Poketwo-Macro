using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        string strState = "IDLE";
        int ind = 0;
        int Times = 0;
        bool KeepMacro = true;
        char[] CatchPoketmon=new char[10000];
        string[] Pokemon = new string[100];
        string[] catchedLegendaryPoketmon = new string[100];
        string capturedScreenString;
        int totalCatchPokemon;
        int totalLegnedaryPokemon;
        /// <summary>
        /// Struct representing a point.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }

        [DllImport("user32.dll")]
        static extern bool ScreenToClient(IntPtr hWnd, ref POINT lpPoint);

        /// <summary>
        /// Retrieves the cursor's position, in screen coordinates.
        /// </summary>
        /// <see>See MSDN documentation for further information.</see>
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        public void GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);
            //ScreenToClient(process.MainWindowHandle, ref lpPoint);
            //Console.WriteLine("X : " + lpPoint.X);
            //Console.WriteLine("Y : " + lpPoint.Y);
            textBox5.Text = "   X : " + lpPoint.X + "   " + "Y : " + lpPoint.Y;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool GetCursorPos(ref Point lpPoint);
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetCursorPos(int x, int y);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        //Private rand As New Random();
        //string[] Pokemon;
        
        //int Rand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                timerInvoke.Enabled = true;                   
            } else
            {
                timerInvoke.Enabled = false;
            }
            if (Int32.TryParse(textBox2.Text, out int numValue))
            {
                timerInvoke.Interval = numValue;
            }
        }

        private void timerInvoke_Tick(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox3.Text, out int numValue))
            {
                timerInvoke.Interval = numValue;
            }

            //Random length = new Random();
            //Random rand = new Random();
            //Random randomPokemon = new Random();
            //rand.Next(97, 122);

            Pokemon[0] = "Articuno";
            Pokemon[1] = "Zapdos";
            Pokemon[2] = "Moltres";
            Pokemon[3] = "Mewtwo";
            Pokemon[4] = "Raikou";
            Pokemon[5] = "Entei";
            Pokemon[6] = "Suicune";
            Pokemon[7] = "Lugia";
            Pokemon[8] = "Ho-oh";
            Pokemon[9] = "Regirock";
            Pokemon[10] = "Regice";
            Pokemon[11] = "Registeel";
            Pokemon[12] = "Latias";
            Pokemon[13] = "Latios";
            Pokemon[14] = "Kyogre";
            Pokemon[15] = "Groudon";
            Pokemon[16] = "Rayquaza";
            Pokemon[17] = "Uxie";
            Pokemon[18] = "Mesprit";
            Pokemon[19] = "Azeif";
            Pokemon[20] = "Dialga";
            Pokemon[21] = "Palkia";
            Pokemon[22] = "Heatran";
            Pokemon[23] = "Regigigas";
            Pokemon[24] = "Giratina";
            Pokemon[25] = "Cresselia";
            Pokemon[26] = "Cobalion";
            Pokemon[27] = "Terrakion";
            Pokemon[28] = "Virizion";
            Pokemon[29] = "Tornados";
            Pokemon[30] = "Thundurus"; 
            Pokemon[31] = "Rashiram";
            Pokemon[32] = "Zekrom";
            Pokemon[33] = "Landorus";
            Pokemon[34] = "Kyurem";
            Pokemon[35] = "Xerneas";
            Pokemon[36] = "Yvetal";
            Pokemon[37] = "Zygarde";
            Pokemon[38] = "Silvally";
            Pokemon[39] = "Tapu Ko Ko";
            Pokemon[40] = "Tapu Le Le";
            Pokemon[41] = "Tapu Bu Lu";
            Pokemon[42] = "Tapu Fi Ni";
            Pokemon[43] = "Cosmog";
            Pokemon[44] = "Cosmoem"; 
            Pokemon[45] = "Solgaleo";
            Pokemon[46] = "Lunala";
            Pokemon[47] = "Nihilego";
            Pokemon[48] = "Buzzwole";
            Pokemon[49] = "Pheromosa";
            Pokemon[50] = "Xurkitree";
            Pokemon[51] = "Celesteela";
            Pokemon[52] = "Kartana"; 
            Pokemon[53] = "Guzzlord";
            Pokemon[54] = "Necrozma";
            Pokemon[55] = "Poipole";
            Pokemon[56] = "Naganadel";
            Pokemon[57] = "Stakataka";
            Pokemon[58] = "Blacephalon";
            Pokemon[59] = "Zacian";
            Pokemon[60] = "Zamazenta";
            Pokemon[61] = "Eternatus";
            Pokemon[62] = "Glastrier";
            Pokemon[63] = "Spectrier";
            Pokemon[64] = "Kubfu";
            Pokemon[65] = "Urshifu";
            Pokemon[66] = "Regieleki";
            Pokemon[67] = "Regidrago";
            Pokemon[68] = "Mew";
            Pokemon[69] = "Celebi";
            Pokemon[70] = "Jirachi";
            Pokemon[71] = "Deoxys";
            Pokemon[72] = "Phione";
            Pokemon[73] = "Manaphy";
            Pokemon[74] = "Darkrai";
            Pokemon[75] = "Shaymin";
            Pokemon[76] = "Arceus";
            Pokemon[77] = "Victini";
            Pokemon[78] = "Keldeo";
            Pokemon[79] = "Meloetta";
            Pokemon[80] = "Genosect";
            Pokemon[81] = "Hoopa";
            Pokemon[82] = "Volcanion";
            Pokemon[83] = "Magearna";
            Pokemon[84] = "Marshadow";
            Pokemon[85] = "Zeraora";
            Pokemon[86] = "Meltan";
            Pokemon[87] = "Melmeta";
            Pokemon[88] = "Zarude";


            //for (int i = 0; i < rand.Next(0, 20); i++)
            /* {
                 int randompoke = randomPokemon.Next(0, 20);
                 if (randompoke<6)
                 {
                     SendKeys.Send(".catch " + Pokemon[randompoke] + "{enter}");
                 }else if (randompoke < 16)
                 {

                 }
                 else
                 {
                     //char c = Convert.ToChar(2);
                     // char.Parse(rand.Next(97, 122))
                     // SendKeys.Send(".catch ");
                     SendKeys.Send(".catch ");
                     for (int j = 0; j < length.Next(5, 12); j++)
                         {
                             SendKeys.Send(Convert.ToChar(rand.Next(97, 122)).ToString());

                        // SendKeys.Send();
                      }
                     SendKeys.Send("{enter}");
                 }

            // }
             */

            textBox7.Text = "catched pokemon : " + totalCatchPokemon;
            textBox8.Text = "catched legendary pokemon : " + totalLegnedaryPokemon;

            // STATE MACHINE
            if (strState == "IDLE")
            {

                while (true)
                {
                    
                    if (ind >= textBox4.TextLength)
                    {
                        Times++;
                        ind = 0;
                        SendKeys.Send(Times.ToString());
                    }
                    //If it is not enter
                    if (textBox4.Text[ind] != 32)
                    {
                        try
                        {
                            String strTemp = textBox4.Text[ind].ToString();
                            SendKeys.Send(strTemp);
                        }
                        catch (Exception exStringError)
                        {
                            Console.WriteLine("{0} Exception caught.", exStringError);
                        }
                    }
                    //If it is enter
                    else
                    {

                        SendKeys.Send("{enter}");
                        ind++;
                        MouseOperations.PerformDoubleClick(378, 1009);
                        Thread.Sleep(250);
                        MouseOperations.PerformCopy();
                        Thread.Sleep(1000);
                        MouseOperations.PerformClick(1870, 857);
                        capturedScreenString = Clipboard.GetText();
                        
                        textBox6.Text = capturedScreenString;
                        Array.Clear(CatchPoketmon, 0, CatchPoketmon.Length);
                        break;
                    }
                    ind++;

                }
                //If poketmon has spawned
                if (capturedScreenString.Length > 10)
                {
                    if (capturedScreenString.IndexOf("pokémon has appeared!") > 0) { strState = "HINT";  }
                }
            } 
            else if (strState == "HINT")
            {
                string pokemonCatch = "";
                string pokemonCatchCapture;
                Thread.Sleep(5000);
                SendKeys.Send(".hint{enter}");
                Thread.Sleep(5000);
                pokemonCatchCapture = MouseOperations.Capture(2000, 1296, 382, 1296);
                if (pokemonCatchCapture.IndexOf("https://verify.poketwo.net") > 0)
                {
                    strState = "FINDISBOT";
                }
                else
                {
                    if (pokemonCatchCapture.IndexOf("The pokémon is") >= 0 && pokemonCatchCapture.Length > 15)
                    {
                        pokemonCatch = pokemonCatchCapture.Substring(14, pokemonCatchCapture.Length - 15);
                        for (int i = 0; i < pokemonCatch.Length; i++)
                        {
                            if (pokemonCatch[i] != '_')
                            {
                                CatchPoketmon[i] = pokemonCatch[i];
                            }
                        }

                        textBox6.Text = new string(CatchPoketmon);
                        if (textBox6.Text.Length == pokemonCatch.Length)
                        {
                            strState = "CATCH";
                        }
                    }
                }
            }
            else if (strState == "CATCH")
            {
                SendKeys.Send(".catch" + " " + textBox6.Text + "{enter}");
                totalCatchPokemon++;
                for (int i = 0; i < 89; i++)
                {
                    if (textBox6.Text.IndexOf(Pokemon[i]) >= 0)
                    {
                        totalLegnedaryPokemon++;
                        Thread.Sleep(1000);
                        SendKeys.Send(".favorite latest{enter}");
                    }
                }
                strState = "IDLE";
            }
            else if (strState == "FINDISBOT")
            {
                check_Bot();
                strState = "IDLE";
            }
            textBox9.Text = strState;
            
            /*   


               //933 577
               if (KeepMacro)
               {
                   while (true)
                   {
                       if (ind >= textBox4.TextLength)
                       {
                           Times++;
                           ind = 0;
                           SendKeys.Send(Times.ToString());
                       }

                       if (textBox4.Text[ind] != 32)
                       {
                           try
                           {
                               String strTemp = textBox4.Text[ind].ToString();
                               SendKeys.Send(strTemp);
                           }
                           catch (Exception exStringError)
                           {
                               Console.WriteLine("{0} Exception caught.", exStringError);
                           }
                       }
                       else
                       {

                           SendKeys.Send("{enter}");
                           ind++;
                           //textBox6.Text = MouseOperations.Capture(368, 1312, 821, 944);
                           //MouseOperations.PerformDoubleClick(340,1009);
                           MouseOperations.PerformDoubleClick(378, 1009);
                           Thread.Sleep(250);
                           MouseOperations.PerformCopy();
                           Thread.Sleep(1000);
                           MouseOperations.PerformClick(1870, 857);
                           //textBox6.Text = Clipboard.GetText();
                           capturedScreenString = Clipboard.GetText();
                           textBox6.Text = capturedScreenString;
                           //CatchPoketmon = {''};
                           Array.Clear(CatchPoketmon, 0 , CatchPoketmon.Length);
                           break;
                       }
                       ind++;

                   }
                   if (capturedScreenString.Length > 10)
                   {
                       /*
                       if (textBox6.Text[0] == 'W' && textBox6.Text[1] == 'i' && textBox6.Text[2] == 'l' && textBox6.Text[3] == 'd')
                       {
                           KeepMacro = false;
                       }
                       */
            /*
            if (capturedScreenString.IndexOf("pokémon has appeared!") > 0) 
            {
                KeepMacro = false;
            }


        }

    }
    if (!KeepMacro)
    {
        //string[] pokemonCatch = new string[100];
        string pokemonCatch = "";
        string pokemonCatchCapture;
        Thread.Sleep(5000);
        SendKeys.Send(".hint{enter}");
        Thread.Sleep(5000);
        //pokemonCatchCapture = MouseOperations.Capture(1257, 1288, 375, 1301);
        pokemonCatchCapture = MouseOperations.Capture(2000, 1296, 382, 1296);

        /*
        for(int i = 14; i < pokemonCatchCapture.Length - 1; i++)
        {
            pokemonCatch[i] = pokemonCatchCapture[i];
        }
        */
            /*
        if (pokemonCatchCapture.IndexOf("https://verify.poketwo.net") > 0)
        {
            check_Bot(); 
            KeepMacro = true;
        }
        else
        {
            pokemonCatch = pokemonCatchCapture.Substring(14, pokemonCatchCapture.Length - 15);
            //textBox6.Tex;
            for (int i = 0; i < pokemonCatch.Length; i++)
            {
                if (pokemonCatch[i] != '_')
                {
                    CatchPoketmon[i] = pokemonCatch[i];
                }
                // e.lse if(Cat)
                // {
                //     CatchPoketmon[i] = ' ';
                // }
            }

            textBox6.Text = new string(CatchPoketmon);
            if (textBox6.Text.Length == pokemonCatch.Length)
            {
                SendKeys.Send(".catch" + " " + textBox6.Text + "{enter}");
                totalCatchPokemon++;
                for (int i = 0; i < 89; i++)
                {
                    if (Pokemon[i] == textBox6.Text)
                    {
                        totalLegnedaryPokemon++;
                        Thread.Sleep(1000);
                        SendKeys.Send(".favorite latest{enter}");
                    }
                }
                KeepMacro = true;
            }
        }

    }
    */

            //Randomi일반화한다.

            /*if (Random == 1)
            {
                SendKeys.Send(".catch groudon{enter}");
                
            }
            if (Random == 2)
            {
                SendKeys.Send(".catch Rayquaza{enter}");
                
            }
            if (Random == 3)
            {
                SendKeys.Send(".catch Mewto{enter}");
                
            }
            if (Random == 4)
            {
                SendKeys.Send(".catch Kyogre{enter}");
                
            }
            if (Random == 5)
            {
                SendKeys.Send(".catch Palkia{enter}");
                
            }
            if (Random == 6)
            {
                SendKeys.Send(".catch Giratina{enter}");
                Random = 0;
            }*/

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /********************************************
            //SetCursorPos(Convert.ToInt32() , Convert.ToInt32());
            SetCursorPos(397, 1300);
            mouse_event(MOUSEEVENTF_LEFTDOWN , 0, 0, 0, 0);
            System.Threading.Thread.Sleep(100);
            SetCursorPos(397, 970);
            mouse_event(MOUSEEVENTF_LEFTUP,0, 0, 0, 0);
            

            
            MouseOperations.PerformDrag(397, 1300);
            MouseOperations.SmoothMove(397, 1300, 395, 993);
           // mouse_event(0x8000 | MOUSEEVENTF_LEFTUP, 395, 993, 0, UIntPtr.Zero);
            MouseOperations.PerformDrop(395, 993);
            MouseOperations.PerformCopy();
            textBox4.Text = Clipboard.GetText();
            ********************************************/
            // Clipboard.SetDataObject("sdf");
           // Clipboard.SetText("Hello");
           // textBox6.Text = MouseOperations.Capture(800, 1035,390,980);
        }

        private void check_Bot()
        {
            MouseOperations.PerformClick(705, 1288);
            System.Threading.Thread.Sleep(3000);
            MouseOperations.PerformClick(1145, 748);
            System.Threading.Thread.Sleep(3000);
            MouseOperations.PerformClick(1148, 834);
            System.Threading.Thread.Sleep(3000);
            MouseOperations.PerformClick(2437, 13);
            System.Threading.Thread.Sleep(3000);
            /*SetCursorPos(1022, 1321);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(100);
            SetCursorPos(1148, 752);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(100);
            SetCursorPos(1144, 827);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(100);
            SetCursorPos(2544, 17);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);*/

        }

       /* private void reset_catch_pokemon(Char ResetChar, int length)
        {
            for(int i = 0; i < length; i++)
            {
                
            }
        }*/

        private void timerLoc_Tick(object sender, EventArgs e)
        {
            GetCursorPosition();
            //Console.WriteLine("TEST MSG");
        }

        private void timerCheckFast_Tick(object sender, EventArgs e)
        {
            if (strState == "IDLE")
            {
                MouseOperations.PerformClick(933, 577);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }


    public class MouseOperations
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, UIntPtr dwExtraInfo);

        private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const uint MOUSEEVENTF_LEFTUP = 0x0004;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        private const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        private const uint MOUSEEVENTF_MOVE = 0x0001;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern bool SetCursorPos(uint x, uint y);

        public static void PerformClick(uint x, uint y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
        }

        public static void PerformRightClick(uint x, uint y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTDOWN, x, y, 0, UIntPtr.Zero);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_RIGHTUP, x, y, 0, UIntPtr.Zero);
        }

        public static void PerformDoubleClick(uint x, uint y)
        {
            PerformClick(x, y);
            Thread.Sleep(250);
            PerformClick(x, y);
            //SendKeys.Send("^c");
        }

        public static void PerformDrag(uint x, uint y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
            Thread.Sleep(1000);
        }


        public static void PerformDrop(uint x, uint y)
        {
            //Thread.Sleep(250);
            //mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, UIntPtr.Zero);
            //SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
            //Thread.Sleep(10);
            
        }
        public static void PerformCopy()
        {
            SendKeys.Send("^c");
        }

        public static String Capture(uint startX, uint startY, uint endX, uint endY)
        {
           // MouseOperations.PerformClick(131, 1376);
            //Clipboard.SetText("This text is when you didn't capture anything");
            //Clipboard.Clear();
            MouseOperations.PerformDrag(startX, startY);
           // MouseOperations.PerformDrop(endX, endY);

           // MouseOperations.PerformDrag(startX, startY);
            MouseOperations.SmoothMove(startX, startY, endX, endY);
            // mouse_event(0x8000 | MOUSEEVENTF_LEFTUP, 395, 993, 0, UIntPtr.Zero);
            //Thread.Sleep(10);
            
            //Thread.Sleep(10);
            MouseOperations.PerformDrop(endX, endY);
            MouseOperations.PerformCopy();

           
            // MouseOperations.PerformCopy();
           // Clipboard.Clear();
            return Clipboard.GetText();
        }
        public static void SmoothMove(uint startX, uint startY, uint endX, uint endY)
        {
            Thread.Sleep(10);
            SetCursorPos(endX, endY);
            Thread.Sleep(10);

            /*
            uint curX = startX;
            uint curY = startY;
            while (true)
            {
                if (curX < endX)
                {
                    curX++;
                }
                if (curX > endX)
                {
                    curX--;
                }
                if (curY < endY)
                {
                    curY++;
                }
                if (curY > endY)
                {
                    curY--;
                }

                Thread.Sleep(1);
    
    SetCursorPos(curX, curY);
                if (curX == endX&&curY==endY)
                {
                    break;
                }
            }
            */
            //Thread.Sleep(1);
            //SetCursorPos(x, y);
            
        }
    }


}