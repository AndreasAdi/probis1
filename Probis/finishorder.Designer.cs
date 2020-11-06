namespace Probis
{
    partial class finishorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finishorder));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_menu = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_cash = new System.Windows.Forms.RadioButton();
            this.rb_debit = new System.Windows.Forms.RadioButton();
            this.txt_no_debit = new System.Windows.Forms.TextBox();
            this.lbl_debit = new System.Windows.Forms.Label();
            this.btn_validate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_cash = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_kembalian = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lbl_menu
            // 
            this.lbl_menu.AutoSize = true;
            this.lbl_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menu.Location = new System.Drawing.Point(20, 71);
            this.lbl_menu.Name = "lbl_menu";
            this.lbl_menu.Size = new System.Drawing.Size(0, 25);
            this.lbl_menu.TabIndex = 1;
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_harga.Location = new System.Drawing.Point(400, 71);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(0, 25);
            this.lbl_harga.TabIndex = 2;
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(330, 71);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(0, 25);
            this.lbl_qty.TabIndex = 3;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(711, 12);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(0, 29);
            this.lbl_total.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paymet Method";
            // 
            // rb_cash
            // 
            this.rb_cash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_cash.AutoSize = true;
            this.rb_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_cash.Location = new System.Drawing.Point(176, 392);
            this.rb_cash.Name = "rb_cash";
            this.rb_cash.Size = new System.Drawing.Size(80, 29);
            this.rb_cash.TabIndex = 6;
            this.rb_cash.TabStop = true;
            this.rb_cash.Text = "Cash";
            this.rb_cash.UseVisualStyleBackColor = true;
            // 
            // rb_debit
            // 
            this.rb_debit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_debit.AutoSize = true;
            this.rb_debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_debit.Location = new System.Drawing.Point(537, 390);
            this.rb_debit.Name = "rb_debit";
            this.rb_debit.Size = new System.Drawing.Size(78, 29);
            this.rb_debit.TabIndex = 7;
            this.rb_debit.TabStop = true;
            this.rb_debit.Text = "Debit";
            this.rb_debit.UseVisualStyleBackColor = true;
            this.rb_debit.CheckedChanged += new System.EventHandler(this.rb_debit_CheckedChanged);
            // 
            // txt_no_debit
            // 
            this.txt_no_debit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_no_debit.Enabled = false;
            this.txt_no_debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no_debit.Location = new System.Drawing.Point(735, 438);
            this.txt_no_debit.MaxLength = 12;
            this.txt_no_debit.Name = "txt_no_debit";
            this.txt_no_debit.Size = new System.Drawing.Size(267, 30);
            this.txt_no_debit.TabIndex = 8;
            this.txt_no_debit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_no_debit_KeyPress);
            // 
            // lbl_debit
            // 
            this.lbl_debit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_debit.AutoSize = true;
            this.lbl_debit.Enabled = false;
            this.lbl_debit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_debit.Location = new System.Drawing.Point(532, 441);
            this.lbl_debit.Name = "lbl_debit";
            this.lbl_debit.Size = new System.Drawing.Size(179, 25);
            this.lbl_debit.TabIndex = 9;
            this.lbl_debit.Text = "Debit Card Number";
            // 
            // btn_validate
            // 
            this.btn_validate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_validate.Enabled = false;
            this.btn_validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_validate.Location = new System.Drawing.Point(1041, 433);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(111, 40);
            this.btn_validate.TabIndex = 10;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1008, 442);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(994, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cash
            // 
            this.txt_cash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cash.Location = new System.Drawing.Point(176, 438);
            this.txt_cash.Name = "txt_cash";
            this.txt_cash.Size = new System.Drawing.Size(318, 30);
            this.txt_cash.TabIndex = 13;
            this.txt_cash.TextChanged += new System.EventHandler(this.txt_cash_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pay Amount";
            // 
            // txt_kembalian
            // 
            this.txt_kembalian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kembalian.AutoSize = true;
            this.txt_kembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kembalian.Location = new System.Drawing.Point(173, 495);
            this.txt_kembalian.Name = "txt_kembalian";
            this.txt_kembalian.Size = new System.Drawing.Size(0, 25);
            this.txt_kembalian.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Change";
            // 
            // finishorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1186, 587);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_kembalian);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cash);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_validate);
            this.Controls.Add(this.lbl_debit);
            this.Controls.Add(this.txt_no_debit);
            this.Controls.Add(this.rb_debit);
            this.Controls.Add(this.rb_cash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.lbl_menu);
            this.Controls.Add(this.label1);
            this.Name = "finishorder";
            this.Text = "Finish Order";
            this.Load += new System.EventHandler(this.finishorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_menu;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_cash;
        private System.Windows.Forms.RadioButton rb_debit;
        private System.Windows.Forms.TextBox txt_no_debit;
        private System.Windows.Forms.Label lbl_debit;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_cash;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txt_kembalian;
        private System.Windows.Forms.Label label4;
    }
}