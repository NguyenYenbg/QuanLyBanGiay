using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QLBanGiay.XuLy;
using QLBanGiay.Forms.ThongTinUser;
using QLBanGiay.XuLy.DataProcessing;
namespace QLBanGiay
{
    public partial class FormMainMenu : Form
    {
        int ma;
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //xuly
        common commonMethod = new common();
        
        //constructor
        public FormMainMenu(int ma)
        {
            InitializeComponent();
            this.ma = ma;
            DataTable dtUser = new NhanVienDPro().getNhanVienByMaNV(ma);
            IconUser.Text = dtUser.Rows[0].ItemArray[3].ToString();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            
            this.ma = ma;
            commonMethod.MaximizeForm(this);
        }

        //Struct: tạo 1 Struct để lưu trữ lượng màu RGB
        private struct RGBColors
        {           
            public static Color color1 = Color.FromArgb(255, 184, 108);           
            public static Color color2 = Color.FromArgb(250, 172, 88);           
        }

        //Method
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)  //
            {
                DisableButton();   //gọi pthức trả về giá trị mặc định để hủy kích hoạt nút trước đó
                //Button
                currentBtn = (IconButton)senderBtn; //gán nút hiện tại với nút gửi để chuyển đối tượng sang cùng loại nút
               currentBtn.BackColor = Color.FromArgb(37,36,81);   //thay đổi màu nền của nút
            
                currentBtn.ForeColor = color;   //thay đổi màu văn bản của nút
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;   //căn chỉnh text về phía trung tâm
                currentBtn.IconColor = color;   //đổi màu biểu tượng thành tham số màu
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;   //đổi tỉ lệ text đứng trước icon
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;   //căn chỉnh icon sang phải
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;    //icon con = icon của nút hiện tại
                iconCurrentChildForm.IconColor = color;
                //lblTitleChildForm
                lblTitleChildForm.Text = currentBtn.Text;
                    //lblTitleChildForm.ForeColor = color;
            }
        }

        //tắt tính năng đánh dấu nút, trả về giá trị mặc định của nút
        private void DisableButton()
        {
            if(currentBtn!=null)    //nút hiện tại != null
            {
                currentBtn.BackColor = Color.FromArgb(72, 138, 199);
                     
                currentBtn.ForeColor = Color.White; 
                currentBtn.TextAlign = ContentAlignment.MiddleLeft; 
                currentBtn.IconColor = Color.White;  
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;   //hiển thị biểu tượng trước text  
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; 
            }    
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
      
        
        }

        private void iconButtonTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentChildForm != null)
            {
                currentChildForm.Close(); //đóng Form trước đó
            }
        }

        private void iconButtonDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormDanhMuc());
        }

        private void iconButtonSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormSanPham());
        }

        private void iconButtonNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormNhanVien(ma));
        }

        private void iconButtonKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormKhachHang(ma));
        }

        private void iconButtonNhaCC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormNhaCC(ma));
        }

        private void iconButtonHoaDon_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormHoaDon(ma));
        }

        //Drag Form: di chuyển Form       
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e) 
        {
            commonMethod.DragForm(this);
        }


        private void iconPictureClose_Click(object sender, EventArgs e)
        {
            commonMethod.ExitForm(this);
        }
        private void iconPictureMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconPictureMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThongTin f = new FormThongTin(ma);
            f.ShowDialog();
        }

        
    }
}
