using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2s_lab1
{
    [Serializable]
    class Performance:Performer,ICloneable,IComparable
    {
        public string nameEvent { get; set; }
        public Composition composition { get; set; }
        public int duration { get; set; }

        public Performance(string nameEvent, Composition composition, int duration, string name, string surname) :base(name,surname)
        {
            this.nameEvent = nameEvent;
            this.composition = composition;
            this.duration = duration;
            Console.WriteLine("Performance has been created!\n");
        }
        public Performance() {
        }

        ~Performance()
        {
            Console.WriteLine("Performance has been deleted!\n");
        }

        public static Performance operator +(Performance p1,Performance p2 ) {
            Performance p3;
            p3 = new Performance(p1.nameEvent + " и " + p2.nameEvent, p1.composition, p1.duration + p2.duration, p1.name, p1.surname);//+контантенация названий
            return p3;
        }

        public static bool operator >(Performance p1,Performance p2) {
            int temp= p1.CompareTo(p2);
            if (temp == 1)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static bool operator <(Performance p1, Performance p2)
        {
            int temp = p1.CompareTo(p2);
            if (temp == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public new string createShortInfo()
        {
            return "Название выступления : " + this.nameEvent;
        }


        public override string ToString()
        {
            return base.ToString()+ "Название выступления : " + nameEvent + "\nТип выступления :" +composition+"\nДлительность : " + duration+"\n";
        }

        public object Clone()
        {
            Performance tempPerformance = new Performance(this.nameEvent+" - copy", this.composition, this.duration, this.name, this.surname);
            return tempPerformance;
        }

        public override bool Equals(object obj)
        {
            Performance tempPerformance = (Performance)obj;
            if (tempPerformance.nameEvent == this.nameEvent)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return duration+nameEvent.Length;
        }

        public int CompareTo(object obj)
        {
            Performance tempPerformance = obj as Performance;
            if (tempPerformance != null)
            {
                if (this.duration > tempPerformance.duration)
                    return 1;
                if (this.duration < tempPerformance.duration)
                    return -1;
                else
                    return 0;
            }
            else
                throw new ArgumentException("Parameter is not a Performance!");          
        }
    }
}
