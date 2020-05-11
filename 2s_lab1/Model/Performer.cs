using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2s_lab1
{[Serializable]
    class Performer
    {
        protected string name { get; set; }
        protected string surname { get; set; }

        public Performer(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            Console.WriteLine("Create Perfomer\n");
        }

        public Performer()
        {
        }

        ~Performer()
        {
            Console.WriteLine("Perfomer has been deleted!\n");
        }

        public static bool operator ==(Performer p1,Performer p2){
            return p1.Equals(p2);
        }

        public static bool operator !=(Performer p1, Performer p2)
        {
            return !(p1.Equals(p2));
        }

        public override bool Equals(object obj)
        {
            Performer tempPerformer = (Performer)obj;
            if (tempPerformer.name == this.name && tempPerformer.surname == this.surname) {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return name.Length+surname.Length;
        }

        public string createShortInfo()
        {
            return "Исполнитель : " + this.surname;
        }

        public override string ToString()
        {
            return "Исполнитель : " + this.name + " " + this.surname+"\n";
        }
    }
}
