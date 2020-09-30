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
            this.lbl_no_order = new System.Windows.Forms.Label();
            this.dgv_detail_order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.namaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_finish_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_order)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_no_order
            // 
            this.lbl_no_order.AutoSize = true;
            this.lbl_no_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_no_order.Location = new System.Drawing.Point(25, 125);
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
            this.dgv_detail_order.Size = new System.Drawing.Size(1038, 476);
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
            // namaMenu
            // 
            this.namaMenu.HeaderText = "Name";
            this.namaMenu.MinimumWidth = 6;
            this.namaMenu.Name = "namaMenu";
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "QTY";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            // 
            // hargaMenu
            // 
            this.hargaMenu.HeaderText = "Price";
            this.hargaMenu.MinimumWidth = 6;
            this.hargaMenu.Name = "hargaMenu";
            // 
            // btn_finish_order
            // 
            this.btn_finish_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finish_order.Location = new System.Drawing.Point(861, 104);
            this.btn_finish_order.Name = "btn_finish_order";
            this.btn_finish_order.Size = new System.Drawing.Size(208, 57);
            this.btn_finish_order.TabIndex = 3;
            this.btn_finish_order.Text = "Finish Order";
            this.btn_finish_order.UseVisualStyleBackColor = true;
            // 
            // Detail_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 705);
            this.Controls.Add(this.btn_finish_order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_detail_order);
            this.Controls.Add(this.lbl_no_order);
            this.Name = "Detail_Order";
            this.Text = "Detail_Order";
            this.Load += new System.EventHandler(this.Detail_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_no_order;
        private System.Windows.Forms.DataGridView dgv_detail_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMenu;
        private System.Windows.Forms.Button btn_finish_order;
    }
}