﻿using DeviceConfig.Views;
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

namespace KTPMUD.Views.CoSoGietMo
{
    /// <summary>
    /// Interaction logic for CoSoGietMoLayout.xaml
    /// </summary>
    public partial class CoSoGietMoLayout : UserControl
    {
        public CoSoGietMoLayout()
        {
            InitializeComponent();
        }
    }
    public class Index : BaseView<CoSoGietMoLayout, object> { }
}