using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleArchitect_UI_Prototype.SampleData
{
    public class SampleRulesheetInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string ControlSystem { get; set; }
        public bool IsSelected { get; set; } // For selection in a list
        public string SpecCodeNo { get; set; }
        public string SpecCodeBit { get; set; }
        public string Category { get; set; }
        
        public override string ToString() => $"{Name} (v{Version}) - {ControlSystem}";
    }
}
