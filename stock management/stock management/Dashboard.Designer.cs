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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productsBtn = new stock_management.CustomerButton();
            this.categoriesBtn = new stock_management.CustomerButton();
            this.usersBtn = new stock_management.CustomerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuElement2 = new System.Windows.Forms.Panel();
            this.menuElement = new System.Windows.Forms.Panel();
            this.panelBot = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.GhostWhite;
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.productsBtn);
            this.panelMenu.Controls.Add(this.categoriesBtn);
            this.panelMenu.Controls.Add(this.usersBtn);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.menuElement2);
            this.panelMenu.Controls.Add(this.menuElement);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1108, 132);
            this.panelMenu.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(702, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Categories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Users";
            // 
            // productsBtn
            // 
            this.productsBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("productsBtn.HoverImage")));
            this.productsBtn.Image = ((System.Drawing.Image)(resources.GetObject("productsBtn.Image")));
            this.productsBtn.Location = new System.Drawing.Point(501, 32);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("productsBtn.NormalImage")));
            this.productsBtn.Size = new System.Drawing.Size(77, 50);
            this.productsBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productsBtn.TabIndex = 5;
            this.productsBtn.TabStop = false;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.HoverImage")));
            this.categoriesBtn.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.Image")));
            this.categoriesBtn.Location = new System.Drawing.Point(700, 32);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("categoriesBtn.NormalImage")));
            this.categoriesBtn.Size = new System.Drawing.Size(77, 50);
            this.categoriesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.categoriesBtn.TabIndex = 4;
            this.categoriesBtn.TabStop = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.HoverImage = ((System.Drawing.Image)(resources.GetObject("usersBtn.HoverImage")));
            this.usersBtn.Image = ((System.Drawing.Image)(resources.GetObject("usersBtn.Image")));
            this.usersBtn.Location = new System.Drawing.Point(302, 32);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.NormalImage = ((System.Drawing.Image)(resources.GetObject("usersBtn.NormalImage")));
            this.usersBtn.Size = new System.Drawing.Size(77, 50);
            this.usersBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usersBtn.TabIndex = 3;
            this.usersBtn.TabStop = false;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.GhostWhite;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // menuElement2
            // 
            this.menuElement2.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuElement2.Location = new System.Drawing.Point(0, 122);
            this.menuElement2.Name = "menuElement2";
            this.menuElement2.Size = new System.Drawing.Size(1108, 10);
            this.menuElement2.TabIndex = 1;
            // 
            // menuElement
            // 
            this.menuElement.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuElement.Location = new System.Drawing.Point(0, 0);
            this.menuElement.Name = "menuElement";
            this.menuElement.Size = new System.Drawing.Size(1108, 10);
            this.menuElement.TabIndex = 0;
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.Gold;
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.Location = new System.Drawing.Point(0, 622);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(1108, 10);
            this.panelBot.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 132);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1108, 490);
            this.panelMain.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 632);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMenu);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel menuElement2;
        private System.Windows.Forms.Panel menuElement;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private CustomerButton usersBtn;
        private CustomerButton productsBtn;
        private CustomerButton categoriesBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}