using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UncompiledXaml
{
public class Program : Application
{
    [STAThread()]
    static void Main()
    {
        // Create a program that will show two different windows,
        // and will wait until both are closed before ending.
        Program app = new Program();
        app.ShutdownMode = ShutdownMode.OnLastWindowClose;

        //// First approach: Create window object and assign window.content = XAML content from XamlFile.xaml.
        DockPanelWindow window1 = new DockPanelWindow();
        window1.LoadXamlToThisWindow("DockPanel.xaml");
        window1.Show();

        //// Second approach: XAML for complete window.  
        XamlFileWindow window2 = XamlFileWindow.LoadWindowFromXaml("XamlFileWindow.xaml");
        window2.Show();

                      
        //Xaml2009Window window3 = Xaml2009Window.LoadWindowFromXaml("Xaml2009Window.xaml");
        //window3.Show();

        app.Run();
    }
}
}
