using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FlowDocExample
{
    /// <summary>
    /// Interaction logic for PageViewer.xaml
    /// </summary>

public partial class FlowDocumentPageViewerWindow : System.Windows.Window
{

public FlowDocumentPageViewerWindow()
{
    InitializeComponent();
    FlowDocumentPageViewer1.Document = (FlowDocument) Application.LoadComponent(
        new Uri("MyFlowDocument.xaml", UriKind.Relative));
}

}
}