using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class Contraption
    {
        public int ContraptionId { get; set; }
        public string Name { get; set; }

        public Widget OneToOneWithWidget { get; set; }
    }
}
