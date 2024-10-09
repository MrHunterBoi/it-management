using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Form1 : Form
    {
        private Color color = Color.DarkViolet;
        private double width = 0;
        private double height = 0;

        private double centerX = 0;
        private double centerY = 0;
        private RectangleService.RectangleService rectangleService = new RectangleService.RectangleService();
        public Form1()
        {
            InitializeComponent();

            centerX = panel1.Size.Width / 2;
            centerY = panel1.Size.Height / 2;
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            color_panel.BackColor = color;
        }

        private void width_text_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(width_text.Text, out width);
        }

        private void height_text_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(height_text.Text, out height);
        }

        private void create_rect_btn_Click(object sender, EventArgs e)
        {
            rectangle.Location = rectangleService.getRectangleLocation(centerX, centerY, width, height);
            rectangle.Size = new Size((int)Math.Floor(width), (int)Math.Floor(height));
            rectangle.BackColor = color;
        }
    }
}
