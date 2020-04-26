//New customer information details

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KpopProjectStep10
{
    
    internal class Customer
    {
        public void Name(string cfName, string clName)
        {
            Console.WriteLine($"Nice to meet you {cfName} {clName}");
            Dictionary<string, string> newName = new Dictionary<string, string>();
        }
        public void custPhone(string phone)
        {
            List<string> newPhone = new List<string>();
        }
        public void custAdd(string city, string state)
        {
            Dictionary<string, string> newAdd = new Dictionary<string, string>();
        }
    }
}