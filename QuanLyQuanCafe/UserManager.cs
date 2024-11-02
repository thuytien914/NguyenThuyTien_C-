using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class UserManager : Form
    {
        private string strCon = @"Data Source=DESKTOP-L3BED2A\SQLEXPRESS;Initial Catalog=QLCF;Integrated Security=True;Encrypt=False";
        private SqlConnection sqlCon;


        public List<Manager> lstMana = new List<Manager>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler Thoat;

        private string managerImagePath = string.Empty;
        public UserManager()
        {
            InitializeComponent();
            SetupImageList();
            InitializeDateTimePicker();

        }

        private void InitializeDateTimePicker()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; // Hiển thị dưới dạng số
            dateTimePicker1.ShowUpDown = false; // Hiển thị lịch để người dùng có thể chọn
            dateTimePicker1.Value = DateTime.Now.AddYears(-18); // Đặt ngày mặc định lớn hơn 18 tuổi
        }
        private void SetupDataGridView()
        {
            dgvManager.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManager.Columns[0].HeaderText = "Mã";
            dgvManager.Columns[1].HeaderText = "Tên";
            dgvManager.Columns[2].HeaderText = "Số Điện Thoại";
            dgvManager.Columns[3].HeaderText = "Địa Chỉ";
            dgvManager.Columns[4].HeaderText = "Ngày Sinh";
            dgvManager.Columns[5].HeaderText = "Giới Tính";
            dgvManager.Columns[6].HeaderText = "Ảnh";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(tbID.Text, out int newId))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
                    return;
                }

                if (lstMana.Any(emp => emp.Id == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên nhân viên.");
                    return;
                }
                if (dateTimePicker1.Value > DateTime.Now.AddYears(-18))
                {
                    MessageBox.Show("Lỗi: Nhân viên phải lớn hơn 18 tuổi.");
                    return;
                }
                var newEmp = new Manager
                {
                    Id = newId,
                    Name = tbName.Text,
                    PhoneNumber = tbNumber.Text,
                    Address = tbAddress.Text,
                    Gender = ckGender.Checked,
                    BirthDate = dateTimePicker1.Value.Date,
                    ImagePath = managerImagePath
                    
                };

                lstMana.Add(newEmp);
                AddManager(newEmp); // Gọi hàm thêm vào cơ sở dữ liệu
                RefreshBindings();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            lstMana = GetData();
            bs.DataSource = lstMana;
            dgvManager.DataSource = bs;
            SetupDataGridView();
            dgvManager.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void RefreshBindings()
        {
            bs.DataSource = lstMana.ToList();
            bs.ResetBindings(false);
            dgvManager.ClearSelection(); // Optional: Clear selection for better UX
        }
        private void ClearInputFields()
        {
            tbID.Clear();
            tbName.Clear();
            tbNumber.Clear();
            tbAddress.Clear();
            ckGender.Checked = false;
            pbManagerImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;

            tbID.Enabled = true;
        }

        public List<Manager> GetData()
        {
            List<Manager> managers = new List<Manager>();

            using (sqlCon = new SqlConnection(strCon)) // Sử dụng từ khóa using để quản lý tài nguyên
            {
                sqlCon.Open(); // Mở kết nối

                // Câu truy vấn để lấy dữ liệu
                string query = "SELECT Id, Name, PhoneNumber, Address, BirthDate, Gender, ImagePath FROM NVCF";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon)) // Tạo SqlCommand
                {
                    using (SqlDataReader reader = cmd.ExecuteReader()) // Sử dụng using cho SqlDataReader
                    {
                        while (reader.Read()) // Đọc dữ liệu
                        {
                            Manager emp = new Manager
                            {
                                Id = reader.GetInt32(0), // Mã
                                Name = reader.GetString(1), // Tên
                                PhoneNumber = reader.GetString(2), // Số điện thoại
                                Address = reader.GetString(3), // Địa chỉ
                                BirthDate = reader.GetDateTime(4), // Ngày sinh
                                Gender = reader.GetBoolean(5), // Giới tính
                                ImagePath = reader.IsDBNull(6) ? null : reader.GetString(6) // Ảnh
                            };
                            managers.Add(emp); // Thêm vào danh sách
                        }
                    }
                }
            }
            return managers; // Trả về danh sách nhân viên
        }
        private void AddManager(Manager newEmp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "INSERT INTO NVCF (Id, Name, PhoneNumber, Address, BirthDate, Gender, ImagePath) VALUES (@Id, @Name, @PhoneNumber, @Address, @BirthDate, @Gender, @ImagePath)";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", newEmp.Id);
                    cmd.Parameters.AddWithValue("@Name", newEmp.Name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", newEmp.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", newEmp.Address);
                    cmd.Parameters.AddWithValue("@BirthDate", newEmp.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", newEmp.Gender);
                    cmd.Parameters.AddWithValue("@ImagePath", newEmp.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateManager(Manager emp)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "UPDATE NVCF SET Name=@Name, BirthDate=@BirthDate, Gender=@Gender, Address=@Address, ImagePath=@ImagePath WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", emp.Id);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@PhoneNumber", emp.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", emp.Address);
                    cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                    cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                    cmd.Parameters.AddWithValue("@ImagePath", emp.ImagePath);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void DeleteManager(int empId)
        {
            using (sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                string query = "DELETE FROM NVCF WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", empId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Cập nhật trong phương thức dgvManager_RowEnter
        //private void dgvManager_RowEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //if (e.RowIndex < 0 || e.RowIndex >= lstMana.Count) return;

        //Manager em = lstMana[e.RowIndex];

        //tbID.Text = em.Id.ToString();
        //tbName.Text = em.Name;
        //tbAddress.Text = em.Address;
        //ckGender.Checked = em.Gender;
        //tbID.Enabled = false;

        //if (!string.IsNullOrEmpty(em.ImagePath) && System.IO.File.Exists(em.ImagePath))
        //{
        //pbManagerImage.Image = Image.FromFile(em.ImagePath);
        //}
        //else
        //{
        //pbManagerImage.Image = null; // Clear image if not available
        //}

        //}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvManager.CurrentRow == null) return;

            int idx = dgvManager.CurrentRow.Index;
            var empId = lstMana[idx].Id;


            lstMana.RemoveAt(idx);
            DeleteManager(empId); // Gọi hàm xóa khỏi cơ sở dữ liệu
            RefreshBindings();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvManager.CurrentRow == null) return;

            var idx = dgvManager.CurrentRow.Index;
            var emp = lstMana[idx];

            try
            {
                int newId = int.Parse(tbID.Text);

                // Kiểm tra xem ID mới đã tồn tại trong danh sách nhưng không phải của nhân viên hiện tại
                if (lstMana.Any(manager => manager.Id == newId && manager != emp))
                {
                    MessageBox.Show("Lỗi: ID này đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                // Kiểm tra tuổi
                if (dateTimePicker1.Value > DateTime.Now.AddYears(-18))
                {
                    MessageBox.Show("Lỗi: Nhân viên phải lớn hơn 18 tuổi.");
                    return;
                }

                // Cập nhật thông tin nhân viên
                emp.Id = newId;
                emp.Name = tbName.Text;
                emp.PhoneNumber = tbNumber.Text;
                emp.Address = tbAddress.Text;
                emp.Gender = ckGender.Checked;
                emp.BirthDate = dateTimePicker1.Value.Date;
                emp.ImagePath = managerImagePath;
                

                UpdateManager(emp); // Gọi hàm cập nhật vào cơ sở dữ liệu
                RefreshBindings(); // Cập nhật dữ liệu hiển thị trên DataGridView
                ClearInputFields(); // Xóa các ô nhập liệu
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Thoat?.Invoke(this, EventArgs.Empty);
        }

        private void tbNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Chỉ được nhập kí tự số");
                e.Handled = true;
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    managerImagePath = ofd.FileName;
                    pbManagerImage.Image = Image.FromFile(managerImagePath);
                }
            }
        }
        private void SetupImageList()
        {
            var imageList = new ImageList { ImageSize = new Size(24, 24) };

            try
            {
                imageList.Images.Add(Image.FromFile("Images/add.png"));
                imageList.Images.Add(Image.FromFile("Images/edit.png"));
                imageList.Images.Add(Image.FromFile("Images/delete.png"));

                btnThem.ImageList = imageList; btnThem.ImageIndex = 0;
                btnSua.ImageList = imageList; btnSua.ImageIndex = 1;
                btnXoa.ImageList = imageList; btnXoa.ImageIndex = 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }

        private void dgvManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstMana.Count) return;

            var emp = lstMana[e.RowIndex];

            tbID.Text = emp.Id.ToString();
            tbName.Text = emp.Name;
            tbNumber.Text = emp.PhoneNumber;
            tbAddress.Text = emp.Address;
            ckGender.Checked = emp.Gender;
            if (emp.BirthDate != null && emp.BirthDate >= dateTimePicker1.MinDate && emp.BirthDate <= dateTimePicker1.MaxDate)
            {
                dateTimePicker1.Value = emp.BirthDate;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now; // Default to current date
            }


            if (File.Exists(emp.ImagePath))
            {
                pbManagerImage.Image = Image.FromFile(emp.ImagePath);
            }
            else
            {
                pbManagerImage.Image = null;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtTimKiem.Text.ToLower();
            bs.DataSource = lstMana.Where(emp => emp.Name.ToLower().Contains(searchValue) ||
                                                emp.Id.ToString().Contains(searchValue)).ToList();
        }
    }
}