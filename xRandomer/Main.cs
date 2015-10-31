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

           }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textCode.Text);
        }
    }
}
