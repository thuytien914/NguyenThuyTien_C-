using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCafe
{
    public partial class UserManager : Form
    {
        public List<Manager> lstMana = new List<Manager>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler Thoat;

        private string managerImagePath = string.Empty;
        public UserManager()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy"; 
            dateTimePicker1.ShowUpDown = false; 
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        public List<Manager> GetData()
        {

            return lstMana;
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
                tbID.Enabled = true;

                if (string.IsNullOrWhiteSpace(tbID.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập ID hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbNumber.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập số điện thoại hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbAddress.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập địa chỉ hợp lệ.");
                    return;
                }

                if (string.IsNullOrEmpty(managerImagePath))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn một ảnh.");
                    return;
                }

                if (dateTimePicker1.Value == null)
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn ngày sinh hợp lệ.");
                    return;
                }

                int newId = int.Parse(tbID.Text);
                if (lstMana.Any(emp => emp.Id == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                Manager newEmp = new Manager
                {
                    Id = newId,
                    Name = tbName.Text,
                    Gender = ckGender.Checked,
                    Address = tbAddress.Text,
                    PhoneNumber = tbNumber.Text,
                    ImagePath = managerImagePath,
                    BirthDate = dateTimePicker1.Value.Date
                };

                lstMana.Add(newEmp);
                bs.ResetBindings(false);
                ClearInputFields();

                tbID.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            lstMana = GetData();
            bs.DataSource = lstMana;
            dgvManager.DataSource = bs;
            SetupDataGridView();
            dateTimePicker1.Value = DateTime.Now;

            dgvManager.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ClearInputFields()
        {
            tbID.Text = "";
            tbName.Text = "";
            tbNumber.Text = "";
            tbAddress.Text = "";
            ckGender.Checked = false;
            pbManagerImage.Image = null;
            dateTimePicker1.Value = DateTime.Now;

            tbID.Enabled = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            this.Text = dateTimePicker1.Value.ToString("dd MMMM yyyy");
        }
        private void SetDateForDateTimePicker(DateTime date)
        {
            dateTimePicker1.Value = date;
        }

        private void dgvManager_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstMana.Count) return;

            Manager em = lstMana[e.RowIndex];

            tbID.Text = em.Id.ToString();
            tbName.Text = em.Name;
            tbAddress.Text = em.Address;
            tbNumber.Text = em.PhoneNumber;
            ckGender.Checked = em.Gender;

            tbID.Enabled = false;

            if (!string.IsNullOrEmpty(em.ImagePath) && System.IO.File.Exists(em.ImagePath))
            {
                pbManagerImage.Image = Image.FromFile(em.ImagePath);
            }
            else
            {
                pbManagerImage.Image = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvManager.CurrentRow == null) return;

            int idx = dgvManager.CurrentRow.Index;
            lstMana.RemoveAt(idx);
            bs.ResetBindings(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvManager.CurrentRow == null) return;

            int idx = dgvManager.CurrentRow.Index;
            Manager em = lstMana[idx];

            try
            {

                if (string.IsNullOrWhiteSpace(tbID.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập ID hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbNumber.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập số điện thoại hợp lệ.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbAddress.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập địa chỉ hợp lệ.");
                    return;
                }

                int newId = int.Parse(tbID.Text);
                if (lstMana.Any(emp => emp.Id == newId && emp != em))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }

                em.Id = newId;
                em.Name = tbName.Text;
                em.PhoneNumber = tbNumber.Text;
                em.Address = tbAddress.Text;
                em.Gender = ckGender.Checked;
                em.ImagePath = managerImagePath;
                em.BirthDate = dateTimePicker1.Value.Date;

                bs.ResetBindings(false);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
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
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);

            imageList.Images.Add(Image.FromFile("Images/add.png"));
            imageList.Images.Add(Image.FromFile("Images/edit.png"));
            imageList.Images.Add(Image.FromFile("Images/delete.png"));

            btnThem.ImageList = imageList;
            btnThem.ImageIndex = 0;

            btnSua.ImageList = imageList;
            btnSua.ImageIndex = 1;

            btnXoa.ImageList = imageList;
            btnXoa.ImageIndex = 2;
        }
    }
}