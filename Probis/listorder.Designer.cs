namespace Probis
{
    partial class listorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listorder));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-277, -4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1939, 96);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.AllowUserToAddRows = false;
            this.dataGridView_stock.AllowUserToDeleteRows = false;
            this.dataGridView_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNumber,
            this.Table,
            this.subtotal,
            this.Tax,
            this.Total,
            this.Status});
            this.dataGridView_stock.Location = new System.Drawing.Point(-4, 180);
            this.dataGridView_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.ReadOnly = true;
            this.dataGridView_stock.RowHeadersWidth = 51;
            this.dataGridView_stock.RowTemplate.Height = 24;
            this.dataGridView_stock.Size = new System.Drawing.Size(1344, 448);
            this.dataGridView_stock.TabIndex = 7;
            this.dataGridView_stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_stock_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "Order List";
            // 
            // OrderNumber
            // 
            this.OrderNumber.HeaderText = "Order Number";
            this.OrderNumber.MinimumWidth = 6;
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            // 
            // Table
            // 
            this.Table.HeaderText = "Table";
            this.Table.MinimumWidth = 6;
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.MinimumWidth = 6;
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(247, 130);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 30);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // listorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 626);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_stock);
            this.Controls.Add(this.pictureBox4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "listorder";
            this.Text = "listorder";
            this.Load += new System.EventHandler(this.listorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView_stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}