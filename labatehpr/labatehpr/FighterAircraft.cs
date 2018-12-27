using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace labatehpr
{
    class FighterAircraft : Aircraft, IComparable<FighterAircraft>, IEquatable<FighterAircraft>
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
        public FighterAircraft(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                DopMotor = Convert.ToBoolean(strs[4]);
                Bomb = Convert.ToBoolean(strs[5]);
                Exhaust = Convert.ToBoolean(strs[6]);
            }
        }
        public override void DrawAircraft(Graphics g)
        {
            
            Brush brDGreen = new SolidBrush(MainColor);
            base.DrawAircraft(g);
            Pen pen = new Pen(Color.Black);
             
            if (DopMotor) {
                Brush brDGreen1 = new SolidBrush(DopColor);
                g.FillEllipse(brDGreen1, _startPosX + 45, _startPosY + 10, 35, 5);
                g.FillEllipse(brDGreen1, _startPosX + 45, _startPosY + 32, 35, 5);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 10, 35, 5);
                g.DrawEllipse(pen, _startPosX + 45, _startPosY + 32, 35, 5);
            }
            if (Bomb)
            {
                Brush brb = new SolidBrush(Color.Black);
                g.FillEllipse(brb, _startPosX + 80, _startPosY + 5, 7, 5);
                g.FillEllipse(brb, _startPosX + 80, _startPosY + 35, 7, 5);
                g.FillEllipse(brb, _startPosX + 95, _startPosY + 5, 7, 5);
                g.FillEllipse(brb, _startPosX + 95, _startPosY + 35, 7, 5);
            }
            if (Exhaust)
            {
                Brush brb = new SolidBrush(Color.Gray);
                g.FillEllipse(brb, _startPosX + 20, _startPosY - 10, 17, 15);
                g.FillEllipse(brb, _startPosX + 7, _startPosY - 15, 20, 15);
                g.FillEllipse(brb, _startPosX + 20, _startPosY + 35, 17, 15);
                g.FillEllipse(brb, _startPosX + 7, _startPosY + 40, 20, 15);
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + DopMotor + ";" +
            Bomb + ";" + Exhaust;
        }
        /// <summary>
        /// Метод интерфейса IComparable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(FighterAircraft other)
        {
            var res = (this is Aircraft).CompareTo(other is Aircraft);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (Bomb != other.Bomb)
            {
                return Bomb.CompareTo(other.Bomb);
            }
            if (Exhaust != other.Exhaust)
            {
                return Exhaust.CompareTo(other.Exhaust);
            }
            return 0;
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(FighterAircraft other)
        {
            var res = (this as Aircraft).Equals(other as Aircraft);
            if (!res)
            {
                return res;
            }

            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (Bomb != other.Bomb)
            {
                return false;
            }
            if (Exhaust != other.Exhaust)
            {
                return false;
            }
            return true;
        }
        /// <summary>
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
            FighterAircraft carObj = obj as FighterAircraft;
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
