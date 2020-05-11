using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2s_lab1
{
    [Serializable]
    class Concert:ICloneable
    {
        public string companyName { get; set; }
        public string consertName { get; set; }
        public DateTime dataTime { get; set; }
        int generalDuration { get; set; }
        public List<Performance> performancetList = new List<Performance>();

        public Concert(string companyName, string consertName, DateTime dataTime)
        {
            this.companyName = companyName;
            this.consertName = consertName;
            this.dataTime = dataTime;
            this.generalDuration = 0;
            Console.WriteLine("Concert has been created!\n");
        }

        public Concert() {
        }

        ~Concert()
        {
            Console.WriteLine("Concert has been deleted!\n");
        }

        public Performance this[int index]
        {
            get
            {
                return performancetList[index];
            }
        }

        public void addPerformance(Performance perfomance)
        {
            generalDuration += perfomance.duration;
            performancetList.Add(perfomance);
        }

        public string createShortInfo()
        {
            return("Название компании : " + companyName
                + "\nОбщая длительность: " + generalDuration+"\n");
        }

        public virtual string createFullInfo()
        {
            string info = createShortInfo();
            info+="Название концерта:"+consertName+"\n";
            int count=1;
            foreach (Performance p in performancetList) {
                info +="Дата: "+dataTime.ToLongDateString()+"\n"+"---------------Выступление №"+(count++)+ "---------------\n" + p.ToString();
            }
            return info;
        }

        public object Clone()
        {
            Concert tempConcert = new Concert(this.companyName, this.consertName+" - copy", this.dataTime);
            return tempConcert;
        }

        public override string ToString()
        {
            return "Название концерта: "+ consertName +"\nНазвание компании: "+companyName+"\nДата: "+ dataTime.ToLongTimeString()+"\nОбщая длительность: "+generalDuration;
        }

        public override bool Equals(object obj)
        {
            Concert obj2 = (Concert)obj;
            if (this.consertName == obj2.consertName && this.companyName == obj2.companyName)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return generalDuration+companyName.Length+consertName.Length;
        }

        //public static explicit operator Concert(object v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
