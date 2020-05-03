using System;
using System.Text;

namespace MyIntLibrary
{
    public class MyInt
    {
        public StringBuilder num = new StringBuilder(50);

        public MyInt()
        {
            this.num = new StringBuilder(50);
        }

        public MyInt(int num)
        {
            //Проверка на переполнение 
            if(int.MaxValue > num && num > int.MinValue)
                this.num.Append(num);
        }

        public MyInt(String num)
        {
            this.num.Append(num);
        }

        public MyInt(Boolean num)
        {
            this.num.Append(num);
        }

        public MyInt(Byte[] num)
        {
            if (num[0] == 1)
                this.num.Append("-");

            for (int i = 1; i < num.Length; i++)
            {
                this.num.Append(num[i]);
            }
        }

        //Сложение +
        public MyInt add(MyInt num)
        {
            int res = Convert.ToInt32(this.num.ToString()) + Convert.ToInt32(num.num.ToString());

            if (int.MaxValue > res && res > int.MinValue)
                return new MyInt(res);
            else
                return new MyInt("Переполнение");
        }

        //Вычитание -
        public MyInt subtract(MyInt num)
        {
            int res = Convert.ToInt32(this.num.ToString()) - Convert.ToInt32(num.num.ToString());

            if (int.MaxValue > res && res > int.MinValue)
                return new MyInt(res);
            else
                return new MyInt("Переполнение");
        }

        //Умножение
        public MyInt multiply(MyInt num)
        {
            int res = Convert.ToInt32(this.num.ToString()) * Convert.ToInt32(num.num.ToString());

            if (int.MaxValue > res && res > int.MinValue)
                return new MyInt(res);
            else
                return new MyInt("Переполнение");
        }

        //Умножение
        public MyInt divide(MyInt num)
        {
            if (int.Parse(num.num.ToString()) != 0)
            {
                int res = Convert.ToInt32(this.num.ToString()) / Convert.ToInt32(num.num.ToString());
                return new MyInt(res);
            }
            else
            {
                return new MyInt("Деление на 0 не доступно");
            }
        }

        //Макс
        public MyInt max(MyInt num)
        {
            if (Convert.ToInt32(this.num.ToString()) >= Convert.ToInt32(num.num.ToString()))
                return new MyInt(this.num.ToString());
            else
                return new MyInt(num.num.ToString());
        }

        //Мин
        public MyInt min(MyInt num)
        {
            if (Convert.ToInt32(this.num.ToString()) >= Convert.ToInt32(num.num.ToString()))
                return new MyInt(num.num.ToString());
            else
                return new MyInt(this.num.ToString());
        }

        //Модуль
        public MyInt abs()
        {
            return new MyInt(Math.Abs(int.Parse(this.num.ToString())));
        }

        //Сравнение
        public MyInt compareTo(MyInt num)
        {
            Boolean result = int.Parse(this.num.ToString()).Equals(int.Parse(num.num.ToString()));
            return new MyInt(result);
        }

        //Наибольший  общий делитель
        public MyInt gcd(MyInt num)
        {
            int x = int.Parse(this.num.ToString());
            int y = int.Parse(num.num.ToString());

            if (y != 0)
            {
                while (x != y)
                {
                    if (x > y)
                        x = x - y;
                    else
                        y = y - x;
                }
            }

            return new MyInt(x);
        }

        //Преобразование в строку
        public String String()
        {
            return this.num.ToString();
        }

        //Преобразование в лонг
        public long Long()
        {
            return long.Parse(this.num.ToString());
        }
    }
}