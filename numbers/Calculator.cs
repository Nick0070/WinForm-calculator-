using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers
{
    public partial class Calculator : Form
    {
        double a;
        string D;



        // button_in_pad_numbers

        //button_number_1
        private void b_1_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_1.Text;
            box_see_move.Text = box_see_move.Text + b_1.Text;
        }

        //button_number_2
        private void b_2_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_2.Text;
            box_see_move.Text = box_see_move.Text + b_2.Text;
        }

        //button_number_3
        private void b_3_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_3.Text;
            box_see_move.Text = box_see_move.Text + b_3.Text;
        }

        //button_number_4
        private void b_4_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_4.Text;
            box_see_move.Text = box_see_move.Text + b_4.Text;
        }

        //button_number_5
        private void b_5_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_5.Text;
            box_see_move.Text = box_see_move.Text + b_5.Text;
        }

        //button_number_6
        private void b_6_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_6.Text;
            box_see_move.Text = box_see_move.Text + b_6.Text;
        }

        //button_number_7
        private void b_7_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_7.Text;
            box_see_move.Text = box_see_move.Text + b_7.Text;
        }

        //button_number_8
        private void b_8_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_8.Text;
            box_see_move.Text = box_see_move.Text + b_8.Text;
        }

        //button_number_9
        private void b_9_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_9.Text;
            box_see_move.Text = box_see_move.Text + b_9.Text;
        }

        //button_number_0
        private void b_0_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_0.Text;
            box_see_move.Text = box_see_move.Text + b_0.Text;
        }


        //button_in_pad_move

        //button_plus
        private void b_plus_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            a = Convert.ToDouble(box_info.Text);
            box_info.Clear();

            box_see_move.Text = box_see_move.Text + b_plus.Text;
        }

        //button_mines
        private void b_mines_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            a = Convert.ToDouble(box_info.Text);
            box_info.Clear();
            box_see_move.Text = box_see_move.Text + b_mines.Text;
        }


        //button_multiply
        private void b_multiply_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            a = Convert.ToDouble(box_info.Text);
            box_info.Clear();
            box_see_move.Text = box_see_move.Text + b_multiply.Text;
        }

        //button_division
        private void b_division_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            a = Convert.ToDouble(box_info.Text);
            box_info.Clear();
            box_see_move.Text = box_see_move.Text + b_division.Text;
        }


        //button_finish
        private void b_finish_Click(object sender, EventArgs e)
        {
            double b, res;
            res = 0;
            b = Convert.ToDouble(box_info.Text);

            if (D == "+")
            {
                res = a + b;
            }
            if (D == "-")
            {
                res = a - b;
            }
            if (D == "*")
            {
                res = a * b;
            }
            if (D == "/")
            {
                res = a / b;
            }

            box_info.Text = res.ToString();
            // textBox1.Text = "/";
        }


        //button_clean
        private void b_clean_Click(object sender, EventArgs e)
        {
            box_info.Clear();
            box_see_move.Clear();
        }


        //button_double
        private void b_double_Click(object sender, EventArgs e)
        {
            box_info.Text = box_info.Text + b_double.Text;
            box_see_move.Text = box_see_move.Text + b_double.Text;
        }
    }
}

