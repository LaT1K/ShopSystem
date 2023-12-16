using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace main {
    internal class Vegetables : BaseProduct {
        public double Weight { get;set; }
        public Vegetables(string name, double price, int id, double weight):base(name, price, id) {
            this.Weight = weight;
        }
        public override string ToString() {
            return base.ToString() + $"\t{Weight} kg\t\t" + GetType().Name;
        }
    }
}
