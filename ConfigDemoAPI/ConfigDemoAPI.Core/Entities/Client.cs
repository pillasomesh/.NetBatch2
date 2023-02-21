using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.Core.Entities
{
    public class Client
    {
        public bool IsActive { get; set; }
        [Key]
        public int AccountId { get; set; }
        public string? WorkflowEmailDomain { get; set; }
        public bool IsRv { get; set; }
        public string? ClientName { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
