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

namespace unifiednumber
{
    public partial class UnifiedNumber : Form
    {
        unifiednumber myunifiednumber = new unifiednumber();
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
                answerlabel.Text = myunifiednumber.ToArabic();
            }


            if (chinesecharbutton.Checked == true)
            {

            }
            if (thaicharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                answerlabel.Text = myunifiednumber.ToThai();

            }
            if (romanButton.Checked == true)
            {
                int DecStr = Convert.ToInt32( valuelabel.Text);
                {
                    string romanResult = string.Empty;
                    string[] romanLetters = {"M","CM","D","CD","C","XC","L","XL", "X","IX","V","IV","I"};
                    int[] numbers = {1000,900,500,400,100,90,50,40,10,9,5,4,1};
                    int i = 0;
                    Convert.ToString(numbers);
                    if (DecStr == 0)
                    {
                        MsgLabel.Text = "Message: There is no single digit '0' in roman numbers";

                    }
                    else
                    {
                        MsgLabel.Text = "Message: ";
                        while (DecStr != 0)
                        {
                            if (DecStr >= numbers[i])
                            {
                                DecStr -= numbers[i];
                                romanResult += romanLetters[i];
                            }
                            else
                            {
                                i++;
                            }
                        }
                    }
                    Convert.ToString(romanResult);
                    answerlabel.Text = romanResult;
                }

            }

        }
     
    }
}
