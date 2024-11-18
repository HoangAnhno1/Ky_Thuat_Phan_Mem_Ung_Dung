﻿using DeviceConfig.Views;
using KTPMUD.Models.MainWinModel;
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

namespace KTPMUD.Views.Home
{
    /// <summary>
    /// Interaction logic for IndexLayout.xaml
    /// </summary>
    public partial class IndexLayout : UserControl
    {
        public IndexLayout()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }

    public class Index : BaseView<IndexLayout, object> { }
}
