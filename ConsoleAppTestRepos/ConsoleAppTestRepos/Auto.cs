using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestRepos
{
    class Auto
    {
        public int Nummerplaat { get; set; }
        public string Merk { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return  "Nummerplaat " + Nummerplaat + " " + Merk + " " + Model;
        }

        public override bool Equals(object obj)
        {

            return Equals(obj as Auto);
        }

        public bool Equals(Auto obj)
        {
            if (Object.ReferenceEquals(null, obj)) return false;
            if (Object.ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;


            return this.Nummerplaat == obj.Nummerplaat && this.Merk == obj.Merk && this.Model == obj.Model;

        }
        public override int GetHashCode()
        {
            return base.GetHashCode() * 2;
        }
    }

}
