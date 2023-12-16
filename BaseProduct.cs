using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace main {
    abstract public class BaseProduct {
        protected BaseProduct(string name, double price, int id) {
            this.Name = name;
            this.Price = price;
            this.ID = id;
        }

        public string Name { get;set; }
        public double Price { get;set; }
        public int ID { get; set; }
        public static int Counter = 1;
        public virtual string ToString() {
            return $"{ID}\t{Price:C}\t{Name}";
        }
    }
}
