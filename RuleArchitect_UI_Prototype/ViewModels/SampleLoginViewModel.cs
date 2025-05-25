using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RuleArchitect_UI_Prototype.ViewModels // Adjust namespace as needed
{
    public class SampleLoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(); }
        }

        private string _password;
        public string Password // Note: In a real app, PasswordBox doesn't bind directly to a string for security
        {
            get => _password;
            set { _password = value; OnPropertyChanged(); }
        }

        private bool _rememberMe;
        public bool RememberMe
        {
            get => _rememberMe;
            set { _rememberMe = value; OnPropertyChanged(); }
        }

        private string _errorMessage;
        public string ErrorMessage
        {
            get => _errorMessage;
            set { _errorMessage = value; OnPropertyChanged(); }
        }

        private bool _isLoggingIn;
        public bool IsLoggingIn
        {
            get => _isLoggingIn;
            set { _isLoggingIn = value; OnPropertyChanged(); }
        }

        // Placeholder for LoginCommand (in a real app, this would be ICommand)
        public void Login()
        {
            IsLoggingIn = true;
            // Simulate login attempt
            if (Username == "test" && Password == "test")
            {
                ErrorMessage = null;
                // Simulate success, then clear IsLoggingIn
                // In a real app, navigate or raise event
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
            // IsLoggingIn = false; // Simulate end of attempt
        }


        public SampleLoginViewModel()
        {
            Username = "user@example.com";
            RememberMe = true;
            // ErrorMessage = "This is a sample error message."; // Uncomment to see error styling
            IsLoggingIn = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}