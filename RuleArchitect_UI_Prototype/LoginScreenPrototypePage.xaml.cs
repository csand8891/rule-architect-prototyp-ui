using RuleArchitect_UI_Prototype.ViewModels;
// Add the correct using for your SampleLoginViewModel

using System.Windows.Controls;

namespace RuleArchitect_UI_Prototype
{
    public partial class LoginScreenPrototypePage : UserControl
    {
        public LoginScreenPrototypePage()
        {
            InitializeComponent();
            // Set DataContext for runtime (important for prototype behavior)
            this.DataContext = new SampleLoginViewModel();
        }

        // Optional: If you want to simulate the login button click for the prototype
        // without fully implementing ICommand in the sample ViewModel
        private void LoginButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (this.DataContext is SampleLoginViewModel vm)
            {
                // For prototype, you might manually get password if not binding securely
                // vm.Password = PasswordBox.Password; // Example if you wanted to pass it
                vm.Login();
            }
        }
    }
}