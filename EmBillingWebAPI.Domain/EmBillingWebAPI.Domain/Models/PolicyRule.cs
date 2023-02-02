using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class PolicyRule
    {
        public int Id { get; set; }

        //PolicyId from Policies table

        public Policies Policy { get; set; }
        public Rule Rule { get; set; }
    }
}
