using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class Reference
    {
        public int Id { get; set; }

        public int Value { get; set; }

        public ReferenceTypes ReferenceType { get; set; }

        public bool IsActive { get; set; } = false;

    }
}
