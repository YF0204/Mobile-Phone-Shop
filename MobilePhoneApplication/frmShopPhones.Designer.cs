namespace MobilePhoneApplication
{
    partial class frmShopPhones
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
            this.textBoxPhones = new System.Windows.Forms.TextBox();
            this.labelShopPhones = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.labelSelectedPhone = new System.Windows.Forms.Label();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhones
            // 
            this.textBoxPhones.Location = new System.Drawing.Point(63, 62);
            this.textBoxPhones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhones.Multiline = true;
            this.textBoxPhones.Name = "textBoxPhones";
            this.textBoxPhones.Size = new System.Drawing.Size(479, 345);
            this.textBoxPhones.TabIndex = 0;
            // 
            // labelShopPhones
            // 
            this.labelShopPhones.AutoSize = true;
            this.labelShopPhones.Location = new System.Drawing.Point(12, 21);
            this.labelShopPhones.Name = "labelShopPhones";
            this.labelShopPhones.Size = new System.Drawing.Size(264, 17);
            this.labelShopPhones.TabIndex = 1;
            this.labelShopPhones.Text = "Our current phones on sale - Order now!";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(63, 414);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 32);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(157, 414);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 32);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(401, 414);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(140, 32);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order This Phone";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // labelSelectedPhone
            // 
            this.labelSelectedPhone.AutoSize = true;
            this.labelSelectedPhone.Location = new System.Drawing.Point(397, 21);
            this.labelSelectedPhone.Name = "labelSelectedPhone";
            this.labelSelectedPhone.Size = new System.Drawing.Size(46, 17);
            this.labelSelectedPhone.TabIndex = 5;
            this.labelSelectedPhone.Text = "label1";
            // 
            // imgPicture
            // 
            this.imgPicture.Location = new System.Drawing.Point(575, 114);
            this.imgPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(279, 221);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 6;
            this.imgPicture.TabStop = false;
            // 
            // frmShopPhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 476);
            this.Controls.Add(this.imgPicture);
            this.Controls.Add(this.labelSelectedPhone);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.labelShopPhones);
            this.Controls.Add(this.textBoxPhones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmShopPhones";
            this.Text = "frmShopPhones";
            this.Load += new System.EventHandler(this.frmShopPhones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhones;
        private System.Windows.Forms.Label labelShopPhones;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label labelSelectedPhone;
        private System.Windows.Forms.PictureBox imgPicture;
    }
}