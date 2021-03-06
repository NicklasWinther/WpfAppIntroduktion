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
using WpfAppIntroduktion.BIZ;

namespace WpfAppIntroduktion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBiz classBiz = new ClassBiz();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearList(ListBox listBox)
        {
            if (listBox.ItemsSource != null)
            {
                listBox.ItemsSource = null;
            }
            listBox.Items.Clear();
        }

        private void buttonOpg12_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.Number4711(listBoxRes);
        }

        private void buttonOpg13_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.RandomNumbers(listBoxRes);
        }

        private void buttonOpg14_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.RandomSortedNumbers(listBoxRes);
        }

        private void buttonOpg15_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.RandomNumbersSortedAndUnsorted(listBoxRes);
        }

        private void buttonOpg16_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.GetAverage(listBoxRes);
        }

        private void buttonOpg17_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.GetAverageAndSubtract(listBoxRes);
        }

        private void buttonOpg18_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            listBoxRes.ItemsSource = classBiz.GetAverageAndSubtract();
        }

        private void buttonOpg19_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.GetAverageSubtractAndColor(listBoxRes);
        }

        private void buttonOpg110_Click(object sender, RoutedEventArgs e)
        {
            ClearList(listBoxRes);
            classBiz.GetAverageSubtractAndColorWithItemsSource(listBoxRes);
        }
    }
}
