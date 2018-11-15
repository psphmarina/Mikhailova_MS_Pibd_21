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
            hangar = new Hangar<ITransport>(20, pictureBoxHangar.Width, pictureBoxHangar.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }
        private void buttonAircraft_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var car = new Aircraft(100, 1000, dialog.Color);
                int place = hangar + car;
                Draw();
            }
        }

        private void buttonFighterAircraft_Click(object sender, EventArgs e)
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

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var car = hangar - Convert.ToInt32(maskedTextBox1.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    car.SetPosition(5, 15, pictureBoxTake.Width, pictureBoxTake.Height);
                    car.DrawAircraft(gr);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width, pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }
    }
}
