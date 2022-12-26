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
                string DecStr = valuelabel.Text;
                string ArbStr = "";

                for (int c = 0; c < DecStr.Length; c++)
                {
                    if (DecStr[c] == '0')
                    {
                        ArbStr = ArbStr + "۰";
                    }
                    else if (DecStr[c] == '1')
                    {
                        ArbStr = ArbStr + "۱";
                    }
                    else if (DecStr[c] == '2')
                    {
                        ArbStr = ArbStr + "۲";
                    }
                    else if (DecStr[c] == '3')
                    {
                        ArbStr = ArbStr + "۳";
                    }
                    else if (DecStr[c] == '4')
                    {
                        ArbStr = ArbStr + "٤";
                    }
                    else if (DecStr[c] == '5')
                    {
                        ArbStr = ArbStr + "۵";
                    }
                    else if (DecStr[c] == '6')
                    {
                        ArbStr = ArbStr + "٦";
                    }
                    else if (DecStr[c] == '7')
                    {
                        ArbStr = ArbStr + "٧";
                    }
                    else if (DecStr[c] == '8')
                    {
                        ArbStr = ArbStr + "٨";
                    }
                    else if (DecStr[c] == '9')
                    {
                        ArbStr = ArbStr + "٩";
                    }

                }

                answerlabel.Text = ArbStr;
            }


            if (chinesecharbutton.Checked == true)
            {

            }
            if (thaicharbutton.Checked == true)
            {
                MsgLabel.Text = "Message: ";
                string DecStr = valuelabel.Text;
                string ThaiStr = "";

                for (int c = 0; c < DecStr.Length; c++)
                {
                    if (DecStr[c] == '0')
                    {
                        ThaiStr = ThaiStr + "๐";
                    }
                    else if (DecStr[c] == '1')
                    {
                        ThaiStr = ThaiStr + "๑";
                    }
                    else if (DecStr[c] == '2')
                    {
                        ThaiStr = ThaiStr + "๒";
                    }
                    else if (DecStr[c] == '3')
                    {
                        ThaiStr = ThaiStr + "๓";
                    }
                    else if (DecStr[c] == '4')
                    {
                        ThaiStr = ThaiStr + "๔";
                    }
                    else if (DecStr[c] == '5')
                    {
                        ThaiStr = ThaiStr + "๕";
                    }
                    else if (DecStr[c] == '6')
                    {
                        ThaiStr = ThaiStr + "๖";
                    }
                    else if (DecStr[c] == '7')
                    {
                        ThaiStr = ThaiStr + "๗";
                    }
                    else if (DecStr[c] == '8')
                    {
                        ThaiStr = ThaiStr + "๘";
                    }
                    else if (DecStr[c] == '9')
                    {
                        ThaiStr = ThaiStr + "๙";
                    }

                }

                answerlabel.Text = ThaiStr;

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
