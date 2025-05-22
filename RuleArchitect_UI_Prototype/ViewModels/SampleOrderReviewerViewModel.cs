using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq; // For LINQ operations
using RuleArchitect_UI_Prototype.SampleData;
using System; // For Random

namespace RuleArchitect_UI_Prototype.ViewModels
{
    public class SampleOrderReviewerViewModel : INotifyPropertyChanged
    {
        private SampleOrderReviewItem _selectedOrder;
        public SampleOrderReviewItem SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                if (_selectedOrder != value)
                {
                    _selectedOrder = value;
                    OnPropertyChanged();
                    LoadAvailableRulesheetsForSelectedOrder(); // Refresh available list
                }
            }
        }

        public ObservableCollection<SampleOrderReviewItem> MyOrders { get; set; }
        public ObservableCollection<SampleRulesheetInfo> AvailableRulesheets { get; set; } // For the "Add Rulesheet" dialog/panel
        public ObservableCollection<string> OrderStatuses { get; set; }


        // Mock list of all possible rulesheets in the system
        private ObservableCollection<SampleRulesheetInfo> _allSystemRulesheets;

        public SampleOrderReviewerViewModel()
        {
            MyOrders = new ObservableCollection<SampleOrderReviewItem>();
            AvailableRulesheets = new ObservableCollection<SampleRulesheetInfo>();
            OrderStatuses = new ObservableCollection<string> { "Draft", "Pending Review", "Ready for Production", "On Hold" };

            InitializeSampleData();

            if (MyOrders.Any())
            {
                SelectedOrder = MyOrders[0];
            }
            else
            {
                CreateNewOrder(); // Start with a new order if list is empty
            }
        }

        private void InitializeSampleData()
        {
            _allSystemRulesheets = new ObservableCollection<SampleRulesheetInfo>
            {
                new SampleRulesheetInfo { Id = 1, Name = "Main Controller Logic", Version = "1.2a", ControlSystem = "System Alpha" },
                new SampleRulesheetInfo { Id = 2, Name = "Safety Interlocks", Version = "2.0", ControlSystem = "System Alpha" },
                new SampleRulesheetInfo { Id = 3, Name = "HMI Display Logic", Version = "1.0", ControlSystem = "System Beta" },
                new SampleRulesheetInfo { Id = 4, Name = "Network Comms", Version = "3.1", ControlSystem = "System Alpha" },
                new SampleRulesheetInfo { Id = 5, Name = "Advanced PID Control", Version = "1.5", ControlSystem = "System Gamma" },
                new SampleRulesheetInfo { Id = 6, Name = "Data Logging Module", Version = "2.2", ControlSystem = "System Beta" }
            };

            var order1 = new SampleOrderReviewItem
            {
                ExternalSalesOrderId = "SO-2025-001",
                CustomerName = "Customer X",
                Status = "Draft",
                Notes = "Initial draft for project Omega."
            };
            order1.AttachedRulesheets.Add(_allSystemRulesheets[0]);
            order1.AttachedRulesheets.Add(_allSystemRulesheets[2]);
            MyOrders.Add(order1);

            var order2 = new SampleOrderReviewItem
            {
                ExternalSalesOrderId = "SO-2025-002",
                CustomerName = "Customer Y",
                Status = "Pending Review",
                Notes = "Needs final check on attached rulesheets."
            };
            order2.AttachedRulesheets.Add(_allSystemRulesheets[1]);
            MyOrders.Add(order2);
        }

        private void LoadAvailableRulesheetsForSelectedOrder()
        {
            AvailableRulesheets.Clear();
            if (SelectedOrder == null) return;

            foreach (var systemSheet in _allSystemRulesheets)
            {
                // Add only if not already attached to the currently selected order
                if (!SelectedOrder.AttachedRulesheets.Any(attached => attached.Id == systemSheet.Id))
                {
                    AvailableRulesheets.Add(new SampleRulesheetInfo // Create new instances for selection state
                    {
                        Id = systemSheet.Id,
                        Name = systemSheet.Name,
                        Version = systemSheet.Version,
                        ControlSystem = systemSheet.ControlSystem,
                        IsSelected = false
                    });
                }
            }
        }

        // Placeholder for commands (in a real app these would be ICommand)
        public void CreateNewOrder()
        {
            var newOrder = new SampleOrderReviewItem
            {
                ExternalSalesOrderId = "SO-NEW-" + new Random().Next(100, 999), // Placeholder ID
                CustomerName = "New Customer",
                Status = "Draft"
            };
            MyOrders.Add(newOrder);
            SelectedOrder = newOrder;
        }

        public void AddSelectedRulesheetsToOrder()
        {
            if (SelectedOrder == null) return;
            var sheetsToAdd = AvailableRulesheets.Where(s => s.IsSelected).ToList();
            foreach (var sheet in sheetsToAdd)
            {
                if (!SelectedOrder.AttachedRulesheets.Any(rs => rs.Id == sheet.Id))
                {
                    SelectedOrder.AttachedRulesheets.Add(new SampleRulesheetInfo // Add a copy or the original, depending on design
                    {
                        Id = sheet.Id,
                        Name = sheet.Name,
                        Version = sheet.Version,
                        ControlSystem = sheet.ControlSystem
                    });
                }
            }
            LoadAvailableRulesheetsForSelectedOrder(); // Refresh the available list
        }

        public void RemoveRulesheetFromOrder(SampleRulesheetInfo rulesheetToRemove)
        {
            if (SelectedOrder != null && rulesheetToRemove != null)
            {
                SelectedOrder.AttachedRulesheets.Remove(rulesheetToRemove);
                LoadAvailableRulesheetsForSelectedOrder(); // Refresh the available list
            }
        }

        public void MarkOrderReady()
        {
            if (SelectedOrder != null)
            {
                SelectedOrder.Status = "Ready for Production";
                // In a real app, save changes
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}