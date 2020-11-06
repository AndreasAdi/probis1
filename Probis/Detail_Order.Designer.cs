namespace Probis
{
    partial class Detail_Order
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
            this.lbl_no_order = new System.Windows.Forms.Label();
            this.dgv_detail_order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel_order = new System.Windows.Forms.Button();
            this.btn_finish_order = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_join = new System.Windows.Forms.Label();
            this.lbl_split = new System.Windows.Forms.Label();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_order)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_no_order
            // 
            this.lbl_no_order.AutoSize = true;
            this.lbl_no_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_order.Location = new System.Drawing.Point(28, 113);
            this.lbl_no_order.Name = "lbl_no_order";
            this.lbl_no_order.Size = new System.Drawing.Size(137, 36);
            this.lbl_no_order.TabIndex = 0;
            this.lbl_no_order.Text = "No Order";
            // 
            // dgv_detail_order
            // 
            this.dgv_detail_order.AllowUserToAddRows = false;
            this.dgv_detail_order.AllowUserToDeleteRows = false;
            this.dgv_detail_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detail_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detail_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaMenu,
            this.jumlah,
            this.hargaMenu});
            this.dgv_detail_order.Location = new System.Drawing.Point(31, 202);
            this.dgv_detail_order.Name = "dgv_detail_order";
            this.dgv_detail_order.RowHeadersWidth = 51;
            this.dgv_detail_order.RowTemplate.Height = 24;
            this.dgv_detail_order.Size = new System.Drawing.Size(588, 380);
            this.dgv_detail_order.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Detail Order";
            // 
            // btn_cancel_order
            // 
            this.btn_cancel_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel_order.Location = new System.Drawing.Point(468, 113);
            this.btn_cancel_order.Name = "btn_cancel_order";
            this.btn_cancel_order.Size = new System.Drawing.Size(151, 66);
            this.btn_cancel_order.TabIndex = 3;
            this.btn_cancel_order.Text = "Cancel Order";
            this.btn_cancel_order.UseVisualStyleBackColor = true;
            this.btn_cancel_order.Click += new System.EventHandler(this.btn_cancel_order_Click);
            // 
            // btn_finish_order
            // 
            this.btn_finish_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish_order.Location = new System.Drawing.Point(468, 32);
            this.btn_finish_order.Name = "btn_finish_order";
            this.btn_finish_order.Size = new System.Drawing.Size(151, 66);
            this.btn_finish_order.TabIndex = 4;
            this.btn_finish_order.Text = "Finish Order";
            this.btn_finish_order.UseVisualStyleBackColor = true;
            this.btn_finish_order.Click += new System.EventHandler(this.btn_finish_order_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 66);
            this.button2.TabIndex = 5;
            this.button2.Text = "Join Bill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(311, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 66);
            this.button3.TabIndex = 6;
            this.button3.Text = "Split Bill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 620);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "TOTAL Rp ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 620);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "1900000";
            // 
            // lbl_join
            // 
            this.lbl_join.AutoSize = true;
            this.lbl_join.Location = new System.Drawing.Point(31, 165);
            this.lbl_join.Name = "lbl_join";
            this.lbl_join.Size = new System.Drawing.Size(46, 17);
            this.lbl_join.TabIndex = 9;
            this.lbl_join.Text = "Join : ";
            // 
            // lbl_split
            // 
            this.lbl_split.AutoSize = true;
            this.lbl_split.Location = new System.Drawing.Point(177, 162);
            this.lbl_split.Name = "lbl_split";
            this.lbl_split.Size = new System.Drawing.Size(47, 17);
            this.lbl_split.TabIndex = 10;
            this.lbl_split.Text = "Split : ";
            // 
            // namaMenu
            // 
            this.namaMenu.HeaderText = "Name";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            // 
            // jumlah
            // 
            this.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jumlah.HeaderText = "QTY";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 66;
            // 
            // hargaMenu
            // 
            this.hargaMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.hargaMenu.DefaultCellStyle = dataGridViewCellStyle1;
            this.hargaMenu.HeaderText = "Price";
            this.hargaMenu.MinimumWidth = 6;
            this.hargaMenu.Name = "hargaMenu";
            this.hargaMenu.Width = 69;
            // 
            // Detail_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 705);
            this.Controls.Add(this.lbl_split);
            this.Controls.Add(this.lbl_join);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_finish_order);
            this.Controls.Add(this.btn_cancel_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_detail_order);
            this.Controls.Add(this.lbl_no_order);
            this.Name = "Detail_Order";
            this.Text = "Detail Order";
            this.Load += new System.EventHandler(this.Detail_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_no_order;
        private System.Windows.Forms.DataGridView dgv_detail_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel_order;
        private System.Windows.Forms.Button btn_finish_order;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_join;
        private System.Windows.Forms.Label lbl_split;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMenu;
    }
}