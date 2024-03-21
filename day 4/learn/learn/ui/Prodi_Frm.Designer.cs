namespace learn.ui
{
    partial class Prodi_Frm
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
            this.ProdiGrid = new System.Windows.Forms.DataGridView();
            this.id_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_prodi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_jurusan_text = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.hskasa = new System.Windows.Forms.Label();
            this.nama_prodi_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_prodi_text = new System.Windows.Forms.TextBox();
            this.id_p = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProdiGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdiGrid
            // 
            this.ProdiGrid.AllowUserToAddRows = false;
            this.ProdiGrid.AllowUserToDeleteRows = false;
            this.ProdiGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdiGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_prodi,
            this.nama_jurusan,
            this.nama_prodi});
            this.ProdiGrid.Location = new System.Drawing.Point(141, 303);
            this.ProdiGrid.Name = "ProdiGrid";
            this.ProdiGrid.ReadOnly = true;
            this.ProdiGrid.RowHeadersWidth = 51;
            this.ProdiGrid.RowTemplate.Height = 24;
            this.ProdiGrid.Size = new System.Drawing.Size(429, 150);
            this.ProdiGrid.TabIndex = 0;
            this.ProdiGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdiGrid_CellClick);
            // 
            // id_prodi
            // 
            this.id_prodi.DataPropertyName = "id_prodi";
            this.id_prodi.HeaderText = "id_prodi";
            this.id_prodi.MinimumWidth = 6;
            this.id_prodi.Name = "id_prodi";
            this.id_prodi.ReadOnly = true;
            this.id_prodi.Width = 125;
            // 
            // nama_jurusan
            // 
            this.nama_jurusan.DataPropertyName = "nama_jurusan";
            this.nama_jurusan.HeaderText = "nama_jurusan";
            this.nama_jurusan.MinimumWidth = 6;
            this.nama_jurusan.Name = "nama_jurusan";
            this.nama_jurusan.ReadOnly = true;
            this.nama_jurusan.Width = 125;
            // 
            // nama_prodi
            // 
            this.nama_prodi.DataPropertyName = "nama_prodi";
            this.nama_prodi.HeaderText = "nama_prodi";
            this.nama_prodi.MinimumWidth = 6;
            this.nama_prodi.Name = "nama_prodi";
            this.nama_prodi.ReadOnly = true;
            this.nama_prodi.Width = 125;
            // 
            // id_jurusan_text
            // 
            this.id_jurusan_text.FormattingEnabled = true;
            this.id_jurusan_text.Location = new System.Drawing.Point(238, 136);
            this.id_jurusan_text.Name = "id_jurusan_text";
            this.id_jurusan_text.Size = new System.Drawing.Size(121, 24);
            this.id_jurusan_text.TabIndex = 1;
            this.id_jurusan_text.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(189, 175);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(98, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // hskasa
            // 
            this.hskasa.AutoSize = true;
            this.hskasa.Location = new System.Drawing.Point(152, 139);
            this.hskasa.Name = "hskasa";
            this.hskasa.Size = new System.Drawing.Size(64, 16);
            this.hskasa.TabIndex = 3;
            this.hskasa.Text = "id jurusan";
            // 
            // nama_prodi_text
            // 
            this.nama_prodi_text.Location = new System.Drawing.Point(238, 108);
            this.nama_prodi_text.Name = "nama_prodi_text";
            this.nama_prodi_text.Size = new System.Drawing.Size(121, 22);
            this.nama_prodi_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "nama prodi";
            // 
            // id_prodi_text
            // 
            this.id_prodi_text.Location = new System.Drawing.Point(238, 80);
            this.id_prodi_text.Name = "id_prodi_text";
            this.id_prodi_text.Size = new System.Drawing.Size(121, 22);
            this.id_prodi_text.TabIndex = 6;
            // 
            // id_p
            // 
            this.id_p.AutoSize = true;
            this.id_p.Location = new System.Drawing.Point(167, 83);
            this.id_p.Name = "id_p";
            this.id_p.Size = new System.Drawing.Size(52, 16);
            this.id_p.TabIndex = 7;
            this.id_p.Text = "id prodi";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "hapus";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "simpan";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Prodi_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_p);
            this.Controls.Add(this.id_prodi_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama_prodi_text);
            this.Controls.Add(this.hskasa);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.id_jurusan_text);
            this.Controls.Add(this.ProdiGrid);
            this.Name = "Prodi_Frm";
            this.Text = "Prodi";
            this.Load += new System.EventHandler(this.Prodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdiGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProdiGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_jurusan;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_prodi;
        private System.Windows.Forms.ComboBox id_jurusan_text;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label hskasa;
        private System.Windows.Forms.TextBox nama_prodi_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_prodi_text;
        private System.Windows.Forms.Label id_p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}