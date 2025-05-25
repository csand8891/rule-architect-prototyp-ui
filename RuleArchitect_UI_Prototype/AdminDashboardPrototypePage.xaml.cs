using RuleArchitect_UI_Prototype.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using RuleArchitect_UI_Prototype.ViewModels;

namespace RuleArchitect_UI_Prototype
{
    public partial class AdminDashboardPrototypePage : UserControl
    {
        public AdminDashboardPrototypePage()
        {
            InitializeComponent();
            // Set DataContext for runtime (important for prototype behavior)
            this.DataContext = new SampleAdminDashboardViewModel();
        }
    }
}
