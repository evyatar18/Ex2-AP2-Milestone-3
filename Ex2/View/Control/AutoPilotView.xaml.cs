﻿using Ex2.ViewModels;
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

namespace Ex2.View
{
    /// <summary>
    /// Interaction logic for AutoPilotView.xaml
    /// </summary>
    public partial class AutoPilotView : UserControl
    {
        private AutoPilotVM vm;
        public AutoPilotView()
        {
            InitializeComponent();
            vm = new AutoPilotVM();
            DataContext = vm;
        }
    }
}
