// In your RuleArchitect_UI_Prototype project (e.g., in a "ViewModels/DesignTime" folder)
using RuleArchitect_UI_Prototype.SampleData; // Assuming your sample classes are here
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RuleArchitect_UI_Prototype.ViewModels // Or your preferred namespace
{
    public class SampleOrderProductionViewModel : INotifyPropertyChanged
    {
        private SampleOrder _currentOrder;

        public SampleOrder CurrentOrder
        {
            get => _currentOrder;
            set
            {
                if (_currentOrder != value)
                {
                    _currentOrder = value;
                    OnPropertyChanged();
                }
            }
        }

        public SampleOrderProductionViewModel()
        {
            // Create a sample order
            CurrentOrder = new SampleOrder
            {
                OrderId = "SALES-ORD-78901",
                CustomerName = "Acme Corp",
                DueDate = System.DateTime.Now.AddDays(7),
                Status = "Ready for Production",
                AssignedTo = "John Doe (Production)",
                Notes = "Handle with care, requires specific calibration sequence as per attached rulesheets."
            };

            // Populate the attached rulesheets using data from test-rulesheets.txt
            // (This assumes CurrentOrder.AttachedRulesheets is an ObservableCollection)

            // Rulesheet 1: Barfeeder Interface from test-rulesheets.txt
            CurrentOrder.AttachedRulesheets.Add(new SampleRulesheetCard
            {
                Id = 101,
                Name = "Barfeeder Interface",         // Maps to OptionName & HeaderText in the card
                ControlSystem = "P300L",             // Maps to ControlType
                PrimaryOptionNumberDisplay = "M8259",// Maps to PrimaryOptionNumberDisplay
                SpecCodesSummary = "PLC1 No.19 Bit0 (Bar Feeder I/F 1), PLC1 No.20 Bit0 (BF/PC Switch)", // Example summary
                ActivationRuleSummary = "MainRule: Barfeeder I/F 1=ON, BF/PC Bit Change 1=ON", // Example summary
                Notes = "Initial notes for barfeeder setup and safety checks.", // Maps to SoftwareOptionNotes
                Version = "1.0"
            });

            CurrentOrder.AttachedRulesheets.Add(new SampleRulesheetCard
            {
                Id = 102,
                Name = "THINC Alarm",
                ControlSystem = "P300L",
                PrimaryOptionNumberDisplay = "M8532",
                SpecCodesSummary = "NCB1 No.4 Bit3 (THINC Alarm), PLC2 No.22 Bit7 (THINC Alarm)",
                ActivationRuleSummary = "DefaultRule: Force spec codes on",
                Notes = "Ensure alarm notifications are correctly routed.",
                Version = "1.1"
            });

            // You can add more sample rulesheets here if needed, or if your text file had more.
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateOrderStatus(string newStatus)
        {
            if (CurrentOrder != null && CurrentOrder.Status != newStatus)
            {
                CurrentOrder.Status = newStatus;
                OnPropertyChanged(nameof(CurrentOrder));
            }
        }
    }
}