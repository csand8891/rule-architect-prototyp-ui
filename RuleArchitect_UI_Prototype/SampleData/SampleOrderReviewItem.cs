using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RuleArchitect_UI_Prototype.SampleData
{
    public class SampleOrderReviewItem : INotifyPropertyChanged
    {
        private string _externalSalesOrderId;
        public string ExternalSalesOrderId
        {
            get => _externalSalesOrderId;
            set { _externalSalesOrderId = value; OnPropertyChanged(); }
        }

        private string _customerName;
        public string CustomerName
        {
            get => _customerName;
            set { _customerName = value; OnPropertyChanged(); }
        }

        private DateTime _dueDate;
        public DateTime DueDate
        {
            get => _dueDate;
            set { _dueDate = value; OnPropertyChanged(); }
        }

        private string _status;
        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        private string _notes;
        public string Notes
        {
            get => _notes;
            set { _notes = value; OnPropertyChanged(); }
        }

        public ObservableCollection<SampleRulesheetInfo> AttachedRulesheets { get; set; }

        public SampleOrderReviewItem()
        {
            AttachedRulesheets = new ObservableCollection<SampleRulesheetInfo>();
            DueDate = DateTime.Now.AddDays(14); // Default due date
            Status = "Draft";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}