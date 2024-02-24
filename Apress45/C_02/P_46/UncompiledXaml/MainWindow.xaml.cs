using System.Diagnostics;
using FlowDocExample;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace UnCompiledXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_OnClick(object sender, RoutedEventArgs e)
        {
            // Create the Button.
            Button originalButton = new Button
            {
                Height = 50,
                Width = 100,
                Background = Brushes.AliceBlue,
                Content = "Click Me"
            };

            // Save the Button to a string.
            string savedButton = XamlWriter.Save(originalButton);
            /*
             <Button Background="#FFF0F8FF" 
                     Width="100" 
                     Height="50" 
                     xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation">
              Click Me
            </Button>
             */
            // Load the button
            StringReader stringReader = new StringReader(savedButton);
            XmlReader xmlReader = XmlReader.Create(stringReader);
            Button readerLoadButton = (Button)XamlReader.Load(xmlReader);
            Debugger.Break();
        }

        private void Button2_OnClick(object sender, RoutedEventArgs e)
        {
            StringReader sr = new StringReader(@"
        <Button Background='#FFF0F8FF' 
                    Width='100' 
                    Height='50' 
                    xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'>
            Click Me
        </Button>");
            XmlTextReader xr = new XmlTextReader(sr);
            Button button2 = (Button)XamlReader.Load(xr);
            Debugger.Break();
        }

        private void Button3_OnClick(object sender, RoutedEventArgs e)
        {
            FlowDocumentPageViewerWindow window  = new FlowDocumentPageViewerWindow();
            window.Show();
        }

        private void Button4_OnClick(object sender, RoutedEventArgs e)
        {
            FlowDocumentScrollViewerWindow window = new FlowDocumentScrollViewerWindow();
            window.Show();
        }

        private void Button5_OnClick(object sender, RoutedEventArgs e)
        {
            DockPanelWindow window = new DockPanelWindow();
            window.LoadXamlToThisWindow("DockPanel.xaml");
            window.Show();
        }

        private void Button6_OnClick(object sender, RoutedEventArgs e)
        {
            XamlFileWindow window = XamlFileWindow.LoadWindowFromXaml("XamlFileWindow.xaml");
            window.Show();
        }

        private void Button7_OnClick(object sender, RoutedEventArgs e)
        {
            Xaml2009Window window = Xaml2009Window.LoadWindowFromXaml("Xaml2009Window.xaml");
            window.Show();
        }
    }
}