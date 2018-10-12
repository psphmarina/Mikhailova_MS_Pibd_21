using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labatehpr
{
    public class Aircraft : Plane
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected const int carHeight = 60;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Aircraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        
        public override void DrawAircraft(Graphics g)
        {
            //отрисовка
            Brush brDGreen = new SolidBrush(MainColor);
            g.FillEllipse(brDGreen, _startPosX, _startPosY, 90, 10);
            g.FillEllipse(brDGreen, _startPosX + 60, _startPosY - 22, 12, 50);
            g.FillEllipse(brDGreen, _startPosX + 10, _startPosY - 10, 8, 30);

            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY - 20, 40, 5);
            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY + 20, 40, 5);

            //контуры
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, _startPosX, _startPosY, 90, 10);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY - 22, 12, 50);

            g.DrawEllipse(pen, _startPosX + 40, _startPosY - 20, 40, 5);
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 20, 40, 5);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY - 10, 8, 30);
        }
    }


}
