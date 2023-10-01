using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBaseClass
{
    internal class ToolAtribute
    {
        public int ID { get; set; }
        public int ToolNumber { get; set; }
        public string ToolName { get; set; }
        public ToolTypeEnum ToolType { get; set; }
        public string OnMachine { get; set; }
    }
}
