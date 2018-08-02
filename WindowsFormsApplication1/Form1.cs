using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int[] winers = new int[24];
        bool turn = true;
        int countred = 9;
        int countblue = 9;
        int x = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (turn == false)
            {
                groupBox1.Text = "نوبت قرمزه " + countred + " انتخاب";

            }
            else
            {
                groupBox1.Text = "نوبت آبیه";
            }
            System.Windows.Forms.Button currentButton = sender as System.Windows.Forms.Button;


            while (currentButton != null && turn == true && countred != 0)
            {

                /* if (countred != 0)
                 {
                     countred--;
                    // label1.Text = System.Convert.ToString(countred);
                 }*/
                if (currentButton.Name == "button1" && winers[0] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;

                    winers[0] = 1;
                    while (winers[0] == 1 && winers[1] == 1 && winers[2] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        //***********این قسمت برای حذف یکی از انتخاب های حریف می باشد***************
                        x = 1;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[0] == 1 && winers[6] == 1 && winers[7] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[0] == 1 && winers[8] == 1 && winers[20] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }

                else if
                (currentButton.Name == "button2" && winers[1] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[1] = 1;

                    while (winers[0] == 1 && winers[1] == 1 && winers[2] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[1] == 1 && winers[9] == 1 && winers[21] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                }
                else if
                (currentButton.Name == "button3" && winers[2] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[2] = 1;
                    while (winers[0] == 1 && winers[1] == 1 && winers[2] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[2] == 1 && winers[3] == 1 && winers[4] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[2] == 1 && winers[10] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button4" && winers[3] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[3] = 1;

                    while (winers[2] == 1 && winers[3] == 1 && winers[4] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[3] == 1 && winers[11] == 1 && winers[23] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button5" && winers[4] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[4] = 1;

                    while (winers[4] == 1 && winers[3] == 1 && winers[2] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[4] == 1 && winers[5] == 1 && winers[6] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[4] == 1 && winers[12] == 1 && winers[18] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button6" && winers[5] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[5] = 1;

                    while (winers[5] == 1 && winers[13] == 1 && winers[17] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[4] == 1 && winers[5] == 1 && winers[6] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                }
                else if
                (currentButton.Name == "button7" && winers[6] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[6] = 1;

                    while (winers[6] == 1 && winers[5] == 1 && winers[4] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[6] == 1 && winers[14] == 1 && winers[16] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[6] == 1 && winers[7] == 1 && winers[0] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
               (currentButton.Name == "button8" && winers[7] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[7] = 1;

                    while (winers[6] == 1 && winers[7] == 1 && winers[0] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[19] == 1 && winers[15] == 1 && winers[7] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                }
                else if
                (currentButton.Name == "button9" && winers[8] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[8] = 1;

                    while (winers[8] == 1 && winers[0] == 1 && winers[20] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[14] == 1 && winers[15] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[8] == 1 && winers[9] == 1 && winers[10] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button10" && winers[9] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[9] = 1;

                    while (winers[9] == 1 && winers[1] == 1 && winers[21] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[9] == 1 && winers[10] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button11" && winers[10] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[10] = 1;

                    while (winers[10] == 1 && winers[9] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[10] == 1 && winers[11] == 1 && winers[12] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[2] == 1 && winers[10] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                 (currentButton.Name == "button12" && winers[11] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[11] = 1;

                    while (winers[11] == 1 && winers[3] == 1 && winers[23] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[11] == 1 && winers[12] == 1 && winers[10] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                 (currentButton.Name == "button13" && winers[12] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[12] = 1;

                    while (winers[12] == 1 && winers[11] == 1 && winers[10] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[12] == 1 && winers[4] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[12] == 1 && winers[13] == 1 && winers[14] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button14" && winers[13] == 0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[13] = 1;

                    while (winers[13] == 1 && winers[17] == 1 && winers[5] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[13] == 1 && winers[12] == 1 && winers[14] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button15" && winers[14]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[14] = 1;

                    while (winers[12] == 1 && winers[13] == 1 && winers[14] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[14] == 1 && winers[16] == 1 && winers[5] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[14] == 1 && winers[15] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button16" && winers[15]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[15] = 1;

                    while (winers[15] == 1 && winers[14] == 1 && winers[8] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[15] == 1 && winers[19] == 1 && winers[7] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button17"&& winers[16]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[16] = 1;

                    while (winers[16] == 1 && winers[14] == 1 && winers[6] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[16] == 1 && winers[19] == 1 && winers[20] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                    while (winers[16] == 1 && winers[17] == 1 && winers[18] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button18" && winers[17]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[17] = 1;

                    while (winers[17] == 1 && winers[18] == 1 && winers[16] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[17] == 1 && winers[13] == 1 && winers[5] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                }
                else if
                (currentButton.Name == "button19" && winers[18]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[18] = 1;

                    while (winers[18] == 1 && winers[17] == 1 && winers[16] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                    while (winers[18] == 1 && winers[12] == 1 && winers[4] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }
                    while (winers[18] == 1 && winers[23] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        if (countblue > 0)
                        {
                            countblue--;
                            label2.Text = Convert.ToString(countblue);
                        }

                        else if (x == 1)
                        {
                            turn = !turn;
                            x++;
                        }
                        goto loop2;
                    }

                }
                else if
                (currentButton.Name == "button20" && winers[19]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[19] = 1;

                    while (winers[19] == 1 && winers[15] == 1 && winers[7] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[19] == 1 && winers[16] == 1 && winers[20] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button21" && winers[20]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[20] = 1;

                    while (winers[20] == 1 && winers[19] == 1 && winers[16] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[20] == 1 && winers[8] == 1 && winers[0] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                    while (winers[20] == 1 && winers[21] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button22" && winers[21]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[21] = 1;

                    while (winers[21] == 1 && winers[9] == 1 && winers[1] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[21] == 1 && winers[20] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button23" && winers[22]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[22] = 1;

                    while (winers[22] == 1 && winers[10] == 1 && winers[2] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[22] == 1 && winers[18] == 1 && winers[23] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                    while (winers[22] == 1 && winers[21] == 1 && winers[20] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else if
                (currentButton.Name == "button24" && winers[23]==0)
                {
                    countred--;
                    currentButton.BackColor = System.Drawing.Color.Red;
                    winers[23] = 1;

                    while (winers[23] == 1 && winers[11] == 1 && winers[3] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }

                    while (winers[23] == 1 && winers[18] == 1 && winers[22] == 1)
                    {
                        button26.BackColor = System.Drawing.Color.Red;
                        goto loop2;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("شما مجاز به انتخاب این خانه نمی باشید");
                    goto loop2;
                }
                goto loop1;
            }
            while (currentButton != null && turn == false && countblue != 0)
            {



                if (currentButton.Name == "button1" && winers[0] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[0] = 2;
                    while (winers[0] == 2 && winers[1] == 2 && winers[2] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[0] == 2 && winers[6] == 2 && winers[7] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[0] == 2 && winers[8] == 2 && winers[20] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if (currentButton.Name == "button2" && winers[1] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;

                    winers[1] = 2;

                    while (winers[0] == 2 && winers[1] == 2 && winers[2] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[1] == 2 && winers[9] == 2 && winers[21] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                }
                else if
                (currentButton.Name == "button3" && winers[2] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;

                    winers[2] = 2;
                    while (winers[0] == 2 && winers[1] == 2 && winers[2] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[2] == 2 && winers[3] == 2 && winers[4] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[2] == 2 && winers[10] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button4" && winers[3] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[3] = 2;

                    while (winers[2] == 2 && winers[3] == 2 && winers[4] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[3] == 2 && winers[11] == 2 && winers[23] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button5" && winers[4] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[4] = 2;

                    while (winers[4] == 2 && winers[3] == 2 && winers[2] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[4] == 2 && winers[5] == 2 && winers[6] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[4] == 2 && winers[12] == 2 && winers[18] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button6" && winers[5] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[5] = 2;

                    while (winers[5] == 2 && winers[14] == 2 && winers[17] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[4] == 2 && winers[5] == 2 && winers[6] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                }
                else if
                (currentButton.Name == "button7" && winers[6] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[6] = 2;

                    while (winers[6] == 2 && winers[5] == 2 && winers[4] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[6] == 2 && winers[14] == 2 && winers[16] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[6] == 2 && winers[7] == 2 && winers[0] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
               (currentButton.Name == "button8" && winers[7] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[7] = 2;

                    while (winers[6] == 2 && winers[7] == 2 && winers[0] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[19] == 2 && winers[15] == 2 && winers[7] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                }
                else if
                (currentButton.Name == "button9" && winers[8] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;

                    winers[8] = 2;

                    while (winers[8] == 2 && winers[0] == 2 && winers[20] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[14] == 2 && winers[15] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[8] == 2 && winers[9] == 2 && winers[10] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button10" && winers[9] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[9] = 2;

                    while (winers[9] == 2 && winers[1] == 2 && winers[21] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[9] == 2 && winers[10] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button11" && winers[10] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[10] = 2;

                    while (winers[10] == 2 && winers[9] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[10] == 2 && winers[11] == 2 && winers[12] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[2] == 2 && winers[10] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                 (currentButton.Name == "button12" && winers[11] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[11] = 2;

                    while (winers[11] == 2 && winers[3] == 2 && winers[23] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[11] == 2 && winers[12] == 2 && winers[10] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                 (currentButton.Name == "button13" && winers[12] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[12] = 2;

                    while (winers[12] == 2 && winers[11] == 2 && winers[10] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[12] == 2 && winers[4] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[12] == 2 && winers[13] == 2 && winers[14] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button14" && winers[13] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[13] = 2;

                    while (winers[13] == 2 && winers[17] == 2 && winers[5] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[13] == 2 && winers[12] == 2 && winers[14] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button15" && winers[14] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[14] = 2;

                    while (winers[12] == 2 && winers[13] == 2 && winers[14] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[14] == 2 && winers[16] == 2 && winers[5] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[14] == 2 && winers[15] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button16" && winers[15] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[15] = 2;

                    while (winers[15] == 2 && winers[14] == 2 && winers[8] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[15] == 2 && winers[19] == 2 && winers[7] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button17" && winers[16] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[16] = 2;

                    while (winers[16] == 2 && winers[14] == 2 && winers[6] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[16] == 2 && winers[19] == 2 && winers[20] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[16] == 2 && winers[17] == 2 && winers[18] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button18" && winers[17] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[17] = 2;

                    while (winers[17] == 2 && winers[18] == 2 && winers[16] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[17] == 2 && winers[13] == 2 && winers[5] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                }
                else if
                (currentButton.Name == "button19" && winers[18] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[18] = 2;

                    while (winers[18] == 2 && winers[17] == 2 && winers[16] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[18] == 2 && winers[12] == 2 && winers[4] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[18] == 2 && winers[23] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                }
                else if
                (currentButton.Name == "button20" && winers[19] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[19] = 2;

                    while (winers[19] == 2 && winers[15] == 2 && winers[7] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[19] == 2 && winers[16] == 2 && winers[20] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button21" && winers[20] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[20] = 2;

                    while (winers[20] == 2 && winers[19] == 2 && winers[16] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[20] == 2 && winers[8] == 2 && winers[0] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[20] == 2 && winers[21] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button22" && winers[21] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[21] = 2;

                    while (winers[21] == 2 && winers[9] == 2 && winers[1] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[21] == 2 && winers[20] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button23" && winers[22] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[22] = 2;

                    while (winers[22] == 2 && winers[10] == 2 && winers[2] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[22] == 2 && winers[18] == 2 && winers[23] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                    while (winers[22] == 2 && winers[21] == 2 && winers[20] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else if
                (currentButton.Name == "button24" && winers[23] == 0)
                {
                    currentButton.BackColor = System.Drawing.Color.Blue;
                    countblue--;
                    winers[23] = 2;

                    while (winers[23] == 2 && winers[11] == 2 && winers[3] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }

                    while (winers[23] == 2 && winers[18] == 2 && winers[22] == 2)
                    {
                        button26.BackColor = System.Drawing.Color.Blue;
                        goto loop3;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("شما مجاز به انتخاب این خانه نمی باشید");
                    goto loop3;
                }
                goto loop1;
            }
            while (currentButton != null && turn == true && countred == 0)
            {
                if (currentButton.Name == "button1" && winers[0] == 1)
                {
                    countred++;
                    winers[0] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button2" && winers[1] == 1)
                {
                    countred++;
                    winers[1] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button3" && winers[2] == 1)
                {
                    countred++;
                    winers[2] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button4" && winers[3] == 1)
                {
                    countred++;
                    winers[3] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button5" && winers[4] == 1)
                {
                    countred++;
                    winers[4] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button6" && winers[5] == 1)
                {
                    countred++;
                    winers[5] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button7" && winers[6] == 1)
                {
                    countred++;
                    winers[6] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button8" && winers[7] == 1)
                {
                    countred++;
                    winers[7] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button9" && winers[8] == 1)
                {
                    countred++;
                    winers[0] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button10" && winers[9] == 1)
                {
                    countred++;
                    winers[9] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button11" && winers[10] == 1)
                {
                    countred++;
                    winers[10] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button12" && winers[11] == 1)
                {
                    countred++;
                    winers[11] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button13" && winers[12] == 1)
                {
                    countred++;
                    winers[12] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button14" && winers[13] == 1)
                {
                    countred++;
                    winers[13] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button15" && winers[14] == 1)
                {
                    countred++;
                    winers[14] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button16" && winers[15] == 1)
                {
                    countred++;
                    winers[15] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button17" && winers[16] == 1)
                {
                    countred++;
                    winers[16] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button18" && winers[17] == 1)
                {
                    countred++;
                    winers[17] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button19" && winers[18] == 1)
                {
                    countred++;
                    winers[18] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button20" && winers[19] == 1)
                {
                    countred++;
                    winers[19] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button21" && winers[20] == 1)
                {
                    countred++;
                    winers[20] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button22" && winers[21] == 1)
                {
                    countred++;
                    winers[21] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button23" && winers[22] == 1)
                {
                    countred++;
                    winers[22] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                if (currentButton.Name == "button24" && winers[23] == 1)
                {
                    countred++;
                    winers[23] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop2;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("شما مجاز به انتخاب این خانه نمی باشید");
                    goto loop2;
                }

            }
            while (currentButton != null && turn == false && countblue == 0)
            {
                if (currentButton.Name == "button1" && winers[0] == 2)
                {
                    countblue++;
                    winers[0] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button2" && winers[1] == 2)
                {
                    countblue++;
                    winers[1] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button3" && winers[2] == 2)
                {
                    countblue++;
                    winers[2] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button4" && winers[3] == 2)
                {
                    countblue++;
                    winers[3] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button5" && winers[4] == 2)
                {
                    countblue++;
                    winers[4] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button6" && winers[5] == 2)
                {
                    countblue++;
                    winers[5] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button7" && winers[6] == 2)
                {
                    countblue++;
                    winers[6] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button8" && winers[7] == 2)
                {
                    countblue++;
                    winers[7] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button9" && winers[8] == 2)
                {
                    countblue++;
                    winers[0] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button10" && winers[9] == 2)
                {
                    countblue++;
                    winers[9] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button11" && winers[10] == 2)
                {
                    countblue++;
                    winers[10] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button12" && winers[11] == 2)
                {
                    countblue++;
                    winers[11] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button13" && winers[12] == 2)
                {
                    countblue++;
                    winers[12] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button14" && winers[13] == 2)
                {
                    countblue++;
                    winers[13] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button15" && winers[14] == 2)
                {
                    countblue++;
                    winers[14] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button16" && winers[15] == 2)
                {
                    countblue++;
                    winers[15] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button17" && winers[16] == 2)
                {
                    countblue++;
                    winers[16] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button18" && winers[17] == 2)
                {
                    countblue++;
                    winers[17] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button19" && winers[18] == 2)
                {
                    countblue++;
                    winers[18] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button20" && winers[19] == 2)
                {
                    countblue++;
                    winers[19] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button21" && winers[20] == 2)
                {
                    countblue++;
                    winers[20] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button22" && winers[21] == 2)
                {
                    countblue++;
                    winers[21] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button23" && winers[22] == 2)
                {
                    countblue++;
                    winers[22] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }
                if (currentButton.Name == "button24" && winers[23] == 2)
                {
                    countblue++;
                    winers[23] = 0;
                    currentButton.BackColor = System.Drawing.Color.White;
                    goto loop3;
                }

                // for(int i=0;i<23;i++)



                /*  || winers[1] == 2 || winers[2] == 2 || winers[3] == 2 || winers[4] == 2 || winers[5] == 2 || winers[6] == 2 ||
                  winers[7] == 2 || winers[8] == 2 || winers[9] == 2 || winers[10] == 2 || winers[11] == 2 || winers[12] == 2 || winers[13] == 2 ||
                  winers[14] == 2 || winers[15] == 2 || winers[16] == 2 || winers[17] == 2 || winers[18] == 2 || winers[19] == 2 || winers[20] == 2 ||
                  winers[21] == 2 || winers[22] == 2 || winers[23] == 2)*/
                // if (winers[0]==2 && turn==false)
                //  if(countblue==0 && )

                else
                {
                    System.Windows.Forms.MessageBox.Show("شما مجاز به انتخاب این خانه نمی باشید");
                }
                goto loop3;

            }
            loop1:
            turn = !turn;
            loop2:
            label1.Text = System.Convert.ToString(countred);
            loop3:
            label2.Text = Convert.ToString(countblue);


        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            label3.Visible = true;

        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label3.Visible = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.White;
            button2.BackColor = System.Drawing.Color.White;
            button3.BackColor = System.Drawing.Color.White;
            button4.BackColor = System.Drawing.Color.White;
            button5.BackColor = System.Drawing.Color.White;
            button6.BackColor = System.Drawing.Color.White;
            button7.BackColor = System.Drawing.Color.White;
            button8.BackColor = System.Drawing.Color.White;
            button9.BackColor = System.Drawing.Color.White;
            button10.BackColor = System.Drawing.Color.White;
            button11.BackColor = System.Drawing.Color.White;
            button12.BackColor = System.Drawing.Color.White;
            button13.BackColor = System.Drawing.Color.White;
            button14.BackColor = System.Drawing.Color.White;
            button15.BackColor = System.Drawing.Color.White;
            button16.BackColor = System.Drawing.Color.White;
            button17.BackColor = System.Drawing.Color.White;
            button18.BackColor = System.Drawing.Color.White;
            button19.BackColor = System.Drawing.Color.White;
            button20.BackColor = System.Drawing.Color.White;
            button21.BackColor = System.Drawing.Color.White;
            button22.BackColor = System.Drawing.Color.White;
            button23.BackColor = System.Drawing.Color.White;
            button24.BackColor = System.Drawing.Color.White;
            button26.BackColor = System.Drawing.Color.White;
            turn = true;
            countred = 9;
            label1.Text = Convert.ToString(countred);
            countblue = 9;
            label2.Text = Convert.ToString(countblue);

        }

        private void redToYellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (winers[0] == 1)
            {
                button1.BackColor = System.Drawing.Color.Yellow;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (turn == true)
            {
                groupBox1.Text = "نوبت قرمزه";
            }
            else
            {
                groupBox1.Text = "نوبت آبیه";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
