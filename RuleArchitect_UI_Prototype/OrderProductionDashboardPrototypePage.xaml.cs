﻿using System;
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
using RuleArchitect_UI_Prototype.ViewModels;

namespace RuleArchitect_UI_Prototype
{
    /// <summary>
    /// Interaction logic for OrderProductionDashboardPrototypePage.xaml
    /// </summary>
    public partial class OrderProductionDashboardPrototypePage : UserControl
    {
        public OrderProductionDashboardPrototypePage()
        {
            InitializeComponent();
            this.DataContext = new SampleOrderProductionViewModel();
        }
    }
}
