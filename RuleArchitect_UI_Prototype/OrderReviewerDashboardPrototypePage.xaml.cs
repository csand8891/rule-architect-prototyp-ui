using RuleArchitect_UI_Prototype.ViewModels;
using System.Windows; // For RoutedEventArgs
using System.Windows.Controls;

namespace RuleArchitect_UI_Prototype
{
    public partial class OrderReviewerDashboardPrototypePage : UserControl
    {
        private SampleOrderReviewerViewModel _viewModel;

        public OrderReviewerDashboardPrototypePage()
        {
            InitializeComponent();
            _viewModel = new SampleOrderReviewerViewModel(); // Create instance of the sample VM
            this.DataContext = _viewModel; // Set it as DataContext for runtime
        }

        // Example Click handlers if not using ICommand in prototype VM fully
        // These would call methods on _viewModel
        private void CreateNewOrder_Click(object sender, RoutedEventArgs e)
        {
            _viewModel?.CreateNewOrder();
        }

        private void AddRulesheetsDialog_Opened(object sender, MaterialDesignThemes.Wpf.DialogOpenedEventArgs eventArgs)
        {
            // This event fires when the dialog opens.
            // The ListBox for AvailableRulesheets should already be bound correctly
            // in the XAML using RelativeSource to the UserControl's DataContext (which is _viewModel).
            // _viewModel.LoadAvailableRulesheetsForSelectedOrder(); // This is now called when SelectedOrder changes
        }

        private void AttachSelected_Click(object sender, RoutedEventArgs e)
        {
            _viewModel?.AddSelectedRulesheetsToOrder();
            // DialogHost.CloseDialogCommand will be executed by the button itself
            // if CommandParameter is correctly set as shown in XAML.
        }

        private void MarkReady_Click(object sender, RoutedEventArgs e)
        {
            _viewModel?.MarkOrderReady();
        }
    }
}