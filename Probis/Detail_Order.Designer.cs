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
            this.dgv_detail_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            // Detail_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1105, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_detail_order);
            this.Controls.Add(this.lbl_no_order);
            this.Name = "Detail_Order";
            this.Text = "Detail_Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_no_order;
        private System.Windows.Forms.DataGridView dgv_detail_order;
        private System.Windows.Forms.Label label1;
    }
}