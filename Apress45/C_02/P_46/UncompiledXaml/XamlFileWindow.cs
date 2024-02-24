using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.IO;

namespace UnCompiledXaml
{
public class XamlFileWindow : Window
{
        
    public static XamlFileWindow LoadWindowFromXaml(string xamlFile)
    {
        // Get the XAML content from an external file.            
        using (FileStream fs = new FileStream(xamlFile, FileMode.Open))
        {
            XamlFileWindow window = (XamlFileWindow)XamlReader.Load(fs);
            return window;
        }            
    }

    private void button1_Click(object sender, RoutedEventArgs e)
    {
        Button button1 = (Button)LogicalTreeHelper.FindLogicalNode(this, "button1");
        //Button button1 = (Button)sender;
        button1.Content = "Thank you.";
    }
}

   
   

}



