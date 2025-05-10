using DTO;
using LibraryManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAccount : Form
    {
        BindingSource accountList = new BindingSource();
        private DataGridViewCell previousCell;

        public fAccount()
        {
            InitializeComponent();

            dgvAccount.DataSource = accountList;

            DetachAccountBinding();

            LoadAccountProfile();
            LoadAccountList();
        }

        //Binding
        private void DetachAccountBinding()
        {
            inpAccName.DataBindings.Clear();
            inpAccEmail.DataBindings.Clear();
            numAccID.DataBindings.Clear();
            dtpAccNgaySinh.DataBindings.Clear();
            inpAccPass.DataBindings.Clear();
            rbtnNam.DataBindings.Clear();
            rbtnNu.DataBindings.Clear();
            inpAccPhone.DataBindings.Clear();
            cbAccRole.DataBindings.Clear();
            inpAccAddress.DataBindings.Clear();
        }

        private void AddAccountBinding()
        {
            inpAccName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "HoTen"));
            inpAccEmail.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email"));
            numAccID.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MaTaiKhoan"));
            dtpAccNgaySinh.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "NgaySinh"));
            inpAccPass.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "MatKhau"));
            var maleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            maleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value == "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNam.DataBindings.Add(maleBinding);

            var femaleBinding = new Binding("Checked", dgvAccount.DataSource, "GioiTinh");
            femaleBinding.Format += (s, args) =>
            {
                if (args.Value != DBNull.Value && (string)args.Value != "Nam")
                    args.Value = true;
                else
                    args.Value = false;
            };

            rbtnNu.DataBindings.Add(femaleBinding);
            inpAccPhone.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "SoDienThoai"));
            cbAccRole.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "VaiTro"));
            inpAccAddress.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DiaChi"));
        }
        // Tab1 

        private void LoadAccountProfile()
        {
            TaiKhoan tk = Session.loginAccount;

            lbMaTaiKhoan.Text = tk.MaTaiKhoan.ToString();
            lbHoTen.Text = tk.HoTen;
            lbNgaySinh.Text = tk.NgaySinh.ToShortDateString();
            lbGioiTinh.Text = tk.GioiTinh.ToString();
            lbEmail.Text = tk.Email;
            lbDiaChi.Text = tk.DiaChi;
            lbVaiTro.Text = tk.VaiTro;
            lbSoDienThoai.Text = tk.SoDienThoai;
        }

        // Tab2
        private void LoadAccountList()
        {
            accountList.DataSource = TaiKhoanDAO.Instance.LoadAccountList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DetachAccountBinding();

            LoadAccountList();

            numAccID.Value = 0;
            inpAccName.Clear();
            inpAccPass.Clear();
            inpAccEmail.Clear();
            dtpAccNgaySinh.Value = DateTime.Now;
            cbAccRole.SelectedItem = null;
            inpAccAddress.Clear();
            inpAccPhone.Clear();
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
        }

        private void dgvAccount_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (previousCell != null && e.RowIndex == previousCell.RowIndex)
            {
                numAccID.Value = 0;
                inpAccName.Clear();
                inpAccPass.Clear();
                inpAccEmail.Clear();
                dtpAccNgaySinh.Value = DateTime.Now;
                cbAccRole.SelectedItem = null;
                inpAccAddress.Clear();
                inpAccPhone.Clear();
                rbtnNam.Checked = false;
                rbtnNu.Checked = false;
            }
            else
            {
                DetachAccountBinding();
                AddAccountBinding();
                DetachAccountBinding();
            }
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }
            previousCell = dgvAccount.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();
                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.MatKhau = inpAccPass.Text;
                tk.Email = inpAccEmail.Text;
                tk.NgaySinh = dtpAccNgaySinh.Value;
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
                tk.DiaChi = inpAccAddress.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                else
                {
                    tk.GioiTinh = "Nữ";
                }

                tk.SoDienThoai = inpAccPhone.Text;

                TaiKhoanDAO.Instance.AddAccount(tk);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                DetachAccountBinding();
                int accID = (int)numAccID.Value;

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    TaiKhoanDAO.Instance.DeleteAccount(accID);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                DetachAccountBinding();

                TaiKhoan tk = new TaiKhoan();
                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.MatKhau = inpAccPass.Text;
                tk.Email = inpAccEmail.Text;
                tk.NgaySinh = dtpAccNgaySinh.Value;
                tk.VaiTro = cbAccRole.SelectedItem.ToString();
                tk.DiaChi = inpAccAddress.Text;
                tk.SoDienThoai = inpAccPhone.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                else
                {
                    tk.GioiTinh = "Nữ";
                }

                TaiKhoanDAO.Instance.UpdateAccount(tk);
                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*if (tk.MaTaiKhoan == Session.loginAccount.MaTaiKhoan)
                {
                    Session.loginAccount = tk;
                }*/

                LoadAccountList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật tài khoản thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindAcc_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan tk = new TaiKhoan();

                tk.MaTaiKhoan = (int)numAccID.Value;
                tk.HoTen = inpAccName.Text;
                tk.Email = inpAccEmail.Text;
                if (cbAccRole.SelectedItem != null)
                {
                    tk.VaiTro = cbAccRole.SelectedItem.ToString();
                }
                tk.DiaChi = inpAccAddress.Text;
                if (rbtnNam.Checked)
                {
                    tk.GioiTinh = "Nam";
                }
                if (rbtnNu.Checked)
                {
                    tk.GioiTinh = "Nữ";
                }

                tk.SoDienThoai = inpAccPhone.Text;


                accountList.DataSource = TaiKhoanDAO.Instance.FindAccountByAdvanced(tk);
            }
            catch
            {
                MessageBox.Show("Không có kết quả", "Find account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
