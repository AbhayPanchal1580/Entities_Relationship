using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public  class ReferenceTypeCorrelations
    {
        public int Id { get; set; }
        [ForeignKey("ReferenceTypes")]
        public int? ParentReferenceId { get; set; }

        public virtual ReferenceTypes ReferenceTypes { get; set; }


        [ForeignKey("ReferenceType")]
        public int? ChildReferenceId { get; set; }

        public virtual ReferenceTypes ChildReference { get; set; }
    }
}
