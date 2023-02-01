using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmBillingWebAPI.Domain.Models
{
    public class Navigation
    {
        public int Id { get; set; }

        public string Name { get; set; }=string.Empty;

        public string Title { get; set; } = string.Empty;

        public string URL { get; set; } = string.Empty;

        public Policies Policy { get; set; }

        [ForeignKey("Navigation")]
        public int? ParentNavigationId { get; set; }

        public virtual Navigation ParentNavigation { get; set; }

        public bool IsActive { get; set; } = false;
    }
}
