using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class Rule
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;

        //ClaimTypeId
        public ClaimType ClaimType { get; set; }

        //AccessAttributeTypeId from ReferenceTypes table

        public string AccesstypeLevel { get; set; } = string.Empty;


    }
}
