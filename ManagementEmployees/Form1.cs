using ManagementEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementEmployees
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        Modify modify;
        NhanVien nhanVien;
        public void Xoa()
        {
            
            this.textBox1.Text = "";
            this.textBox11.Text = "";
            this.comboBox2.Text = "";
            this.textBox14.Text = "";
            this.comboBox4.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.comboBox3.Text = "";
            this.textBox5.Text = "";
            this.TbNVMSdt.Text = "";
            this.TbNVTenNV.Text = "";
            this.comboBox6.Text = "";
            this.comboBox7.Text = "";
            this.textBox10.Text = "";
            this.TbNVDiaChi.Text = "";
            this.TbNVMaNV.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Fill();
            Full();
            modify = new Modify();

            try
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (tabControl1.SelectedIndex == 1)//Luong
            {

                string MaNV = comboBox3.Text;
                DateTime ngay = dateTimePicker3.Value;
                string LCB = textBox14.Text;
                string LT = textBox2.Text;
                string LPC = textBox1.Text;
                Luong luong = new Luong(MaNV, ngay, float.Parse(LCB), float.Parse(LT), float.Parse(LPC));

                if (modify.insert_l(luong))
                {
                    dataGridView1.DataSource = modify.getAllLuong();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tabControl1.SelectedIndex == 2) //Phong  Ban
            {
                string maPB = this.textBox12.Text;
                string TenPB = this.textBox5.Text;
                string SoDienThoai = this.textBox10.Text;


                PhongBan phongban = new PhongBan(maPB, TenPB, SoDienThoai);

                if (modify.insert_pb(phongban))
                {
                    dataGridView1.DataSource = modify.getAllPhongBan();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Full();

            }
            if (tabControl1.SelectedIndex == 0) //NhanVIen
            {

                string maNv = this.TbNVMaNV.Text;
                string maPb = this.comboBox6.Text;
                string maCv = this.comboBox7.Text;
                string hoTen = this.TbNVTenNV.Text;
                DateTime ngaySinh = this.dateTimeNv.Value;
                string gioiTinh = this.rdNVNam.Checked ? "Nam" : "Nữ";
                string diaChi = this.TbNVDiaChi.Text;
                string soDienThoai = this.TbNVMSdt.Text;

                NhanVien nhanVien = new NhanVien(maNv, maPb, maCv, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);

                if (modify.insert_nv(nhanVien))
                {
                    dataGridView1.DataSource = modify.getAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Fill();

            }
            if (tabControl1.SelectedIndex == 3)
            {
                string maNV = this.comboBox4.Text;
                DateTime ngaybd = dateTimePicker1.Value;
                DateTime ngaykt = dateTimePicker4.Value;


                LichSuLamViec lslv = new LichSuLamViec(maNV, ngaybd, ngaykt);

                if (modify.insert_lslv(lslv))
                {
                    dataGridView1.DataSource = modify.getAllLichSuLamViec();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (tabControl1.SelectedIndex == 4)
            {
                string maPL = this.comboBox5.Text;
                string maNV = this.comboBox2.Text;
                DateTime ngay = dateTimePicker2.Value;
                string nd = this.textBox11.Text;
                string ht = this.textBox3.Text;


                PhucLoi phucloi = new PhucLoi(maPL, maNV, ngay, nd, ht);

                if (modify.insert_pl(phucloi))
                {
                    dataGridView1.DataSource = modify.getAllPhucLoi();
                }
                else
                {
                    MessageBox.Show("Lỗi: " + "Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Xoa();


        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TbNVMSdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rdNVNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNVNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            try
            {
                if (comboBox1.Text == "Nhân Viên")
                {
                    dataGridView1.DataSource = modify.getAllNhanVien();
                }
                if (comboBox1.Text == "Lương")
                {
                    dataGridView1.DataSource = modify.getAllLuong();
                }
                if (comboBox1.Text == "Phòng Ban")
                {
                    dataGridView1.DataSource = modify.getAllPhongBan();
                }
                if (comboBox1.Text == "Lịch Sử Làm Việc")
                {
                    dataGridView1.DataSource = modify.getAllLichSuLamViec();
                }
                if (comboBox1.Text == "Phúc Lợi")
                {
                    dataGridView1.DataSource = modify.getAllPhucLoi();
                }

            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index; //dong bam
            string b = dataGridView1.Rows[a].Cells[0].Value.ToString();
            if (tabControl1.SelectedIndex == 0) //NhanVIen
            {
                string maNv = this.TbNVMaNV.Text;
                string maPb = this.comboBox6.Text;
                string maCv = this.comboBox7.Text;
                string hoTen = this.TbNVTenNV.Text;
                DateTime ngaySinh = this.dateTimeNv.Value;
                string gioiTinh = this.rdNVNam.Checked ? "Nam" : "Nữ";
                string diaChi = this.TbNVDiaChi.Text;
                string soDienThoai = this.TbNVMSdt.Text;
                //gia tri theo vi tri

                NhanVien nhanVien = new NhanVien(maNv, maPb, maCv, hoTen, ngaySinh, gioiTinh, diaChi, soDienThoai);
                

                try
                {
                    modify.update_nv(nhanVien, b);
                }
                catch
                {
                    MessageBox.Show("Co du lieu khong the sua hoac du lieu khong hop le, vui long coi lai");
                }
                dataGridView1.DataSource = modify.getAllNhanVien();
                Fill();
            }
            if (tabControl1.SelectedIndex == 2)
            {
                string maPB = this.textBox12.Text;
                string TenPB = this.textBox5.Text;
                string SoDienThoai = this.textBox10.Text;


                PhongBan phongban = new PhongBan(maPB, TenPB, SoDienThoai);
                try
                {
                    modify.update_pb(phongban, b);
                }
                catch
                {
                    MessageBox.Show("Co du lieu khong the sua hoac du lieu khong hop le, vui long coi lai");
                }
                
                dataGridView1.DataSource = modify.getAllPhongBan();
                Full();
            }


            if (tabControl1.SelectedIndex == 1)//Luong
            {

                string MaNV = comboBox3.Text;
                DateTime ngay = dateTimePicker3.Value;
                string LCB = textBox14.Text;
                string LT = textBox2.Text;
                string LPC = textBox1.Text;
                Luong luong = new Luong(MaNV, ngay, float.Parse(LCB), float.Parse(LT), float.Parse(LPC));

                try
                {
                    modify.update_l(luong, b);
                }
                catch
                {
                    MessageBox.Show("Co du lieu khong the sua hoac du lieu khong hop le, vui long coi lai");
                }
                
                dataGridView1.DataSource = modify.getAllLuong();
            }

            if (tabControl1.SelectedIndex == 3)
            {
                string maNV = this.comboBox4.Text;
                DateTime ngaybd = dateTimePicker1.Value;
                DateTime ngaykt = dateTimePicker4.Value;


                LichSuLamViec lslv = new LichSuLamViec(maNV, ngaybd, ngaykt);

                try
                {
                    modify.update_lslv(lslv, b);
                }
                catch 
                {
                    MessageBox.Show("Co du lieu khong the sua hoac du lieu khong hop le, vui long coi lai");
                }
                dataGridView1.DataSource = modify.getAllLichSuLamViec();
            }



            if (tabControl1.SelectedIndex == 4)
            {
                string maPL = this.comboBox5.Text;
                string maNV = this.comboBox2.Text;
                DateTime ngay = dateTimePicker2.Value;
                string nd = this.textBox11.Text;
                string ht = this.textBox3.Text;


                PhucLoi phucloi = new PhucLoi(maPL, maNV, ngay, nd, ht);

                string b1 = dataGridView1.Rows[a].Cells[1].Value.ToString();
                string b2 = dataGridView1.Rows[a].Cells[2].Value.ToString();
                
                //kết quả
                
                DateTime b3 = DateTime.Parse(b2);

                try
                {
                    modify.update_pl(phucloi, b, b1, b3);
                }
                catch
                {
                    MessageBox.Show("Co du lieu khong the sua hoac du lieu khong hop le, vui long coi lai");
                }

                
                dataGridView1.DataSource = modify.getAllPhucLoi();
            }
            Xoa();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index; //dong bam
            string b = dataGridView1.Rows[a].Cells[0].Value.ToString();
            Delete delete = new Delete();
            if (comboBox1.Text == "Nhân Viên" || tabControl1.SelectedIndex == 0)
            {
                delete.Delete_nv(b);
                dataGridView1.DataSource = modify.getAllNhanVien();
                Fill();
            }
            if (comboBox1.Text == "Lương" || tabControl1.SelectedIndex == 1)
            {
                delete.Delete_l(b);
                dataGridView1.DataSource = modify.getAllLuong(); 
            }
            if (comboBox1.Text == "Phòng Ban" || tabControl1.SelectedIndex == 2)
            {
                delete.Delete_pb(b);
                dataGridView1.DataSource = modify.getAllPhongBan();
                Full();
            }
            if (comboBox1.Text == "Lịch Sử Làm Việc" || tabControl1.SelectedIndex == 3)
            {
                delete.Delete_lslv(b);
                dataGridView1.DataSource = modify.getAllLichSuLamViec();
            }
            if (comboBox1.Text == "Phúc Lợi" || tabControl1.SelectedIndex == 4)
            {
                string b1 = dataGridView1.Rows[a].Cells[1].Value.ToString();
                string b2 = dataGridView1.Rows[a].Cells[2].Value.ToString();
                DateTime b3 = DateTime.Parse(b2);

                delete.Delete_pl(b,b1,b3);
                dataGridView1.DataSource = modify.getAllPhucLoi();
            }

        }

        public void Fill()
        {
            SqlDataAdapter dataAdapter; /* Truy xuất data vào bảng */
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "select * from NhanVien";

            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            comboBox4.Items.Clear();
            while (myReader.Read())
            {
                
                string sMaNV=myReader.GetString(0);
                
                comboBox2.Items.Add(sMaNV);
                comboBox4.Items.Add(sMaNV);
                comboBox3.Items.Add(sMaNV);
            }
        }
        public void Full()
        {
            SqlDataAdapter dataAdapter; /* Truy xuất data vào bảng */
            SqlCommand sqlCommand;
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string getQuery = "select * from PhongBan";

            sqlConnection.Open();
            sqlCommand = new SqlCommand(getQuery, sqlConnection);
            SqlDataReader myReader;
            myReader = sqlCommand.ExecuteReader();
            comboBox6.Items.Clear();
            while (myReader.Read())
            {

                string sMaPB = myReader.GetString(0);
                comboBox6.Items.Add(sMaPB);
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {

        }
    }
}




                



           
        
    


