using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseApp.Domain.Entities
{
    public class Image : BaseEntity
    {
        public string Url { get; set; } = null!;
        public string? AltText { get; set; }
    }
}
