using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel; // For ObservableCollection if rulesheets are part of the order object directly for sample data

namespace RuleArchitect_UI_Prototype.SampleData // Or your preferred namespace
{
    public class SampleOrder
    {
        public string OrderId { get; set; } // e.g., "ORD12345" (from external sales order)
        public string CustomerName { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // e.g., "Ready for Production"
        public string AssignedTo { get; set; } // e.g., "Production Team A" or current user
        public string Notes { get; set; }

        // This collection of rulesheets is specific to THIS sample order.
        // Your SampleOrderProductionViewModel will likely hold the master list of cards
        // and this might just contain IDs or be populated from the ViewModel's master list.
        // For simple prototyping, you can embed it here.
        public ObservableCollection<SampleRulesheetCard> AttachedRulesheets { get; set; }

        public SampleOrder()
        {
            AttachedRulesheets = new ObservableCollection<SampleRulesheetCard>();
        }
    }
}
