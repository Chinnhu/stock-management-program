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
    public partial class CustomButton : PictureBox
    {
        private Image normalImage;
        private Image hoverImage;

        public CustomButton()
        {
            InitializeComponent();
        }

        public Image NormalImage
        {
            get { return normalImage; }
            set { normalImage = value; }    
        }

        public Image HoverImage
        {
            get { return hoverImage; }
            set { hoverImage = value; }}

        private void CustomButton_MouseHover(object sender, EventArgs e)
        {
            this.Image = HoverImage;
        }

        private void CustomButton_MouseLeave(object sender, EventArgs e)
        {
            this.Image = NormalImage;
        }
    }      
}
