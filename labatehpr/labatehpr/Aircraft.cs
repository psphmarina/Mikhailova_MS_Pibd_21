using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labatehpr
{
    public class Aircraft : Plane, IComparable<Aircraft>, IEquatable<Aircraft>
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
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Aircraft(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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
            g.FillEllipse(brDGreen, _startPosX, _startPosY + 20, 90, 10);
            g.FillEllipse(brDGreen, _startPosX + 60, _startPosY - 22 + 20, 12, 50);
            g.FillEllipse(brDGreen, _startPosX + 10, _startPosY - 10 + 20, 8, 30);

            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY - 20 + 20, 40, 5);
            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY + 20 + 20, 40, 5);

            //контуры
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, _startPosX, _startPosY + 20, 90, 10);
            g.DrawEllipse(pen, _startPosX + 60, _startPosY - 22 + 20, 12, 50);

            g.DrawEllipse(pen, _startPosX + 40, _startPosY - 20 + 20, 40, 5);
            g.DrawEllipse(pen, _startPosX + 40, _startPosY + 20 + 20, 40, 5);
            g.DrawEllipse(pen, _startPosX + 10, _startPosY - 10 + 20, 8, 30);
        }
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Aircraft other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed == other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight == other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor == other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Aircraft other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
            return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }/// <summary>
         /// Перегрузка метода от object
         /// </summary>
         /// <param name="obj"></param>
         /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Aircraft carObj = obj as Aircraft;
            if (carObj == null)
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}