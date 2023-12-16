using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main {
    internal class Products : BaseProduct {
        public int Count { get; set; }
        public Products(string name, double price, int id, int count ) : base(name, price, id) {
            this.Count = count;
        }
        public override string ToString() {
            return base.ToString() + $"\t{Count} p\t\t" + GetType().Name;
        }
    }
}
