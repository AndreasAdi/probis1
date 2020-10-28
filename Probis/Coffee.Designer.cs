namespace Probis
{
    partial class Coffee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_kopi = new System.Windows.Forms.DataGridView();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_coffe = new System.Windows.Forms.PictureBox();
            this.button_add = new System.Windows.Forms.Button();
            this.numericUpDown_jumlah = new System.Windows.Forms.NumericUpDown();
            this.notes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kopi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_kopi
            // 
            this.dataGridView_kopi.AllowUserToAddRows = false;
            this.dataGridView_kopi.AllowUserToDeleteRows = false;
            this.dataGridView_kopi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_kopi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_kopi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kopi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaMenu,
            this.hargaMenu});
            this.dataGridView_kopi.Location = new System.Drawing.Point(20, 74);
            this.dataGridView_kopi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_kopi.Name = "dataGridView_kopi";
            this.dataGridView_kopi.ReadOnly = true;
            this.dataGridView_kopi.RowHeadersWidth = 51;
            this.dataGridView_kopi.RowTemplate.Height = 24;
            this.dataGridView_kopi.Size = new System.Drawing.Size(389, 382);
            this.dataGridView_kopi.TabIndex = 7;
            this.dataGridView_kopi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kopi_CellClick);
            this.dataGridView_kopi.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_kopi_CellFormatting);
            // 
            // namaMenu
            // 
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.namaMenu.DefaultCellStyle = dataGridViewCellStyle1;
            this.namaMenu.HeaderText = "Name";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            this.namaMenu.ReadOnly = true;
            // 
            // hargaMenu
            // 
            this.hargaMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.hargaMenu.DefaultCellStyle = dataGridViewCellStyle2;
            this.hargaMenu.HeaderText = "Price";
            this.hargaMenu.MinimumWidth = 6;
            this.hargaMenu.Name = "hargaMenu";
            this.hargaMenu.ReadOnly = true;
            this.hargaMenu.Width = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coffee";
            // 
            // pictureBox_coffe
            // 
            this.pictureBox_coffe.Location = new System.Drawing.Point(425, 74);
            this.pictureBox_coffe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_coffe.Name = "pictureBox_coffe";
            this.pictureBox_coffe.Size = new System.Drawing.Size(287, 164);
            this.pictureBox_coffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_coffe.TabIndex = 9;
            this.pictureBox_coffe.TabStop = false;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(425, 428);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(287, 28);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // numericUpDown_jumlah
            // 
            this.numericUpDown_jumlah.Location = new System.Drawing.Point(425, 253);
            this.numericUpDown_jumlah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_jumlah.Name = "numericUpDown_jumlah";
            this.numericUpDown_jumlah.Size = new System.Drawing.Size(287, 22);
            this.numericUpDown_jumlah.TabIndex = 11;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(425, 291);
            this.notes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(287, 121);
            this.notes.TabIndex = 12;
            // 
            // Coffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 472);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.numericUpDown_jumlah);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox_coffe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_kopi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Coffee";
            this.Text = "Coffee";
            this.Load += new System.EventHandler(this.Coffee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kopi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_kopi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_coffe;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.NumericUpDown numericUpDown_jumlah;
        public System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMenu;
    }
}