using System;
using System.Collections.Generic;
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

        public int PolicyId { get; set; }

        //public Navigation ParentNavigationId { get; set; }
        public bool IsActive { get; set; } = false;
    }
}
