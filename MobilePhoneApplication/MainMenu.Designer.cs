namespace MobilePhoneApplication
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.pictureBoxMainMenu = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelMessage1 = new System.Windows.Forms.Label();
            this.labelMessage2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMainMenu
            // 
            this.pictureBoxMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainMenu.Image")));
            this.pictureBoxMainMenu.Location = new System.Drawing.Point(139, 65);
            this.pictureBoxMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxMainMenu.Name = "pictureBoxMainMenu";
            this.pictureBoxMainMenu.Size = new System.Drawing.Size(141, 112);
            this.pictureBoxMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMainMenu.TabIndex = 0;
            this.pictureBoxMainMenu.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(89, 18);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(256, 36);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "FULAT PHONES";
            // 
            // btnShop
            // 
            this.btnShop.Location = new System.Drawing.Point(153, 195);
            this.btnShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(109, 39);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Shop for Phones";
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(153, 239);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(109, 39);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Need help?";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // labelMessage1
            // 
            this.labelMessage1.AutoSize = true;
            this.labelMessage1.Location = new System.Drawing.Point(9, 315);
            this.labelMessage1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMessage1.Name = "labelMessage1";
            this.labelMessage1.Size = new System.Drawing.Size(375, 13);
            this.labelMessage1.TabIndex = 4;
            this.labelMessage1.Text = "Thank you for checking out our shop, we have great range of offers available.";
            // 
            // labelMessage2
            // 
            this.labelMessage2.AutoSize = true;
            this.labelMessage2.Location = new System.Drawing.Point(9, 341);
            this.labelMessage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMessage2.Name = "labelMessage2";
            this.labelMessage2.Size = new System.Drawing.Size(260, 13);
            this.labelMessage2.TabIndex = 5;
            this.labelMessage2.Text = "Order now for collection at our local store in Leicester.";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 378);
            this.Controls.Add(this.labelMessage2);
            this.Controls.Add(this.labelMessage1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pictureBoxMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Fulat Phones Mobile Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMainMenu;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label labelMessage1;
        private System.Windows.Forms.Label labelMessage2;
    }
}

