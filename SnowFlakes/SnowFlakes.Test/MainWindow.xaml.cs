﻿using System.Windows;
using Ak.Wpf.SnowFlakes;

namespace SnowFlakes.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Snowfall snow = new Snowfall(DrawingCanvas);
            snow.Start();
        }
    }
}
