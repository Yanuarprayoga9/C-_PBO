using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siper.ui
{
    using service;
    public partial class Jurusan_Frm : Form
    {
        JurusanCls jurusan = new JurusanCls();
        public Jurusan_Frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(jurusan.apakahAda(id_jurusan_text.Text)){
                MessageBox.Show("sudah ada");
            }
            else
            {
                MessageBox.Show("belum ada");
            }
        }

       
        private void simpan_btn_Click(object sender, EventArgs e)
        {

            if (!jurusan.apakahAda(id_jurusan_text.Text))
            {
                jurusan.Id_Jurusan = id_jurusan_text.Text;
                jurusan.Nama_Jurusan = nama_jurusan_txt.Text;
                if (jurusan.addData() > -1)
                {
                    MessageBox.Show("Data Berhasil Disimpan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id_jurusan_text.Focus();
                    id_jurusan_text.Clear();
                    nama_jurusan_txt.Clear();
                }
                else
                {
                    MessageBox.Show("Gagal disimpan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id_jurusan_text.Focus();
                }
            }
            else
            {
                if (MessageBox.Show("Data sudah ada. Apakah ingin mengubah data?",
                       "KONFIRMASI",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (jurusan.updateData(id_jurusan_text.Text) > -1)
                    {
                        MessageBox.Show("Data Berhasil Diubah.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_jurusan_text.Focus();
                        id_jurusan_text.Clear();
                        nama_jurusan_txt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Gagal Diubah.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        id_jurusan_text.Focus();
                    }
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {

            if (jurusan.apakahAda(id_jurusan_text.Text))
            {
                if (MessageBox.Show("Yakin akan mengapus data?",
                      "KONFIRMASI",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(jurusan.deleteData(id_jurusan_text.Text) > 0)
                    {
                        MessageBox.Show("Data Berhasil dihapus.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        id_jurusan_text.Focus();
                        id_jurusan_text.Clear();
                        nama_jurusan_txt.Clear();
                    }else
                    {
                        MessageBox.Show("Data gagal dihapus.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            else
            {
                MessageBox.Show("Data tidak ditemukan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void viewGrid()
        {
            jurusan_grid.DataSource = jurusan.getAll();
        }

        private void Jurusan_Frm_Load(object sender, EventArgs e)
        {
            viewGrid();
        }

        private void jurusan_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
            DataGridViewRow baris = this.jurusan_grid.Rows[e.RowIndex];
            id_jurusan_text.Text = baris.Cells[0].Value.ToString();
            nama_jurusan_txt.Text = baris.Cells[1].Value.ToString();

            }
        }
    }
}
