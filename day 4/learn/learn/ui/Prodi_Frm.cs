using learn.service;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace learn.ui
{
    public partial class Prodi_Frm : Form
    {
        Prodi prodi = new Prodi();
        Jurusan jurusan = new Jurusan();

        public Prodi_Frm()
        {
            InitializeComponent();
        }
    

        private void Prodi_Load(object sender, EventArgs e)
        {
            ProdiGrid.DataSource =prodi.getAllWithJurusan();
            id_jurusan_text.DataSource = prodi.getComboJurusan();
            id_jurusan_text.DisplayMember = "nama_jurusan"; // Atur properti yang akan ditampilkan
            id_jurusan_text.ValueMember = "id_jurusan"; // Atur properti yang akan menjadi nilai



            // Mengatur sumber data grid dengan data Prodi

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_jurusan_text.DisplayMember = "nama_prodi"; // Atur properti yang akan ditampilkan
            id_jurusan_text.ValueMember = "id_prodi"; // Atur properti yang akan menjadi nilai


            id_jurusan_text.DataSource = prodi.getAll();

            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!prodi.isExist(id_prodi_text.Text))
            {
                string idJurusan = id_jurusan_text.SelectedValue.ToString();

                // Set nilai prodi.IdJurusan
                prodi.IdJurusan = idJurusan;
                prodi.NamaProdi = nama_prodi_text.Text;
                prodi.IdProdi = id_prodi_text.Text;

                if (prodi.addData() > -1)
                {
                    MessageBox.Show("Data Berhasil Disimpan.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id_prodi_text.Focus();
                    id_jurusan_text.SelectedIndex = -1;
                    id_prodi_text.Clear();
                    ProdiGrid.DataSource = prodi.getAllWithJurusan();


                }
                else
                {
                    MessageBox.Show("Gagal disimpann.", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    id_prodi_text.Focus();
                }
            }

        }

        private void ProdiGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow baris = this.ProdiGrid.Rows[e.RowIndex];
                id_prodi_text.Text = baris.Cells[0].Value.ToString();
                nama_prodi_text.Text = baris.Cells[2].Value.ToString();
                string idJurusan = baris.Cells[3].Value?.ToString();
                int index = id_jurusan_text.FindStringExact(idJurusan);

                // Pilih item di ComboBox berdasarkan indeks
                if (index != -1)
                {
                    id_jurusan_text.SelectedIndex = index;
                }
                else
                {
                    // Jika nilai idJurusan tidak ditemukan di ComboBox
                    MessageBox.Show("Nilai id jurusan tidak ditemukan di ComboBox.");
                }

                // Set nilai id_jurusan_text
                id_jurusan_text.Text = baris.Cells[3].Value?.ToString();

                // Cari indeks yang sesuai dengan nilai idJurusan di ComboBox


            }
        }
    }
}
