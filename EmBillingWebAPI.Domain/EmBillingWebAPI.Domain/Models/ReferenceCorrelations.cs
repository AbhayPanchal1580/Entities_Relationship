using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class ReferenceCorrelations
    {

        public int Id { get; set; }

        [ForeignKey("Reference")]
        public int? ParentReferenceId { get; set; }

        public virtual Reference ParentReference { get; set; }


        [ForeignKey("Reference")]
        public int? ChildReferenceId { get; set; }

        public virtual Reference ChildReference { get; set; }
    }
}


