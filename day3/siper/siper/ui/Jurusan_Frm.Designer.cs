namespace siper.ui
{
    partial class Jurusan_Frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.id_jurusan_text = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.nama_jurusan_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.jurusan_grid = new System.Windows.Forms.DataGridView();
            this.id_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // id_jurusan_text
            // 
            this.id_jurusan_text.Location = new System.Drawing.Point(210, 74);
            this.id_jurusan_text.Name = "id_jurusan_text";
            this.id_jurusan_text.Size = new System.Drawing.Size(85, 22);
            this.id_jurusan_text.TabIndex = 0;
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(135, 158);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(129, 36);
            this.simpan_btn.TabIndex = 1;
            this.simpan_btn.Text = "simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // nama_jurusan_txt
            // 
            this.nama_jurusan_txt.Location = new System.Drawing.Point(210, 107);
            this.nama_jurusan_txt.Name = "nama_jurusan_txt";
            this.nama_jurusan_txt.Size = new System.Drawing.Size(200, 22);
            this.nama_jurusan_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID.JURUSAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NAMA JURUSAN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "tutup";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(281, 158);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(129, 36);
            this.hapus_btn.TabIndex = 7;
            this.hapus_btn.Text = "hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // jurusan_grid
            // 
            this.jurusan_grid.AllowUserToAddRows = false;
            this.jurusan_grid.AllowUserToDeleteRows = false;
            this.jurusan_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusan_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_jurusan,
            this.nama_jurusan});
            this.jurusan_grid.Location = new System.Drawing.Point(171, 285);
            this.jurusan_grid.Name = "jurusan_grid";
            this.jurusan_grid.ReadOnly = true;
            this.jurusan_grid.RowHeadersWidth = 51;
            this.jurusan_grid.RowTemplate.Height = 24;
            this.jurusan_grid.Size = new System.Drawing.Size(453, 299);
            this.jurusan_grid.TabIndex = 8;
            this.jurusan_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_grid_CellClick);
            // 
            // id_jurusan
            // 
            this.id_jurusan.DataPropertyName = "id_jurusan";
            this.id_jurusan.HeaderText = "id_jurusan";
            this.id_jurusan.MinimumWidth = 6;
            this.id_jurusan.Name = "id_jurusan";
            this.id_jurusan.ReadOnly = true;
            this.id_jurusan.Width = 200;
            // 
            // nama_jurusan
            // 
            this.nama_jurusan.DataPropertyName = "nama_jurusan";
            this.nama_jurusan.HeaderText = "nama_jurusan";
            this.nama_jurusan.MinimumWidth = 6;
            this.nama_jurusan.Name = "nama_jurusan";
            this.nama_jurusan.ReadOnly = true;
            this.nama_jurusan.Width = 200;
            // 
            // Jurusan_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.jurusan_grid);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama_jurusan_txt);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.id_jurusan_text);
            this.Name = "Jurusan_Frm";
            this.Text = "Jurusan_Frm";
            this.Load += new System.EventHandler(this.Jurusan_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_jurusan_text;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox nama_jurusan_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.DataGridView jurusan_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_jurusan;
    }
}