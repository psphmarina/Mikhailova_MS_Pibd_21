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
    public partial class FormCarConfig : Form
    {
        ITransport car = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event carDelegate eventAddCar;
        public FormCarConfig()
        {
            InitializeComponent();
            panelPurple.MouseDown += panelColor_MouseDown;
            panelGold.MouseDown += panelColor_MouseDown;
            panelLime.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelBrown.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            buttonBye.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawAircraft()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 25, pictureBoxAircraft.Width, pictureBoxAircraft.Height);
                car.DrawAircraft(gr);
                pictureBoxAircraft.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }
        private void labelAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAircraft.DoDragDrop(labelAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelFAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelFAircraft.DoDragDrop(labelFAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолёт":
                    car = new Aircraft(100, 500, Color.White);
                    break;
                case "Истребитель":
                    car = new FighterAircraft(100, 500, Color.White, Color.Black, true, true,
                    true);
                    break;
            }
            DrawAircraft();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
            DragDropEffects.Move | DragDropEffects.Copy);
        }
        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawAircraft();
            }
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car != null)
            {
                if (car is FighterAircraft)
                {
                    (car as FighterAircraft).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawAircraft();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(car);
            Close();
        }
        
    }
}
