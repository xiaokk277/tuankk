using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ThucHanhLTHSK
{
    public partial class FormSinhVien : Form
    {
        private string connectionString = "Data Source=LAPTOP-GKNKPK1L\\SQLEXPRESS;" +
            "Initial Catalog=QUANLYGIANGDAY2;Integrated Security=True";
        private ErrorProvider errorProvider = new ErrorProvider();
        private DataTable dt_cbMaLopHC = new DataTable();
        private SqlConnection sqlConnection = new SqlConnection();
        private bool gioiTinh;
        private DataView dv_gridView = new DataView();
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            LoadData_cbMaLopHC();
            LoadDataToGridView();
        }
        private void tbMaSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaSV.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbMaSV, "Mã sinh viên không được phép để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbMaSV, null);
            }
        }
        private void tbMaSV_TextChanged(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length > 0)
            {
                btnThem.Enabled = true;
            }
            else
            {
                btnThem.Enabled = false;
            }
        }


        private void tbTenSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbTenSV.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(tbTenSV, "Họ tên sinh viên không được để trống");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbTenSV, null);
            }
        }

        private void tbSoDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (!isPhoneNumber(tbSoDienThoai.Text) /*&& tbSoDienThoai.Text.Length > 9 && tbSoDienThoai.Text.Length < 12*/)
            {
                e.Cancel = true;
                errorProvider.SetError(tbSoDienThoai, "Số điện thoại không đúng định dạng"); 
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tbSoDienThoai, null);
            }
        }
        private bool isPhoneNumber(string strValue)
        {
            foreach (char ch in strValue)
            {
                if (!Char.IsDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            tbMaSV.Text = tbSoDienThoai.Text = tbTenSV.Text = tbDiaChi.Text = string.Empty;
            dateTimePicker1.ResetText();
            tbMaSV.Focus();
        }

        private void LoadData_cbMaLopHC()
        {
            string querySelect = "SELECT_tblLopHC";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = querySelect;
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = command;
                            DataTable dataTable = dt_cbMaLopHC;
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                cbMaLopHC.DataSource = dt_cbMaLopHC;
                                cbMaLopHC.ValueMember = "sMaLop";
                                cbMaLopHC.DisplayMember = "sMaLop";
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại mã lớp hành chính nào");
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void tbSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (tbSoDienThoai.Text.Length < 10)
            {
                errorProvider.SetError(tbSoDienThoai, "Số điện thoại phải có trên 9 kí tự");
            }
            else
            {
                errorProvider.SetError(tbSoDienThoai, null);
            }
        }

        private void cbMaLopHC_Validating(object sender, CancelEventArgs e)
        {
            string maLopHC = cbMaLopHC.Text.ToUpper();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select_sMalop";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maLop", maLopHC);
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = command;
                        using (DataTable dataTable = new DataTable())
                        {
                            adapter.Fill(dataTable);
                            if (dataTable.Rows.Count > 0)
                            {
                                e.Cancel = false;
                                errorProvider.SetError(cbMaLopHC, null);
                            }
                            else
                            {
                                e.Cancel = true;
                                errorProvider.SetError(cbMaLopHC, "Mã lớp không tồn tại");
                            }
                        }
                    }
                }
            }
        }

        private void cbMaLopHC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbMaLopHC.SelectedIndex;
            string maLopHC = dt_cbMaLopHC.Rows[index]["sMalop"].ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "Select_sTenGV";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@malop", maLopHC);

                    connection.Open();
                    var a = command.ExecuteScalar();
                    connection.Close();
                    tbGiangVien.Text = a.ToString();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (rbtnNam.Checked == true)
            {
                gioiTinh = true;
            }
            else if (rbtnNu.Checked == true)
            {
                gioiTinh = false;
            }
            string idSV = tbMaSV.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "PROC_KiemTraKhoaChinh";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maSV", idSV);

                    connection.Open();
                    var idsv_sql = command.ExecuteScalar();
                    connection.Close();

                    if (idsv_sql == null)
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            command.CommandText = "Select_tblSinhVien";
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.Clear();
                            adapter.SelectCommand = command;
                            
                            using (DataTable dt_SINHVIEN = new DataTable("tblSinhVien"))
                            {
                                adapter.Fill(dt_SINHVIEN);
                                
                                // add từng datatable vào dataset
                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dt_SINHVIEN);
                                    // thêm mới bản ghi vào datatable
                                    DataRow newRow = dt_SINHVIEN.NewRow();
                                    newRow["sMaSV"] = tbMaSV.Text;
                                    newRow["sTenSV"] = tbTenSV.Text;
                                    newRow["dNgaySinh"] = dateTimePicker1.Value.ToString("yyyy/MM/d");
                                    newRow["sDiaChi"] = tbDiaChi.Text;
                                    newRow["sSDT"] = tbSoDienThoai.Text;
                                    newRow["sGioiTinh"] = gioiTinh;
                                    newRow["sLopHC"] = cbMaLopHC.Text;
                                    dt_SINHVIEN.Rows.Add(newRow);

                                    //thêm bản ghi vào CSDL bằng lệnh InsertCommand
                                    command.CommandText = "Insert_tblSINHVIEN";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.Add("@maSV", SqlDbType.VarChar, 50, "sMaSV").Value = tbMaSV.Text;
                                    command.Parameters.Add("@tenSV", SqlDbType.NVarChar, 100, "sTenSV").Value = tbTenSV.Text;
                                    command.Parameters.Add("@ngaySinh", SqlDbType.Date, 12, "dNgaySinh").Value = dateTimePicker1.Value.ToString("yyyy/MM/d");
                                    command.Parameters.Add("@diaChi", SqlDbType.NVarChar, 100, "sDiaChi").Value = tbDiaChi.Text;
                                    command.Parameters.Add("@sdt", SqlDbType.VarChar, 30, "sSDT").Value = tbSoDienThoai.Text;
                                    command.Parameters.Add("@gioiTinh", SqlDbType.Bit, 2, "sGioiTinh").Value = gioiTinh;
                                    command.Parameters.Add("@lopHC", SqlDbType.VarChar, 50, "sLopHC").Value = cbMaLopHC.Text;
                                    adapter.InsertCommand = command;
                                    adapter.Update(dataSet, "tblSINHVIEN");
                                    MessageBox.Show("Them moi thanh cong");

                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ma sinh vien " + idSV + " da ton tai");
                        return;
                    }

                }
            }
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_tblSinhVien";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            using (DataTable dt_gridView = new DataTable())
                            {
                                adapter.SelectCommand = command;
                                adapter.Fill(dt_gridView);
                                if (dt_gridView.Rows.Count > 0)
                                {
                                    dv_gridView = dt_gridView.DefaultView;
                                    dgvSinhVien.AutoGenerateColumns = false;
                                    dgvSinhVien.DataSource = dt_gridView;

                                    if (!string.IsNullOrEmpty(filter))
                                    {
                                        dv_gridView.RowFilter = filter;
                                    }

                                    dgvSinhVien.DataSource = dv_gridView;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai du lieu!");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvSinhVien.CurrentRow.Index;
            tbMaSV.Text = dv_gridView[index]["sMaSV"].ToString();
            tbMaSV.ReadOnly = true;
            tbTenSV.Text = dv_gridView[index]["sTenSV"].ToString();
            tbSoDienThoai.Text = dv_gridView[index]["sSDT"].ToString();
            tbDiaChi.Text = dv_gridView[index]["sDiaChi"].ToString();
            dateTimePicker1.Text = dv_gridView[index]["dNgaySinh"].ToString();
            if (dv_gridView[index]["sGioiTinh"] == "Nam")
            {
                rbtnNam.Checked = true;
            }
            else if (dv_gridView[index]["sGioiTinh"] == "Nữ")
            {
                rbtnNu.Checked = true;
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (rbtnNam.Checked == true)
            {
                gioiTinh = true;
            }
            else
            {
                gioiTinh = false;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "Select_tblSinhVien";
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            using (DataTable dtSINHVIEN = new DataTable("tblSinhVien"))
                            {
                                adapter.Fill(dtSINHVIEN);

                                using (DataSet dataSet = new DataSet())
                                {
                                    dataSet.Tables.Add(dtSINHVIEN);
                                    dtSINHVIEN.PrimaryKey = new DataColumn[] { dtSINHVIEN.Columns["sMaSV"] };
                                    DataRow row = dtSINHVIEN.Rows.Find(tbMaSV.Text);
                                    row["sTenSV"] = tbTenSV.Text;
                                    row["dNgaySinh"] = dateTimePicker1.Value.ToString("yyyy/MM/d");
                                    row["sDiaChi"] = tbDiaChi.Text;
                                    row["sSDT"] = tbSoDienThoai.Text;
                                    row["sGioiTinh"] = gioiTinh;
                                    row["sLopHC"] = cbMaLopHC.Text;

                                    //thực hiện UpdateCommand

                                    command.CommandText = "Update_tblSINHVIEN";
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.Clear();
                                    command.Parameters.Add("@maSV", SqlDbType.VarChar, 30, "sMaSV").Value = tbMaSV.Text;
                                    command.Parameters.AddWithValue("@tenSV", tbTenSV.Text);
                                    command.Parameters.AddWithValue("@ngaySinh", dateTimePicker1.Value.ToString("yyyy/MM/d"));
                                    command.Parameters.AddWithValue("@diaChi", tbDiaChi.Text);
                                    command.Parameters.AddWithValue("@sdt", tbSoDienThoai.Text);
                                    command.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                                    command.Parameters.AddWithValue("@maLop", cbMaLopHC.Text);
                                    adapter.UpdateCommand = command;
                                    adapter.Update(dataSet, "tblSinhVien");
                                    MessageBox.Show("Cap nhat thanh cong");
                                    LoadDataToGridView();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Da co loi xay ra" + ex);
            }
        }

        private void btnXoaBo_Click(object sender, EventArgs e)
        {
            int index = dgvSinhVien.CurrentRow.Index;
            string maSV = dv_gridView[index]["sMaSV"].ToString();
            try
            {
                DialogResult dialog_delete = MessageBox.Show("Co muon xoa ma sinh vien " + maSV + " that khong?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog_delete == DialogResult.Yes)
                {
                    /*KiemTraRangBuoc_tblDIEM(maSV);*/
                    string deleteQuery = "Delete_tblSINHVIEN";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = new SqlCommand("SELECT * FROM tblSinhVien", sqlConnection);
                            DataTable dt_tblSinhVien = new DataTable("tblSinhVien");
                            adapter.Fill(dt_tblSinhVien);
                            DataSet ds = new DataSet();
                            ds.Tables.Add(dt_tblSinhVien);
                            dt_tblSinhVien.PrimaryKey = new DataColumn[] { dt_tblSinhVien.Columns["sMaSV"] };
                            DataRow dataRow = dt_tblSinhVien.Rows.Find(maSV);
                            dataRow.Delete();
                            using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                            {
                                sqlCommand.CommandText = deleteQuery;
                                sqlCommand.CommandType = CommandType.StoredProcedure;
                                sqlCommand.Parameters.AddWithValue("@maSV", maSV);

                                adapter.DeleteCommand = sqlCommand;
                                adapter.Update(ds, "tblSinhVien");
                            }
                        }
                    }
                    LoadDataToGridView();
                }
                else
                {
                    return;
                }
            }
            catch (SqlException sql)
            {
                string errorSql = sql.Message;
                if (errorSql.Contains("40"))
                {
                    MessageBox.Show("Sql server bị ngắt kết nối");
                }
            }
            catch (Exception ex)
            {
                string errorStr = ex.Message;
                if ((ex is SqlException) && errorStr.Contains("40"))
                {
                    MessageBox.Show("Đã có lỗi ở Sql server");
                }
                else if (errorStr.Contains("FK_tblDIEM_sMaSV"))
                {
                    MessageBox.Show("Ràng buộc: Mã sinh viên " + maSV +
                            " có phát sinh điểm, không xoá được!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void KiemTraRangBuoc_tblDIEM(string masv)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "KiemTraMaSV_tblHoc";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@maSV", masv);

                    connection.Open();

                    bool exist = (command.ExecuteScalar() != null);
                    connection.Close();
                    if (exist)
                    {
                        throw new Exception("Ràng buộc: Mã sinh viên" + masv + " có phát sinh điểm, không xóa được!");
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaSV IS NOT NULL";
            if (!string.IsNullOrEmpty(tbMaSV.Text))
            {
                filter += string.Format(" AND sMaSV LIKE '%{0}%' ", tbMaSV.Text);
            }
            if (!string.IsNullOrEmpty(tbTenSV.Text))
            {
                filter += string.Format(" AND sHoTen LIKE '%{0}%' ", tbTenSV.Text);
            }
            if (!string.IsNullOrEmpty(tbSoDienThoai.Text))
            {
                filter += string.Format(" AND sSDT LIKE '%{0}%' ", tbSoDienThoai.Text);
            }
            if (!string.IsNullOrEmpty(tbDiaChi.Text))
            {
                filter += string.Format (" AND sDiaChi LIKE '%{0}%' ", tbDiaChi.Text);
            }
            /*            if (!string.IsNullOrEmpty(dateTimePicker1.Text))
                        {
                            filter += string.Format(" AND dNgaySinh LIKE '%{0}%' ", dateTimePicker1.Text);
                        }*/
            LoadDataToGridView(filter);
        }
    }
}
