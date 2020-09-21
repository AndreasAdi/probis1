namespace Probis
{
    partial class gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gudang));
            this.dataGridView_stock = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stock
            // 
            this.dataGridView_stock.AllowUserToAddRows = false;
            this.dataGridView_stock.AllowUserToDeleteRows = false;
            this.dataGridView_stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stock.Location = new System.Drawing.Point(0, 148);
            this.dataGridView_stock.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_stock.Name = "dataGridView_stock";
            this.dataGridView_stock.ReadOnly = true;
            this.dataGridView_stock.RowHeadersWidth = 51;
            this.dataGridView_stock.RowTemplate.Height = 24;
            this.dataGridView_stock.Size = new System.Drawing.Size(905, 308);
            this.dataGridView_stock.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-272, -9);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1454, 78);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Stock";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.BorderColor = System.Drawing.Color.Transparent;
            this.button_login.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Transparent;
            this.button_login.Location = new System.Drawing.Point(743, 87);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_login.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(215)))), ((int)(((byte)(167)))));
            this.button_login.OnHoverTextColor = System.Drawing.Color.White;
            this.button_login.Size = new System.Drawing.Size(143, 42);
            this.button_login.TabIndex = 13;
            this.button_login.Text = "+ Add New Item";
            this.button_login.TextColor = System.Drawing.Color.White;
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView_stock);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "gudang";
            this.Text = "gudang";
            this.Load += new System.EventHandler(this.gudang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private ePOSOne.btnProduct.Button_WOC button_login;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView_stock;
    }
}