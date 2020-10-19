namespace Probis
{
    partial class snack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(snack));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_snack = new System.Windows.Forms.DataGridView();
            this.pictureBox_coffe = new System.Windows.Forms.PictureBox();
            this.numericUpDown_jumlah = new System.Windows.Forms.NumericUpDown();
            this.button_add = new System.Windows.Forms.Button();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_snack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Snack";
            // 
            // dataGridView_snack
            // 
            this.dataGridView_snack.AllowUserToAddRows = false;
            this.dataGridView_snack.AllowUserToDeleteRows = false;
            this.dataGridView_snack.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_snack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_snack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaMenu,
            this.hargaMenu});
            this.dataGridView_snack.Location = new System.Drawing.Point(72, 120);
            this.dataGridView_snack.Name = "dataGridView_snack";
            this.dataGridView_snack.RowHeadersWidth = 51;
            this.dataGridView_snack.RowTemplate.Height = 24;
            this.dataGridView_snack.Size = new System.Drawing.Size(571, 504);
            this.dataGridView_snack.TabIndex = 4;
            this.dataGridView_snack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_snack_CellClick);
            // 
            // pictureBox_coffe
            // 
            this.pictureBox_coffe.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_coffe.Image")));
            this.pictureBox_coffe.Location = new System.Drawing.Point(665, 120);
            this.pictureBox_coffe.Name = "pictureBox_coffe";
            this.pictureBox_coffe.Size = new System.Drawing.Size(297, 269);
            this.pictureBox_coffe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_coffe.TabIndex = 10;
            this.pictureBox_coffe.TabStop = false;
            // 
            // numericUpDown_jumlah
            // 
            this.numericUpDown_jumlah.Location = new System.Drawing.Point(665, 410);
            this.numericUpDown_jumlah.Name = "numericUpDown_jumlah";
            this.numericUpDown_jumlah.Size = new System.Drawing.Size(297, 22);
            this.numericUpDown_jumlah.TabIndex = 13;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(665, 589);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(297, 35);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // namaMenu
            // 
            this.namaMenu.HeaderText = "Name";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            this.namaMenu.ReadOnly = true;
            // 
            // hargaMenu
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.hargaMenu.DefaultCellStyle = dataGridViewCellStyle3;
            this.hargaMenu.HeaderText = "Price";
            this.hargaMenu.MinimumWidth = 6;
            this.hargaMenu.Name = "hargaMenu";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(665, 438);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(297, 145);
            this.notes.TabIndex = 14;
            // 
            // snack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 641);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.numericUpDown_jumlah);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.pictureBox_coffe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_snack);
            this.Name = "snack";
            this.Text = "snack";
            this.Load += new System.EventHandler(this.snack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_snack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_coffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_jumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_snack;
        private System.Windows.Forms.PictureBox pictureBox_coffe;
        private System.Windows.Forms.NumericUpDown numericUpDown_jumlah;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMenu;
        private System.Windows.Forms.TextBox notes;
    }
}