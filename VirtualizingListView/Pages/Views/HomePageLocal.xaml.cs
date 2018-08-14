﻿using Common.FileHelper;
using Common.Interfaces;
using System;
using System.Collections.Generic;
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
using VirtualizingListView.Pages.Model;
using VirtualizingListView.Pages.ViewModel;
using VirtualizingListView.View;

namespace VirtualizingListView.Pages
{
    /// <summary>
    /// Interaction logic for HomePageLocal.xaml
    /// </summary>
    public partial class HomePageLocal : Page,IMainPages
    {
        private static HomePlaylistView stplaylistcontrol;
        public static HomePlaylistView PlaylistControl
        {
            get { return stplaylistcontrol; }
        }

        public bool HasController { get { return WindowCommandButton != null; } }

        public ContentControl Docker { get { return HomePageDock; } }

        private IWindowsCommandButton WindowCommandButton;

        public HomePageLocal()
        {
            InitializeComponent();
            this.DataContext = new HomePageLocalViewModel(this);
            this.Loaded += HomePageLocal_Loaded;
            stplaylistcontrol = this.playlistcontrol;
        }

        private void HomePageLocal_Loaded(object sender, RoutedEventArgs e)
        {
            var datacontext = (HomePageLocalViewModel)this.DataContext;
            datacontext.InitDataSource();
            if (WindowCommandButton != null)
                WindowCommandButton.SetActive(true, false);
        }
        
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        public void SetController(IWindowsCommandButton controller)
        {
            this.WindowCommandButton = controller;
        }
    }
}
