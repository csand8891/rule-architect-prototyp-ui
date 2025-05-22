using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleArchitect_UI_Prototype.SampleData // Or your preferred namespace for sample data
{
    public class SampleRulesheetCard
    {
        public int Id { get; set; } // Could be the SoftwareOptionId
        public string Name { get; set; }
        public string Version { get; set; }
        public string ControlSystem { get; set; }
        public string KeyParametersSummary { get; set; } // A summarized string of important params
        public string PrimaryOptionNumberDisplay { get; set; }
        public string NotesPreview { get; set; } // Maybe first few lines of notes
        // Add any other critical at-a-glance info for the production user
    }
}
