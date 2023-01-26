using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnifiedNumeral;

namespace unifiednumber
{
    public partial class UnifiedNumber : Form
    {
        UnifiedNumeral.UnifiedNumeral myunifiednumber = new UnifiedNumeral.UnifiedNumeral();
        public UnifiedNumber()
        {
            InitializeComponent();
        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(Valuetextbox.Text);
            }
            catch (Exception excep)
            {
                MsgLabel.Text = "Message: Please Give A Valid Value";
                return;
            }
            myunifiednumber.Value = temp;
            valuelabel.Text = Convert.ToString(temp);

        }

        private void translatebutton_Click(object sender, EventArgs e)
        {
            if (arabiccharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text =myunifiednumber.ToArabic();
            }


            if (chinesecharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                string ChnStr = Convert.ToString(myunifiednumber.ToChinese());
                answerlabel.Text = ChnStr;


            }
            if (thaicharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text = myunifiednumber.ToThai();

            }
            if (romanButton.Checked == true)
            {
                int DecInt = Convert.ToInt32(Valuetextbox.Text);
                if (DecInt == 0)
                {
                    MsgLabel.Text = "Message: There is no single digit '0' in roman number ";
                }

                if (DecInt > 0)
                {
                    MsgLabel.Text = "Message: ";
                    string RomanStr = Convert.ToString(myunifiednumber.ToRoman());
                    answerlabel.Text = RomanStr;

                }
            }

        }

        private void revertbutton_Click(object sender, EventArgs e)
        {
            if (arabiccharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text = valuelabel.Text;
            }


            if (chinesecharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: "; 
                answerlabel.Text = valuelabel.Text;


            }
            if (thaicharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text = valuelabel.Text;

            }
            if (romanButton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text = valuelabel.Text;
            }

        }
    }
}
