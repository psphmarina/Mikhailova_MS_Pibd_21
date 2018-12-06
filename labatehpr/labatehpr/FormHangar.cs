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
        MultiLevelHangar hangar;
        /// <summary>
        /// Форма для добавления
        /// </summary>
        FormCarConfig form;
        private const int countLevel = 5;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new MultiLevelHangar(20, pictureBoxHangar.Width, pictureBoxHangar.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1) { 
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }
        private void buttonAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var car = new Aircraft(100, 1000, dialog.Color);
                    int place = hangar[listBoxLevels.SelectedIndex] + car;
                    if (place == -1)
                    {
                        MessageBox.Show("Нет свободных мест", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Draw();
                }
            }
        }

        private void buttonFighterAircraft_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == DialogResult.OK)
                    {
                        var car = new FighterAircraft(100, 1000, dialog.Color, dialogDop.Color,
                        true, true, true);
                        int place = hangar[listBoxLevels.SelectedIndex] + car;
                        if (place == -1)
                        {
                            MessageBox.Show("Нет свободных мест", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Draw();
                    }
                }
            }
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var car = hangar[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox1.Text);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {
            form = new FormCarConfig();
            form.AddEvent(AddCar);
            form.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddCar(ITransport car)
        {
            if (car != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = hangar[listBoxLevels.SelectedIndex] + car;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}
