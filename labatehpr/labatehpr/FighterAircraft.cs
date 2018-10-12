using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace labatehpr
{

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    class FighterAircraft : Aircraft
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool DopMotor { private set; get; }
        public bool Bomb { private set; get; }
        public bool Exhaust { private set; get; }
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет </param>
        /// <param name="dopMotor">Дополнительный двигатель</param>
        public FighterAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool dopMotor, bool bomb, bool exhaust) :
        base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            DopMotor = dopMotor;
            Bomb = bomb;
            Exhaust = exhaust;

        }
        public override void DrawAircraft(Graphics g)
        {
            
            Brush brDGreen = new SolidBrush(MainColor);
            base.DrawAircraft(g);
            //отрисовка


          
             
            //контуры
            Pen pen = new Pen(Color.Black);
             
            if (DopMotor) {
                Brush brDGreen1 = new SolidBrush(DopColor);
                g.FillEllipse(brDGreen1, _startPosX + 45, _startPosY - 10, 35, 5);
                g.FillEllipse(brDGreen1, _startPosX + 45, _startPosY + 12, 35, 5);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY - 10, 35, 5);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 12, 35, 5);
            }
            if (Bomb)
            {
                Brush brb = new SolidBrush(Color.Black);
                g.FillEllipse(brb, _startPosX + 80, _startPosY - 15, 7, 5);
                g.FillEllipse(brb, _startPosX + 80, _startPosY + 15, 7, 5);
                g.FillEllipse(brb, _startPosX + 95, _startPosY - 15, 7, 5);
                g.FillEllipse(brb, _startPosX + 95, _startPosY + 15, 7, 5);
            }
            if (Exhaust)
            {
                Brush brb = new SolidBrush(Color.Gray);
                g.FillEllipse(brb, _startPosX + 20, _startPosY - 25, 17, 15);
                g.FillEllipse(brb, _startPosX + 7, _startPosY - 30, 20, 15);
                g.FillEllipse(brb, _startPosX + 20, _startPosY + 25, 17, 15);
                g.FillEllipse(brb, _startPosX + 7, _startPosY + 30, 20, 15);
            }
        }
    }
}
