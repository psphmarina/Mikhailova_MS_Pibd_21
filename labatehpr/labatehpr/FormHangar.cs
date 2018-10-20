using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labatehpr
{
    public partial class FormHangar : Form
    {
        Hangar<ITransport> hangar;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<ITransport>(20, pictureBoxHangar.Width,pictureBoxHangar.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }
        private void buttonFAir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var car = new FighterAircraft(100, 1000, dialog.Color, dialogDop.Color,
                   true, true, true);
                    int place = hangar + car;
                    Draw();
                }
            }
        }

        private void buttonAir_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Aircraft(100, 1000, dialog.Color);
                int place = hangar + car;
                Draw();
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = hangar - Convert.ToInt32(maskedTextBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBox2.Width,
                   pictureBox2.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 5, pictureBox2.Width, pictureBox2.Height);
                    car.DrawAircraft(gr);
                    pictureBox2.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBox2.Width,pictureBox2.Height);
                    pictureBox2.Image = bmp;
                }
                Draw();
            }
        }
    }
}
