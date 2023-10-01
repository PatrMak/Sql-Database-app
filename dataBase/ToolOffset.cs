using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseClass
{
    internal class ToolOffset
    {
        public int ID { get; set; }
        public decimal Xoffset { get; set; }
        public decimal Yoffset { get; set; }
        public decimal Zoffset { get; set; }
        public DateTime dateTime { get; set; }
    }
}
