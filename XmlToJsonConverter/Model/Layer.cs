using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlToJsonConverter.Model
{
   public class Layer
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public Layer[] Sublayers { get; set; }
        public Attribute[] Attributes { get; set; }
    }
}
