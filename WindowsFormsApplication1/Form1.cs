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
        public Form1()
        {
            InitializeComponent();
        }
        //KHAI BÁO BIẾN
        #region Variables
        //Tài khoản
        //private Account[] Arr_Acc = new Account[1];
        private bool isLogined = true;
        //Lưu trữ
        private float fMemory = 0;
        private string str_LastValue = "";
        private string str_Type = "";
        //các biến bool để gắn cờ
        private bool isDot = false;
        private bool isCalc = false;
        private bool isMemory = false;
        private bool isPercent = false;
        private bool isInverse = false;
        private bool isSqrt = false;
        private bool isSquared = false;
        private bool isCubed = false;
        #endregion Variables
        //XỬ LÝ SỐ 0->9 VÀ .
        #region DigitButtons
        //Xem cmt ở bt_0 và tương tự cho các bt còn lại
        #endregion DigitButtons
        //XỬ LÝ CÁC PHÉP TÍNH
        #region TypeOfCalc
        //Xem cmt của phép cộng và tương tự cho các phép tính còn lại
        //Xử lý nút = (tương tự như xử lý các phép tính)
        #endregion TypeOfCalc
        //TẠO CÁC HÀM CHO MÁY TÍNH
        #region Functions
        //Xử lý nút Clear
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            txtBox_Result.Text = "0";
            txtBox_InputStr.Clear();
            str_LastValue = "";
            str_Type = "";
            resetStatus();

        }

        //Xử lý chức năng %

        //Xử lý chức năng ngịch đảo

        //Xử lý nút xóa 

        //Xử lý chức năng căn bậc 2
        private void bt_Sqrt_Click(object sender, EventArgs e)
        {
            //Lấy giá trị từ khung Kq, rút căn và gán lại
            double _temp = double.Parse(txtBox_Result.Text);

            //Nếu căn bậc 2 số âm thì lỗi NaN
            _temp = Math.Sqrt(_temp);
            txtBox_Result.Text = _temp.ToString();


            //Xử lý cờ
            isSqrt = true;
            isCalc = false;
        }

        //Xử lý chức năng thêm dấu âm dương

        //Xử lý chức năng mũ 2

        //Xử lý chức năng mũ 3


        //Xử lý chức năng Memory
        #region MemoryFunction


        private void bt_MClear_Click(object sender, EventArgs e)
        {
            fMemory = 0;
            lbl_Memory.Visible = false;
            isMemory = true;

        }
        #endregion MemoryFunction

        #endregion Functions
        //HÀM TÍNH TOÁN CHUNG
        private string Calc(string a, string b, string _Type)
        {
            //Lấy hai giá trị trước sau và kiểu phép tính
            float fa = float.Parse(a);
            float fb = float.Parse(b);

            //Xét kiểu và tính toán, return kết quả
            if (_Type == "+")
            {
                return Convert.ToString(fa + fb);
            }
            else if (_Type == "−")
            {
                return Convert.ToString(fa - fb);
            }
            else if (_Type == "*")
            {
                return Convert.ToString(fa * fb);
            }
            else
            {
                return Convert.ToString(fa / fb);
            }
        }
        //XÉT XEM CÓ THỂ IN SỐ MỚI RA MÀN HÌNH (SAU KHI ĐÃ THỰC HIÊN 1 CHỨC NĂNG/PHÉP TÍNH GÌ ĐÓ)
        private bool canPrintNewNumb()
        {
            if ((isCalc) || (isMemory) || (isInverse) || (isSqrt) || (isSquared) || (isCubed))
            {
                return true;
            }
            else
                return false;
        }
        //RESET TRẠNG THÁI CỜ VỀ FALSE
        private void resetStatus()
        {
            isCalc = false;
            isMemory = false;
            isInverse = false;
            isSqrt = false;
            isSquared = false;
            isCubed = false;
        }
        //XÉT XEM CÓ CHỨA PHÉP TÍNH CHƯA (VÌ NẾU ĐÃ CHỨA PHÉP TÍNH THÌ PHÉP TÍNH TIẾP THEO TA PHẢI TÍNH KQ CỦA PHÉP TÍNH TRC
        private bool isContainCalcType()
        {
            if ((txtBox_InputStr.Text.Contains("+")) || (txtBox_InputStr.Text.Contains("−")) || (txtBox_InputStr.Text.Contains("*")) || (txtBox_InputStr.Text.Contains("/")))
            {
                return true;
            }
            else
                return false;
        }
        
        //CAI NAY THAY CO SAN ROI
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
