using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace HelloWorld
{
    [Transaction(TransactionMode.Manual)]
    public class HelloWorldCommand : IExternalCommand
    {
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            // Display a simple message box
            MessageBox.Show("Hello world","Revit API 2024", MessageBoxButton.OK,MessageBoxImage.Information);
            return Result.Succeeded;
        }
    }
}
