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

namespace GetSystemMetrics
{
    public partial class Form1 : Form
    {

        const int SM_ARRANGE= 56;
        const int SM_CLEANBOOT = 67;
        const int SM_CMONITORS = 80;
        const int SM_CMOUSEBUTTONS = 43;
        const int SM_CONVERTIBLESLATEMODE= 8195;
        const int SM_CXBORDER = 5;
        const int SM_CXCURSOR = 13;
        const int SM_CXDLGFRAME = 7;
        const int SM_CXDOUBLECLK = 36;
        const int SM_CXDRAG = 68;
        const int SM_CXEDGE = 45;
        const int SM_CXFIXEDFRAME = 7;
        const int SM_CXFOCUSBORDER = 83;
        const int SM_CXFRAME = 32;
        const int SM_CXFULLSCREEN = 16;
        const int SM_CXHSCROLL = 21;
        const int SM_CXHTHUMB = 10;
        const int SM_CXICON = 11;
        const int SM_CXICONSPACING = 38;
        const int SM_CXMAXIMIZED = 61;
        const int SM_CXMAXTRACK = 59;
        const int SM_CXMENUCHECK = 71;
        const int SM_CXMENUSIZE = 54;
        const int SM_CXMIN = 28;
        const int SM_CXMINIMIZED = 57;
        const int SM_CXMINSPACING = 47;
        const int SM_CXMINTRACK = 34;
        const int SM_CXPADDEDBORDER = 92;
        const int SM_CXSCREEN = 0;
        const int SM_CXSIZE = 30;
        const int SM_CXSIZEFRAME = 32;
        const int SM_CXSMICON = 49;
        const int SM_CXSMSIZE = 52;
        const int SM_CXVIRTUALSCREEN = 78;
        const int SM_CXVSCROLL = 2;
        const int SM_CYBORDER = 6;
        const int SM_CYCAPTION = 4;
        const int SM_CYCURSOR = 14;
        const int SM_CYDLGFRAME = 8;
        const int SM_CYDOUBLECLK = 37;
        const int SM_CYDRAG = 69;
        const int SM_CYEDGE = 46;
        const int SM_CYFIXEDFRAME = 8;
        const int SM_CYFOCUSBORDER = 84;
        const int SM_CYFRAME = 33;
        const int SM_CYFULLSCREEN = 17;
        const int SM_CYHSCROLL = 3;
        const int SM_CYICON = 12;
        const int SM_CYICONSPACING = 39;
        const int SM_CYKANJIWINDOW = 18;
        const int SM_CYMAXIMIZED = 62;
        const int SM_CYMAXTRACK = 60;
        const int SM_CYMENU = 15;
        const int SM_CYMENUCHECK = 72;
        const int SM_CYMENUSIZE = 55;
        const int SM_CYMIN = 29;
        const int SM_CYMINIMIZED = 58;
        const int SM_CYMINSPACING = 48;
        const int SM_CYMINTRACK = 35;
        const int SM_CYSCREEN = 1;
        const int SM_CYSIZE = 31;
        const int SM_CYSIZEFRAME = 33;
        const int SM_CYSMCAPTION = 51;
        const int SM_CYSMICON = 50;
        const int SM_CYSMSIZE = 53;
        const int SM_CYVIRTUALSCREEN = 79;
        const int SM_CYVSCROLL = 20;
        const int SM_CYVTHUMB = 9;
        const int SM_DBCSENABLED = 42;
        const int SM_DEBUG = 22;
        const int SM_DIGITIZER = 94;
        const int SM_IMMENABLED = 82;
        const int SM_MAXIMUMTOUCHES = 95;
        const int SM_MEDIACENTER = 87;
        const int SM_MENUDROPALIGNMENT = 40;
        const int SM_MIDEASTENABLED = 74;
        const int SM_MOUSEPRESENT = 19;
        const int SM_MOUSEHORIZONTALWHEELPRESENT = 91;
        const int SM_MOUSEWHEELPRESENT = 75;
        const int SM_NETWORK = 63;
        const int SM_PENWINDOWS = 41;
        const int SM_REMOTECONTROL = 8193;
        const int SM_REMOTESESSION = 4096;
        const int SM_SAMEDISPLAYFORMAT = 81;
        const int SM_SECURE = 44;
        const int SM_SERVERR2 = 89;
        const int SM_SHOWSOUNDS = 70;
        const int SM_SHUTTINGDOWN = 8192;
        const int SM_SLOWMACHINE = 73;
        const int SM_STARTER = 88;
        const int SM_SWAPBUTTON = 23;
        const int SM_SYSTEMDOCKED = 8196;
        const int SM_TABLETPC = 86;
        const int SM_XVIRTUALSCREEN = 76;
        const int SM_YVIRTUALSCREEN = 77;

