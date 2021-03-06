﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlynhansu_hahaha.DAO;
namespace quanlynhansu_hahaha.GUI
{
    public partial class Frmngoaingu : Form
    {
        private QuanLyNhanSuDbContext db = DBService.db;
        private int index = 0, index1 = 0;

        private void Frmngoaingu_Load(object sender, EventArgs e)
        {
            txtghichu.Enabled = false;
            txtten.Enabled = false;
            Loadthongtin();
        }

        public Frmngoaingu()
        {
            InitializeComponent();
        }
        private NGOAINGU getnhanvienByForm()
        {
            NGOAINGU ans = new NGOAINGU();
            ans.TEN = txtten.Text;
            ans.GHICHU = txtghichu.Text;


            return ans;
        }
        private void Loadthongtin()
        {
            int i = 0;
            string keyword = txtTimKiem.Text;
            var dbNV = db.NGOAINGUs.ToList()
                       .Select(p => new
                       {

                           STT = ++i,
                           ID = p.ID,
                           Ten = p.TEN,
                           Ghichu = p.GHICHU,

                       }).ToList()

                       ;

            dgvthongtin.DataSource = dbNV.Where(p => p.Ten.Contains(keyword)).ToList();

            // cập nhật index 
            index = index1;
            try
            {
                dgvthongtin.Rows[index].Cells["STT"].Selected = true;
                dgvthongtin.Select();
            }
            catch { }
        }
        private void ClearControl()
        {
            try
            {
                txtten.Text = "";
                txtghichu.Text = "";

            }
            catch { }
        }
        private void UpdateDetail()
        {
            ClearControl();
            try
            {
                NGOAINGU tg = getnhanvienByID();

                if (tg == null || tg.ID == 0) return;

                // cập nhật trên giao diện
                txtten.Text = tg.TEN;
                txtghichu.Text = tg.GHICHU;
                index1 = index;
                index = dgvthongtin.SelectedRows[0].Index;
            }
            catch { }

        }
        private NGOAINGU getnhanvienByID()
        {
            try
            {
                int id = (int)dgvthongtin.SelectedRows[0].Cells["ID"].Value;
                NGOAINGU x = db.NGOAINGUs.Where(p => p.ID == id).FirstOrDefault();
                return (x != null) ? x : new NGOAINGU();
            }
            catch
            {
                return new NGOAINGU();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";

                group.Enabled = true;
                dgvthongtin.Enabled = false;
                txtghichu.Enabled = true; ;
                txtten.Enabled = true;
                btntimkiem.Enabled = false;
                txtTimKiem.Enabled = false;

                ClearControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {

                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Text = "Xóa";

                    group.Enabled = false;
                    txtghichu.Enabled = false;
                    txtten.Enabled = false;
                    txtghichu.Enabled = false;
                    txtten.Enabled = false;
                    dgvthongtin.Enabled = true;

                    btntimkiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    try
                    {
                        NGOAINGU tg = getnhanvienByForm();
                        db.NGOAINGUs.Add(tg);
                        db.SaveChanges();



                        MessageBox.Show("Thêm  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm  thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    Loadthongtin();
                }

                return;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NGOAINGU tg = getnhanvienByID();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có thông tin  nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {

                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                group.Enabled = true;
                txtghichu.Enabled = true;
                txtten.Enabled = true;
                txtghichu.Enabled = true;
                txtten.Enabled = true;
                dgvthongtin.Enabled = false;

                btntimkiem.Enabled = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    group.Enabled = false;
                    txtten.Enabled = false;
                    txtghichu.Enabled = false;
                    dgvthongtin.Enabled = true;

                    btntimkiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    NGOAINGU tgs = getnhanvienByForm();
                    tg.TEN = tgs.TEN;
                    tg.GHICHU = tgs.GHICHU;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Sửa thông tin  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thông tin  thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Loadthongtin();
                }

                return;
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                NGOAINGU tg = getnhanvienByID();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có đầu  nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa thông tin đầu  này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                try
                {


                    db.NGOAINGUs.Remove(tg);
                    db.SaveChanges();


                    MessageBox.Show("Xóa thông tin đầu  thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Xóa thông tin đầu  thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Loadthongtin();
                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                group.Enabled = false;
                txtghichu.Enabled = false;
                txtghichu.Enabled = false;
                dgvthongtin.Enabled = true;

                btntimkiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            Loadthongtin();
        }

        private void dgvthongtin_LocationChanged(object sender, EventArgs e)
        {
            UpdateDetail();
        }

        private bool Check()
        {
            if (txtten.Text == "")
            {
                MessageBox.Show("Tên không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int cnt = db.NGOAINGUs.Where(p => p.TEN == txtten.Text).ToList().Count;
            if (cnt > 0)
            {
                bool ok = false;
                if (btnSua.Text == "Lưu")
                {
                    // Nếu là sửa
                    NGOAINGU tg = getnhanvienByID();
                    if (tg.TEN == txtten.Text) ok = true;
                }

                if (!ok)
                {
                    MessageBox.Show("Tên đã được sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (txtghichu.Text == "")
            {
                MessageBox.Show("Ghi chú không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }




            return true;

        }
        #region

        #endregion
    }
}
