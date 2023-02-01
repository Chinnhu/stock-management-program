namespace stock_management
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userBtn = new stock_management.CustomButton();
            this.categoriesBtn = new stock_management.CustomButton();
            this.productsBtn = new stock_management.CustomButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.userBtn);
            this.panel2.Controls.Add(this.categoriesBtn);
            this.panel2.Controls.Add(this.productsBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1190, 107);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(385, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Users";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 644);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 25);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1190, 537);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(530, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(675, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categories";
            // 
            // userBtn
            // 
            this.userBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("userBtn.HoverImage")));
            this.userBtn.Image = ((System.Drawing.Image)(resources.GetObject("userBtn.Image")));
            this.userBtn.Location = new System.Drawing.Point(377, 12);
            this.userBtn.Name = "userBtn";
            this.userBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("userBtn.NormalImage")));
            this.userBtn.Size = new System.Drawing.Size(79, 52);
            this.userBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userBtn.TabIndex = 2;
            this.userBtn.TabStop = false;
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.HoverImage")));
            this.categoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.Image")));
            this.categoriesBtn.Location = new System.Drawing.Point(691, 12);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.NormalImage")));
            this.categoriesBtn.Size = new System.Drawing.Size(79, 52);
            this.categoriesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoriesBtn.TabIndex = 1;
            this.categoriesBtn.TabStop = false;
            // 
            // productsBtn
            // 
            this.productsBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("productsBtn.HoverImage")));
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.Location = new System.Drawing.Point(537, 12);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("productsBtn.NormalImage")));
            this.productsBtn.Size = new System.Drawing.Size(79, 52);
            this.productsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productsBtn.TabIndex = 0;
            this.productsBtn.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private CustomButton productsBtn;
        private System.Windows.Forms.Label label1;
        private CustomButton userBtn;
        private CustomButton categoriesBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}