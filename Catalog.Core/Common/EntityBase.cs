using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Core.Common
{
    // These are common fields for domain
    // Every entity will have below props by default in ordering Microservice.
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public  string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
