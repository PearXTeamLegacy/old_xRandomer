using PearXLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using xRandomer.Properties;

namespace xRandomer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.icon;
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            buttonGenerate.Enabled = false;
            string str = textFormat.Text;
            while(str.Contains("%char%"))
            {
                str = PXL.ReplaceFirst(str, "%char%", PXL.GenChar().ToString());
            }
            while(str.Contains("%CHAR%"))
            {
                str = PXL.ReplaceFirst(str, "%CHAR%", PXL.GenChar().ToString().ToUpper());
            }
            while(str.Contains("%num%"))
            {
                str = PXL.ReplaceFirst(str, "%num%", PXL.GenNumber().ToString());
            }
            while(str.Contains("%rand%"))
            {
                str = PXL.ReplaceFirst(str, "%rand%", PXL.GenRandom(true).ToString());
            }
            while(str.Contains("%randws%"))
            {
                str = PXL.ReplaceFirst(str, "%randws%", PXL.GenRandom(false).ToString());
            }
            while(str.Contains("%sym%"))
            {
                str = PXL.ReplaceFirst(str, "%sym%", PXL.GenSymbol().ToString());
            }
            textCode.Text = str;
            buttonGenerate.Enabled = true;
        }

        private void listBoxDefaultFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch(listBoxDefaultFormat.SelectedIndex)
           {
               case 0:
                   textFormat.Text = "%num%%num%%num%%num%";
                   break;
               case 1:
                   textFormat.Text = "%CHAR%%num%%CHAR%%num%-%CHAR%%num%%CHAR%%num%-%CHAR%%num%%CHAR%%num%-%CHAR%%num%%CHAR%%num%";
                   break;
               case 2:
                   textFormat.Text = "+%num% (%num%%num%%num%) %num%%num%%num% %num%%num% %num%%num%";
                   break;
               case 3:
                   textFormat.Text = "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%";
                   break;
               case 4:
                   textFormat.Text = "%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%";
                   break;
               case 5:
                   textFormat.Text = "%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%%randws%";
                   break;
               case 6:
                   textFormat.Text = "%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%%rand%";
                   break;

           }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textCode.Text))
            {
                Clipboard.SetText(textCode.Text);
            }
        }

        private void buttonClearFormat_Click(object sender, EventArgs e)
        {
            textFormat.Clear();
        }
    }
}
