using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main {
    internal class Fruits : BaseProduct {
        public double Weight { get; set; }
        public Fruits(string name, double price, int id, double weight) : base(name, price, id) {
            this.Weight = weight;
        }

        public override string ToString() {
            return base.ToString() + $"\t{Weight} kg\t\t" + GetType().Name;
        }
    }
}
