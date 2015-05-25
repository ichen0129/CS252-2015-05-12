using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GuyLibrary
{
    public class Guy
    {
        private string name; //欄位

        public string Name { get; set; }

        public static int TotalGuys { get; set; }

        /*
        public string Name //屬性
        {
            get { return name; }
            set { name = value; }
        }
         */

        private int cash; //欄位

        public int Cash //屬性
        {
            get { return cash; }
            set
            {
                cash = (value < 0) ? 0 : value;
            }
        }

        //C#自動屬性，產生一個匿名的欄位
        public string Message { get; set; }

        //建構式(不return任何東西)
        public Guy(string name)
        {
            this.Name = name;
            this.Cash = 0;
            TotalGuys++;
        }

        //建構式
        public Guy(string name, int cash)
        {
            this.Name = name;
            this.Cash = cash;
            TotalGuys++;
        }

        //建構式
        public Guy(Guy guy)
        {
            this.Name = guy.name;
            this.Cash = guy.cash;
            TotalGuys++;
        }

        //方法
        public int 給錢(int 要給的現金)
        {
            if (要給的現金 >= 0 && 要給的現金 <= this.cash)
            {
                this.cash -= 要給的現金;
                return 要給的現金;
            }
            else
            {
                if (要給的現金 > this.Cash)
                {
                    this.Message = string.Format("給不出來{0}", 要給的現金);

                }
                else
                    this.Message = string.Format("你確定我要給你{0}?", 要給的現金);
                return 0;
            }
        }

        public int 收錢(int 要收的錢)
        {
            if (要收的錢 <= 0)
            {
                this.Message = string.Format("你怎麼給我{0}?", 要收的錢);
                return 0;
            }
            else
            {
                this.cash += 要收的錢;
                return 要收的錢;
            }
        }

        //複製物件 ex:Bob = Joe -> 指向同一個位址，
        //            Bob = Joe.Clone -> 複製Joe的欄位、屬性給Bob並給一個新的參考位址

        public Guy Clone()
        {
            //Guy guy = new Guy(this.Name, this.Cash);
            //return guy;
            return new Guy(this);
        }
    }
}