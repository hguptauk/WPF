using System.Windows;
using System.Windows.Documents;

namespace UnCompiledXaml
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    // Example 14-16. Loading a FlowDocument into a viewer

    partial class FlowDocumentScrollViewerWindow : Window
    {
        public FlowDocumentScrollViewerWindow()
        {
            InitializeComponent();
            FlowDocumentScrollViewer1.Document = (FlowDocument)Application.LoadComponent(
                new Uri("MyFlowDocument.xaml", UriKind.Relative));
        }
    }


}