using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Windows.Themes;

namespace window7
{
    public abstract class Dictionary1 : Window
    {
        public Dictionary1()
        {
            Initialized += WindowBaseInitialized;
        }

        private void WindowBaseInitialized(object sender, System.EventArgs e)
        {
            SetResourceReference(Window.StyleProperty, "Window");
            ResourceDictionary resource = new ResourceDictionary();
            ////resource.Source = new Uri("pack://application:,,,/WindowResource.xaml");
          //  this.Resources.MergedDictionaries.Add(resource);

            SystemDropShadowChrome dropShadow = new SystemDropShadowChrome();
            dropShadow.SetResourceReference(Control.StyleProperty, "WindowShadow");

            Border windowBorder = new Border();
            windowBorder.SetResourceReference(Control.StyleProperty, "WindowBorder");
            dropShadow.Child = windowBorder;

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(40.0) });
            grid.RowDefinitions.Add(new RowDefinition());
            windowBorder.Child = grid;

            Border headerBorder = new Border();
            headerBorder.SetResourceReference(Control.StyleProperty, "HeaderBorder");
            headerBorder.MouseLeftButtonDown += DragWindow;
            grid.Children.Add(headerBorder);
            Grid.SetRow(headerBorder, 0);

            ContentPresenter contentPresenter = new ContentPresenter();
            contentPresenter.Content = this.Content;
            grid.Children.Add(contentPresenter);
            Grid.SetRow(contentPresenter, 1);

            this.Content = dropShadow;
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}