﻿using ApiRestLucas.persistence;
using System.Windows;

namespace ApiRestLucas
{
   
    public partial class AddObject : Window
    {
        private MainWindow _mainWindow;

        public AddObject(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            ApiobjectManage apiObjectManage = new ApiobjectManage();
            apiObjectManage.addObject(_mainWindow, this);
        }
    }
}

