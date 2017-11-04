using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class Widget
    {
        public int WidgetId { get; set; }
        public string Name { get; set; }
        public List<Thing> OneToManyWithThings { get; set; }
        public Widget OneToOneWithWidget { get; set; }
    }
}
