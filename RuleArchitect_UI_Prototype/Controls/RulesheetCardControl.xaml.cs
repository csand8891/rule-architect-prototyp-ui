using System.Windows;
using System.Windows.Controls;
using System.Windows.Input; // For ICommand
using MaterialDesignThemes.Wpf; // For PackIconKind

namespace RuleArchitect_UI_Prototype.Controls
{
    public partial class RulesheetCardControl : UserControl
    {
        // Header Properties
        public static readonly DependencyProperty HeaderIconKindProperty =
            DependencyProperty.Register("HeaderIconKind", typeof(PackIconKind), typeof(RulesheetCardControl), new PropertyMetadata(PackIconKind.FileDocumentOutline));
        public PackIconKind HeaderIconKind
        {
            get { return (PackIconKind)GetValue(HeaderIconKindProperty); }
            set { SetValue(HeaderIconKindProperty, value); }
        }

        public static readonly DependencyProperty HeaderTextProperty = // Could be bound to OptionName
            DependencyProperty.Register("HeaderText", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("Rulesheet"));
        public string HeaderText
        {
            get { return (string)GetValue(HeaderTextProperty); }
            set { SetValue(HeaderTextProperty, value); }
        }

        // Rulesheet Specific Data Properties
        public static readonly DependencyProperty OptionNameProperty = // This is the main name
            DependencyProperty.Register("OptionName", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("Unnamed Rulesheet"));
        public string OptionName
        {
            get { return (string)GetValue(OptionNameProperty); }
            set { SetValue(OptionNameProperty, value); }
        }

        public static readonly DependencyProperty ControlTypeProperty = // Renamed from ControlSystem for clarity based on your request
            DependencyProperty.Register("ControlType", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("N/A"));
        public string ControlType
        {
            get { return (string)GetValue(ControlTypeProperty); }
            set { SetValue(ControlTypeProperty, value); }
        }

        public static readonly DependencyProperty SpecCodesSummaryProperty = // NEW
            DependencyProperty.Register("SpecCodesSummary", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("No spec codes defined."));
        public string SpecCodesSummary
        {
            get { return (string)GetValue(SpecCodesSummaryProperty); }
            set { SetValue(SpecCodesSummaryProperty, value); }
        }

        public static readonly DependencyProperty ActivationRuleSummaryProperty = // NEW
            DependencyProperty.Register("ActivationRuleSummary", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("No activation rules."));
        public string ActivationRuleSummary
        {
            get { return (string)GetValue(ActivationRuleSummaryProperty); }
            set { SetValue(ActivationRuleSummaryProperty, value); }
        }

        public static readonly DependencyProperty SoftwareOptionNotesProperty = // Renamed from Notes for clarity
            DependencyProperty.Register("SoftwareOptionNotes", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata(string.Empty));
        public string SoftwareOptionNotes
        {
            get { return (string)GetValue(SoftwareOptionNotesProperty); }
            set { SetValue(SoftwareOptionNotesProperty, value); }
        }

        // --- Removed less relevant DPs from previous example like Version, PrimaryOptionNumber for this specific request ---
        // --- You can add them back if "at-a-glance" still needs them, or create more specific ones. ---
        // --- For instance, PrimaryOptionNumber might be very important "at-a-glance" ---

        public static readonly DependencyProperty VersionProperty =
    DependencyProperty.Register("Version", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("N/A"));

        public string Version
        {
            get { return (string)GetValue(VersionProperty); }
            set { SetValue(VersionProperty, value); }
        }
        public static readonly DependencyProperty PrimaryOptionNumberDisplayProperty =
           DependencyProperty.Register("PrimaryOptionNumberDisplay", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("N/A"));

        public string PrimaryOptionNumberDisplay
        {
            get { return (string)GetValue(PrimaryOptionNumberDisplayProperty); }
            set { SetValue(PrimaryOptionNumberDisplayProperty, value); }
        }


        // Action Properties
        public static readonly DependencyProperty ActionTextProperty =
            DependencyProperty.Register("ActionText", typeof(string), typeof(RulesheetCardControl), new PropertyMetadata("VIEW DETAILS"));
        public string ActionText
        {
            get { return (string)GetValue(ActionTextProperty); }
            set { SetValue(ActionTextProperty, value); }
        }

        public static readonly DependencyProperty ActionCommandProperty =
            DependencyProperty.Register("ActionCommand", typeof(ICommand), typeof(RulesheetCardControl), new PropertyMetadata(null));
        public ICommand ActionCommand
        {
            get { return (ICommand)GetValue(ActionCommandProperty); }
            set { SetValue(ActionCommandProperty, value); }
        }

        public static readonly DependencyProperty ActionCommandParameterProperty =
            DependencyProperty.Register("ActionCommandParameter", typeof(object), typeof(RulesheetCardControl), new PropertyMetadata(null));
        public object ActionCommandParameter
        {
            get { return (object)GetValue(ActionCommandParameterProperty); }
            set { SetValue(ActionCommandParameterProperty, value); }
        }

        public RulesheetCardControl()
        {
            InitializeComponent();
            // Optionally set default HeaderText to OptionName if not explicitly set
            // This requires OptionName to be set before HeaderText is used, or use a CoerceValueCallback
            // For simplicity, we'll bind HeaderText to OptionName in XAML or expect it to be set by consumer.
        }
    }
}