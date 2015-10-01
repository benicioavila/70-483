using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    public class Job
    {
        public string Name { get; set; }

        public void SetName(string value)
        {
            //validade input
            Contract.Requires(!String.IsNullOrEmpty(value), "value is empty");
            this.Name = value;
        }

        public string GetName()
        {
            Contract.Ensures(!String.IsNullOrEmpty(Contract.Result<string>()));
            return this.Name;
        }


        
    }
}
