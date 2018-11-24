using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labatehpr
{
    public class Aircraft : Plane
    {
        /// <summary>
        /// ������ ��������� ����������
        /// </summary>
        protected const int carWidth = 100;
        /// <summary>
        /// ������ ��������� ����������
        /// </summary>
        protected const int carHeight = 60;
        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="maxSpeed">������������ ��������</param>
        /// <param name="weight">��� ����������</param>
        /// <param name="mainColor">�������� ���� ������</param>
        public Aircraft(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// �����������
        /// </summary>
        /// <param name="info">���������� �� �������</param>
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
                // ������
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //�����
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //�����
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //����
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
            //���������
            Brush brDGreen = new SolidBrush(MainColor);
            g.FillEllipse(brDGreen, _startPosX, _startPosY + 20, 90, 10);
            g.FillEllipse(brDGreen, _startPosX + 60, _startPosY - 22 + 20, 12, 50);
            g.FillEllipse(brDGreen, _startPosX + 10, _startPosY - 10 + 20, 8, 30);

            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY - 20 + 20, 40, 5);
            g.FillEllipse(brDGreen, _startPosX + 40, _startPosY + 20 + 20, 40, 5);

            //�������
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
    }
}