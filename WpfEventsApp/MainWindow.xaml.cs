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

namespace WpfEventsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //btnHello.Click += btnHello_Click1;
        }

        //private void btnHello_Click(object sender, RoutedEventArgs e)
        //{
        //    txtBlock.Text += "Sender: " + ((Button)sender).Background.ToString() + "\n";
        //    txtBlock.Text += "Source: " + ((Button)e.Source).Background.ToString() + "\n";
        //    txtBlock.Text += "Origin Source: " + ((Button)e.OriginalSource).Background.ToString() + "\n\n";
        //}

        //private void btnHello_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if(sender is Button)
        //    {
        //        txtBlock.Text += "Sender: " + ((Button)sender).Background.ToString() + "\n";
        //        txtBlock.Text += "Source: " + ((Button)e.Source).Background.ToString() + "\n\n";
        //        //txtBlock.Text += "Origin Source: " + ((Button)e.OriginalSource).Background.ToString() + "\n\n";
        //    }
        //}

        //private void StackPanel_Checked(object sender, RoutedEventArgs e)
        //{
        //    txtBlock.Text += ((RadioButton)e.Source).Content.ToString() + "\n";
        //}

        private void StackPanel_GotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)e.Source).Text += "Hello ";
        }

        private void txtBoxDrop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(txtBoxDrop, txtBoxDrop.Text, DragDropEffects.Move);
        }

        private void Button_Drop(object sender, DragEventArgs e)
        {
            btnDrop.Content = e.Data.GetData(DataFormats.Text);
        }

        private void txtBoxDrop_KeyDown(object sender, KeyEventArgs e)
        {
            txtBlock.Text += e.Key.ToString() + " ";
        }

        //private void btnHello_Click1(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Event Handler in Constructor");
        //}
    }
}
