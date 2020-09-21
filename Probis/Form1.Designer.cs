namespace Probis
{
    partial class Form_kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_kasir));
            this.btn_new_order = new System.Windows.Forms.PictureBox();
            this.btn_list_order = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_list_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_new_order
            // 
            this.btn_new_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_new_order.Image")));
            this.btn_new_order.Location = new System.Drawing.Point(422, 270);
            this.btn_new_order.Name = "btn_new_order";
            this.btn_new_order.Size = new System.Drawing.Size(281, 292);
            this.btn_new_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_new_order.TabIndex = 0;
            this.btn_new_order.TabStop = false;
            this.btn_new_order.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_list_order
            // 
            this.btn_list_order.Image = ((System.Drawing.Image)(resources.GetObject("btn_list_order.Image")));
            this.btn_list_order.Location = new System.Drawing.Point(753, 270);
            this.btn_list_order.Name = "btn_list_order";
            this.btn_list_order.Size = new System.Drawing.Size(281, 292);
            this.btn_list_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_list_order.TabIndex = 1;
            this.btn_list_order.TabStop = false;
            this.btn_list_order.Click += new System.EventHandler(this.btn_list_order_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-434, -6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1938, 96);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(1036, 27);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(238, 29);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Welcome, Username";
            this.label_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(159)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1312, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Log out";
            // 
            // Form_kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1437, 763);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_list_order);
            this.Controls.Add(this.btn_new_order);
            this.Name = "Form_kasir";
            this.Text = "Form_kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_new_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_list_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_new_order;
        private System.Windows.Forms.PictureBox btn_list_order;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
    }
}

