using PearXLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        Random rand = new Random();
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PXL.createDir(d.pxDir + PXL.s + "xRandomer");
            this.Icon = Resources.icon;
        }

        private void textCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control)
            {
                e.SuppressKeyPress = true;
            }
        }

        string Gen()
        {
            string str = textFormat.Text;
            while (str.Contains("%char%"))
            {
                str = PXL.ReplaceFirst(str, "%char%", PXL.GenChar(rand).ToString());
            }
            while (str.Contains("%CHAR%"))
            {
                str = PXL.ReplaceFirst(str, "%CHAR%", PXL.GenChar(rand).ToString().ToUpper());
            }
            while (str.Contains("%num%"))
            {
                str = PXL.ReplaceFirst(str, "%num%", PXL.GenNumber(rand).ToString());
            }
            while (str.Contains("%rand%"))
            {
                str = PXL.ReplaceFirst(str, "%rand%", PXL.GenRandom(rand, true).ToString());
            }
            while (str.Contains("%randws%"))
            {
                str = PXL.ReplaceFirst(str, "%randws%", PXL.GenRandom(rand, false).ToString());
            }
            while (str.Contains("%sym%"))
            {
                str = PXL.ReplaceFirst(str, "%sym%", PXL.GenSymbol(rand).ToString());
            }
            return str;
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            buttonGenerate.Enabled = false;
            Gen();
            textCode.Text = Gen();
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
        private void backgroundWorkerAutoRandom_DoWork(object sender, DoWorkEventArgs e)
        {
            int repeat = Convert.ToInt32(textBoxCount.Text);
            string dt = DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year + "_" + DateTime.Now.Hour.ToString() + "." + DateTime.Now.Minute.ToString() + "." + DateTime.Now.Second.ToString();
            for (int i = 0; i < repeat; i++)
            {
                File.AppendAllText(d.pxDir + PXL.s + "xRandomer" + PXL.s + "Generated_" + dt + ".txt", Gen() + "\n");
            }
        }
        private void buttonAutoGenStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxCount.Text))
            {
                backgroundWorkerAutoRandom.RunWorkerAsync();
                pictureBoxLoading.Image = Resources.loading;
            }
        }

        private void buttonAutoGenStop_Click(object sender, EventArgs e)
        {
            backgroundWorkerAutoRandom.CancelAsync();
        }

        private void backgroundWorkerAutoRandom_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBoxLoading.Image = null;
            
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(d.pxDir + PXL.s + "xRandomer");
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (PXL.isNumberKey(e))
            {
                e.Handled = true;
            }
        }

        bool isAutoGenOpened = false;
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (isAutoGenOpened)
            {
                isAutoGenOpened = false;
                groupBoxAutoGen.Visible = false;
                buttonPlus.Image = Resources.plus;
            }
            else
            {
                isAutoGenOpened = true;
                groupBoxAutoGen.Visible = true;
                buttonPlus.Image = Resources.minus;
            }
        }
    }
}
