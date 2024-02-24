using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;

namespace UnCompiledXaml
{

public class DockPanelWindow : Window
{
    private Button button1;

    public void LoadXamlToThisWindow(string xamlFile)
    {
        // Configure the form.
        this.Width = this.Height = 285;
        this.Left = this.Top = 100;
        this.Title = "Loads DockPanel to this Window content";

        // Get the XAML content from an external file.
        DependencyObject rootElement;
        using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
        {
            rootElement = (DependencyObject)XamlReader.Load(fs);
        }

        this.Content = rootElement;

        //button1 = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");
        FrameworkElement frameworkElement = (FrameworkElement)rootElement;
        button1 = (Button)frameworkElement.FindName("button1");
        button1.Click += new RoutedEventHandler(button1_Click);
        }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        button1.Content = "Loaded DockPanel to this Window content";
    }
}
}