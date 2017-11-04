using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class Thing
    {
        public int ThingId { get; set; }
        public string Name { get; set; }
        public List<Gizmo> ManyToManyWithGizmos { get; set; }
    }
}