        [DllImport("User32.dll")]
        public extern static int GetSystemMetrics(int nIndex);

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            LblV1.Text = Convert.ToString(GetSystemMetrics(SM_ARRANGE));
            LblV2.Text = Convert.ToString(GetSystemMetrics(SM_CLEANBOOT));
            LblV3.Text = Convert.ToString(GetSystemMetrics(SM_CMONITORS));
            LblV4.Text = Convert.ToString(GetSystemMetrics(SM_CMOUSEBUTTONS));
            LblV5.Text = Convert.ToString(GetSystemMetrics(SM_CONVERTIBLESLATEMODE));
            LblV6.Text = Convert.ToString(GetSystemMetrics(SM_CXBORDER));
            LblV7.Text = Convert.ToString(GetSystemMetrics(SM_CXCURSOR));
            LblV8.Text = Convert.ToString(GetSystemMetrics(SM_CXDLGFRAME));
            LblV9.Text = Convert.ToString(GetSystemMetrics(SM_CXDOUBLECLK));
            LblV10.Text = Convert.ToString(GetSystemMetrics(SM_CXDRAG));
            LblV11.Text = Convert.ToString(GetSystemMetrics(SM_CXEDGE));
            LblV12.Text = Convert.ToString(GetSystemMetrics(SM_CXFIXEDFRAME));
            LblV13.Text = Convert.ToString(GetSystemMetrics(SM_CXFOCUSBORDER));
            LblV14.Text = Convert.ToString(GetSystemMetrics(SM_CXFRAME));
            LblV15.Text = Convert.ToString(GetSystemMetrics(SM_CXFULLSCREEN));
            LblV16.Text = Convert.ToString(GetSystemMetrics(SM_CXHSCROLL));
            LblV17.Text = Convert.ToString(GetSystemMetrics(SM_CXHTHUMB));
            LblV18.Text = Convert.ToString(GetSystemMetrics(SM_CXICON));
            LblV19.Text = Convert.ToString(GetSystemMetrics(SM_CXICONSPACING));
            LblV20.Text = Convert.ToString(GetSystemMetrics(SM_CXMAXIMIZED));
            LblV21.Text = Convert.ToString(GetSystemMetrics(SM_CXMAXTRACK));
            LblV22.Text = Convert.ToString(GetSystemMetrics(SM_CXMENUCHECK));
            LblV23.Text = Convert.ToString(GetSystemMetrics(SM_CXMENUSIZE));
            LblV24.Text = Convert.ToString(GetSystemMetrics(SM_CXMIN));
            LblV25.Text = Convert.ToString(GetSystemMetrics(SM_CXMINIMIZED));
            LblV26.Text = Convert.ToString(GetSystemMetrics(SM_CXMINSPACING));
            LblV27.Text = Convert.ToString(GetSystemMetrics(SM_CXMINTRACK));
            LblV28.Text = Convert.ToString(GetSystemMetrics(SM_CXPADDEDBORDER));
            LblV29.Text = Convert.ToString(GetSystemMetrics(SM_CXSCREEN));
            LblV30.Text = Convert.ToString(GetSystemMetrics(SM_CXSIZE));
            LblV31.Text = Convert.ToString(GetSystemMetrics(SM_CXSIZEFRAME));
            LblV32.Text = Convert.ToString(GetSystemMetrics(SM_CXSMICON));
            LblV33.Text = Convert.ToString(GetSystemMetrics(SM_CXSMSIZE));
            LblV34.Text = Convert.ToString(GetSystemMetrics(SM_CXVIRTUALSCREEN));
            LblV35.Text = Convert.ToString(GetSystemMetrics(SM_CXVSCROLL));
            LblV36.Text = Convert.ToString(GetSystemMetrics(SM_CYBORDER));
            LblV37.Text = Convert.ToString(GetSystemMetrics(SM_CYCAPTION));
            LblV38.Text = Convert.ToString(GetSystemMetrics(SM_CYCURSOR));
            LblV39.Text = Convert.ToString(GetSystemMetrics(SM_CYDLGFRAME));
            LblV40.Text = Convert.ToString(GetSystemMetrics(SM_CYDOUBLECLK));
            LblV41.Text = Convert.ToString(GetSystemMetrics(SM_CYDRAG));
            LblV42.Text = Convert.ToString(GetSystemMetrics(SM_CYEDGE));
            LblV43.Text = Convert.ToString(GetSystemMetrics(SM_CYFIXEDFRAME));
            LblV44.Text = Convert.ToString(GetSystemMetrics(SM_CYFOCUSBORDER));
            LblV45.Text = Convert.ToString(GetSystemMetrics(SM_CYFRAME));
            LblV46.Text = Convert.ToString(GetSystemMetrics(SM_CYFULLSCREEN));
            LblV47.Text = Convert.ToString(GetSystemMetrics(SM_CYHSCROLL));
            LblV48.Text = Convert.ToString(GetSystemMetrics(SM_CYICON));
            LblV49.Text = Convert.ToString(GetSystemMetrics(SM_CYICONSPACING));
            LblV50.Text = Convert.ToString(GetSystemMetrics(SM_CYKANJIWINDOW));
            LblV51.Text = Convert.ToString(GetSystemMetrics(SM_CYMAXIMIZED));
            LblV52.Text = Convert.ToString(GetSystemMetrics(SM_CYMAXTRACK));
            LblV53.Text = Convert.ToString(GetSystemMetrics(SM_CYMENU));
            LblV54.Text = Convert.ToString(GetSystemMetrics(SM_CYMENUCHECK));
            LblV55.Text = Convert.ToString(GetSystemMetrics(SM_CYMENUSIZE));
            LblV56.Text = Convert.ToString(GetSystemMetrics(SM_CYMIN));
            LblV57.Text = Convert.ToString(GetSystemMetrics(SM_CYMINIMIZED));
            LblV58.Text = Convert.ToString(GetSystemMetrics(SM_CYMINSPACING));
            LblV59.Text = Convert.ToString(GetSystemMetrics(SM_CYMINTRACK));
            LblV60.Text = Convert.ToString(GetSystemMetrics(SM_CYSCREEN));
            LblV61.Text = Convert.ToString(GetSystemMetrics(SM_CYSIZE));
            LblV62.Text = Convert.ToString(GetSystemMetrics(SM_CYSIZEFRAME));
            LblV63.Text = Convert.ToString(GetSystemMetrics(SM_CYSMCAPTION));
            LblV64.Text = Convert.ToString(GetSystemMetrics(SM_CYSMICON));
            LblV65.Text = Convert.ToString(GetSystemMetrics(SM_CYSMSIZE));
            LblV66.Text = Convert.ToString(GetSystemMetrics(SM_CYVIRTUALSCREEN));
            LblV67.Text = Convert.ToString(GetSystemMetrics(SM_CYVSCROLL));
            LblV68.Text = Convert.ToString(GetSystemMetrics(SM_CYVTHUMB));
            LblV69.Text = Convert.ToString(GetSystemMetrics(SM_DBCSENABLED));
            LblV70.Text = Convert.ToString(GetSystemMetrics(SM_DEBUG));
            LblV71.Text = Convert.ToString(GetSystemMetrics(SM_DIGITIZER));
            LblV72.Text = Convert.ToString(GetSystemMetrics(SM_IMMENABLED));
            LblV73.Text = Convert.ToString(GetSystemMetrics(SM_MAXIMUMTOUCHES));
            LblV74.Text = Convert.ToString(GetSystemMetrics(SM_MEDIACENTER));
            LblV75.Text = Convert.ToString(GetSystemMetrics(SM_MENUDROPALIGNMENT));
            LblV76.Text = Convert.ToString(GetSystemMetrics(SM_MIDEASTENABLED));
            LblV77.Text = Convert.ToString(GetSystemMetrics(SM_MOUSEPRESENT));
            LblV78.Text = Convert.ToString(GetSystemMetrics(SM_MOUSEHORIZONTALWHEELPRESENT));
            LblV79.Text = Convert.ToString(GetSystemMetrics(SM_MOUSEWHEELPRESENT));
            LblV80.Text = Convert.ToString(GetSystemMetrics(SM_NETWORK));
            LblV81.Text = Convert.ToString(GetSystemMetrics(SM_PENWINDOWS));
            LblV82.Text = Convert.ToString(GetSystemMetrics(SM_REMOTECONTROL));
            LblV83.Text = Convert.ToString(GetSystemMetrics(SM_REMOTESESSION));
            LblV84.Text = Convert.ToString(GetSystemMetrics(SM_SAMEDISPLAYFORMAT));
            LblV85.Text = Convert.ToString(GetSystemMetrics(SM_SECURE));
            LblV86.Text = Convert.ToString(GetSystemMetrics(SM_SERVERR2));
            LblV87.Text = Convert.ToString(GetSystemMetrics(SM_SHOWSOUNDS));
            LblV88.Text = Convert.ToString(GetSystemMetrics(SM_SHUTTINGDOWN));
            LblV89.Text = Convert.ToString(GetSystemMetrics(SM_SLOWMACHINE));
            LblV90.Text = Convert.ToString(GetSystemMetrics(SM_STARTER));
            LblV91.Text = Convert.ToString(GetSystemMetrics(SM_SWAPBUTTON));
            LblV92.Text = Convert.ToString(GetSystemMetrics(SM_SYSTEMDOCKED));
            LblV93.Text = Convert.ToString(GetSystemMetrics(SM_TABLETPC));
            LblV94.Text = Convert.ToString(GetSystemMetrics(SM_XVIRTUALSCREEN));
            LblV95.Text = Convert.ToString(GetSystemMetrics(SM_YVIRTUALSCREEN));
        }
    }
}