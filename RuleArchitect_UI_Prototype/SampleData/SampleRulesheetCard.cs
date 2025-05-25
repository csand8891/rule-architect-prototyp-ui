namespace RuleArchitect_UI_Prototype.SampleData
{
    public class SampleRulesheetCard
    {
        public int Id { get; set; }
        public string Name { get; set; } // Will map to OptionName
        public string ControlSystem { get; set; } // Will map to ControlType
        public string SpecCodesSummary { get; set; }
        public string ActivationRuleSummary { get; set; }
        public string Notes { get; set; } // Will map to SoftwareOptionNotes
        public string PrimaryOptionNumberDisplay { get; set; } // For PrimaryOptionNumber
        public string Version { get; set; } // If you still want to show version explicitly
    }
}