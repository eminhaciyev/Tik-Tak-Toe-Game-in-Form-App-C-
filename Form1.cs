using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIkTakToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TikTakToe_Load(object sender, EventArgs e)
        {
           
        }


        bool tiktak = true;

        private void button1_Click(object sender, EventArgs e)
        {
                var button = (Button)sender;
            //int count = 0;
            if (sender is Button)
            {
                if (tiktak)
                {
                    button.Text = "X"; 
                    

                    tiktak = false;
                    //count++;
                }
                else
                {
                    //count = 0;
                    button.Text = "O";
                    tiktak = true;
                    //count++;
                }
                
            }




            //List<Button> winnList = new List<Button>();


            //bool @bool = true;
            //int count = 0;
            //foreach (var item in Controls)
            //{
            //    Button emin = item as Button;
            //    if (emin is Button)
            //    {
            //        if (emin.Location.X == emin.Location.Y)
            //        {
            //            //winnList.Add(emin);
            //            if (count == 2)
            //            {
            //                MessageBox.Show("You Win");
            //                emin.Enabled = false;
            //            }
            //            count++;
            //            continue;
            //        }
            //    }

            //}

            TikTak();

            void TikTak()
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" || button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X" || button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    button1.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X" || button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
                {
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X" || button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    button3.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X" || button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X" || button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X" || button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    button1.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }
                else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X" || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    MessageBox.Show("You Win");
                }

            }

           
        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            button1.Text = " ";            
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";

        }
    }
}
