using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class Gizmo
    {
        public int GizmoId { get; set; }
        public string Name { get; set; }
        public List<Thing> ManyToManyWithThings { get; set; }
    }
}
