using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCalc
{
    public partial class EquaSol : Form
    {
        //Demo giải phương trình chỉ sử dụng Textbox, Label, Button và MessageBox tại IceTea Việt | Lập trình cuộc sống
        public EquaSol()
        {
            InitializeComponent();
        }

        private void bt_Linear_Click(object sender, EventArgs e)
        {
            txtBox_inC.Enabled = false;
        }

        private void bt_Quadratic_Click(object sender, EventArgs e)
        {
            txtBox_inC.Enabled = true;
        }

        private void bt_Solve_Click(object sender, EventArgs e)
        {
            //Nếu txtBox nhập C Disable thì nghĩa là ta phải giải PT bậc 1
            if(txtBox_inC.Enabled == false)
            {
                //Sử dụng try-catch để tránh Break chương trình khi dữ liệu nhập vào ko chính xác
                try
                {
                    ShowEqua(txtBox_inA.Text, txtBox_inB.Text);
                    LinearEquaSolve(int.Parse(txtBox_inA.Text), int.Parse(txtBox_inB.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa chính xác, chỉ có thể nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    
                
            }
            else //Nếu txtBox nhập C Disable thì nghĩa là ta phải giải PT bậc 2
            {
                try
                {
                    ShowEqua(txtBox_inA.Text, txtBox_inB.Text, txtBox_inC.Text);
                    QuadraEquaSolve(int.Parse(txtBox_inA.Text), int.Parse(txtBox_inB.Text), int.Parse(txtBox_inC.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dữ liệu nhập vào chưa chính xác, chỉ có thể nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
            }
        }


        //Hàm giải phương trình
        private void LinearEquaSolve(int a, int b)
        {
            if ((a == 0) && (b == 0))
            {
                MessageBox.Show("Phương trình vô số nghiệm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((a == 0) && (b != 0))
            {
                MessageBox.Show("Phương trình vô nghiệm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Phương trình có nghiệm X = " + -b * 1.0 / a, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuadraEquaSolve(int a, int b, int c)
        {
            float _delta = b * b - 4 * a * c;
            if (_delta < 0)
            {
                MessageBox.Show("Phương trình vô nghiệm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_delta == 0)
            {
                MessageBox.Show("Phương trình có nghiệm kép X = " + (-b * 1.0 / (2 * a)), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Phương trình có hai nghiệm phân biệt\n"
            + "X = " + ((-b * 1.0 + Math.Sqrt(_delta)) / (2 * a))
            + " và X = " + ((-b * 1.0 - Math.Sqrt(_delta)) / (2 * a)), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Hiển thị dạng phương trình, sử dụng Overload hàm
        private void ShowEqua(string a, string b)
        {
            txtBox_Equa.Text = a + "X ";
            if (int.Parse(b) < 0)
            {
                txtBox_Equa.Text += b + " = 0";
            }
            else
                txtBox_Equa.Text += "+ " + b + " = 0";
        }

        private void ShowEqua(string a, string b, string c)
        {
            txtBox_Equa.Text = a + "X^2 ";
            if (int.Parse(b) < 0)
            {
                txtBox_Equa.Text += b + "X ";
            }
            else
                txtBox_Equa.Text += "+" + b + "X ";
            if (int.Parse(c) < 0)
            {
                txtBox_Equa.Text += c + " = 0";
            }
            else
                txtBox_Equa.Text += "+" + c + " = 0";
        }

    }
}
