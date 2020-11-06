namespace Probis
{
    partial class templateOrder
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
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.noOrder = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama,
            this.jumlah,
            this.status});
            this.dataGridOrder.Location = new System.Drawing.Point(12, 54);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.RowHeadersWidth = 51;
            this.dataGridOrder.Size = new System.Drawing.Size(325, 278);
            this.dataGridOrder.TabIndex = 0;
            this.dataGridOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridOrder_DataBindingComplete);
            // 
            // nama
            // 
            this.nama.FillWeight = 144.7727F;
            this.nama.HeaderText = "Nama Menu";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.FillWeight = 63.85674F;
            this.jumlah.HeaderText = "Qty";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 91.37056F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(199, 410);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(97, 39);
            this.btnConfirmOrder.TabIndex = 1;
            this.btnConfirmOrder.Text = "Confirm";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // noOrder
            // 
            this.noOrder.AutoSize = true;
            this.noOrder.Location = new System.Drawing.Point(159, 22);
            this.noOrder.Name = "noOrder";
            this.noOrder.Size = new System.Drawing.Size(46, 17);
            this.noOrder.TabIndex = 2;
            this.noOrder.Text = "label1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 338);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(325, 69);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(56, 410);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(97, 39);
            this.btnProcessOrder.TabIndex = 4;
            this.btnProcessOrder.Text = "Process";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // templateOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(349, 461);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.noOrder);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.dataGridOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "templateOrder";
            this.Load += new System.EventHandler(this.templateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Button btnConfirmOrder;
        public System.Windows.Forms.Label noOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnProcessOrder;
    }
}