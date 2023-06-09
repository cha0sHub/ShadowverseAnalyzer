﻿using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using System.Windows.Controls;

namespace ShadowverseAnalyzer.WPF.Views
{
    /// <summary>
    /// Interaction logic for PackSimulatorVIew.xaml
    /// </summary>
    public partial class PackSimulatorView : Grid, IPackSimulatorView
    {

        private IPackSimulatorController Controller { get; }

        public PackSimulatorView(IPackSimulatorController controller)
        {
            Controller = controller;
            DataContext = controller;
            Controller.SetView(this);

            InitializeComponent();
        }
    }
}
