﻿using CPSC481.Models;
using CPSC481.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CPSC481
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = _viewModel;
        }

        private void PrimaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.LoadSecondaryCategories((string)PrimaryCategoryList.SelectedItem);
        }

        private void SecondaryCategoryList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
