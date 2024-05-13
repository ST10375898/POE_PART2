using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_2_VERSION_2._0
{
    public class Step
    {
        // declaration
        private string description;
        // declaration of the description property

        public Step(string description) 
        { 
            this.description = description;
        }

        public String Description
        { 
            get { return description; }
            set { description = value; }
        }
        
    }
}
