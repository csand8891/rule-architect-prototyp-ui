// In your RuleArchitect_UI_Prototype project (e.g., in a "ViewModels/DesignTime" folder)
using RuleArchitect_UI_Prototype.SampleData; // Assuming your sample classes are here
using System.Collections.ObjectModel;
using System.ComponentModel; // For INotifyPropertyChanged (optional for simple prototype)
using System.Runtime.CompilerServices;

namespace RuleArchitect_UI_Prototype.ViewModels // Or your preferred namespace
{
    public class SampleOrderProductionViewModel : INotifyPropertyChanged // Implement the interface
    {
        private SampleOrder _currentOrder;
        // If SampleRulesheetCards is a separate property on the ViewModel
        // private ObservableCollection<SampleRulesheetCard> _sampleRulesheetCards;

        public SampleOrder CurrentOrder
        {
            get => _currentOrder;
            set
            {
                if (_currentOrder != value)
                {
                    _currentOrder = value;
                    OnPropertyChanged();
                    // If SampleRulesheetCards is a separate property that depends on CurrentOrder,
                    // you might re-populate and notify its change here too.
                    // For simplicity, we assumed SampleRulesheetCards was part of CurrentOrder.
                }
            }
        }

        // If SampleRulesheetCards is a direct property of this ViewModel:
        // public ObservableCollection<SampleRulesheetCard> SampleRulesheetCards
        // {
        //     get => _sampleRulesheetCards;
        //     set
        //     {
        //         if (_sampleRulesheetCards != value)
        //         {
        //             _sampleRulesheetCards = value;
        //             OnPropertyChanged();
        //         }
        //     }
        // }


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

            // Populate the attached rulesheets for this specific sample order
            // (This assumes CurrentOrder.AttachedRulesheets is an ObservableCollection)
            CurrentOrder.AttachedRulesheets.Add(new SampleRulesheetCard
            {
                Id = 101,
                Name = "Main Processing Unit Logic",
                Version = "2.1 Rev B",
                ControlSystem = "System Titan",
                KeyParametersSummary = "CycleTime: 50ms; MaxTemp: 85C; Mode: Auto",
                PrimaryOptionNumberDisplay = "OPT-MPU-21B",
                NotesPreview = "Ensure all safety checks pass before initiating sequence..."
            });
            CurrentOrder.AttachedRulesheets.Add(new SampleRulesheetCard
            {
                Id = 102,
                Name = "Sensor Array Calibration",
                Version = "1.5",
                ControlSystem = "System Titan",
                KeyParametersSummary = "SensorType: Optical; Range: 0-5m; Accuracy: +/- 0.1mm",
                PrimaryOptionNumberDisplay = "OPT-SNS-CALIB",
                NotesPreview = "Calibration requires stable ambient temperature. Refer to section 4.2."
            });
            // Add more sample rulesheets as needed...

            // If SampleRulesheetCards is a separate property on this ViewModel:
            // SampleRulesheetCards = new ObservableCollection<SampleRulesheetCard>(CurrentOrder.AttachedRulesheets);
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Example of how you might change a property and notify the UI
        public void UpdateOrderStatus(string newStatus)
        {
            if (CurrentOrder != null && CurrentOrder.Status != newStatus)
            {
                CurrentOrder.Status = newStatus;
                // If CurrentOrder itself implements INotifyPropertyChanged for its 'Status' property,
                // and your XAML binds to CurrentOrder.Status, that binding would update.
                // If your XAML binds to a property on *this* ViewModel that reflects CurrentOrder.Status,
                // you would call OnPropertyChanged for *that* ViewModel property.
                // For simplicity, if CurrentOrder.Status is directly bound, and SampleOrder
                // implements INotifyPropertyChanged, this is fine.
                // If not, you might need to raise OnPropertyChanged for CurrentOrder itself if the whole object is replaced
                // or for specific proxy properties on this ViewModel.
                OnPropertyChanged(nameof(CurrentOrder)); // Notify that a property of CurrentOrder might have changed, or the CurrentOrder reference itself
            }
        }
    }
}
    