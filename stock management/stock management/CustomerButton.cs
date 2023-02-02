using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock_management
{
    public partial class CustomerButton : PictureBox
    {
        private Image normalImg;
        private Image hoverImg;

        public CustomerButton()
        {
            InitializeComponent();
        }

        public Image NormalImage
        {
            get { return normalImg; }
            set { normalImg = value; }
        }

        public Image HoverImage
        {
            get { return hoverImg; }
            set { hoverImg = value; }
        }

        private void CustomerButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomerButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }
}
