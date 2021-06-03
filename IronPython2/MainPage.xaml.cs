using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace IronPythonSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            scope.SetVariable("count", 10);
            scope.SetVariable("sum", 0);
            string s = "for i in range(0, count):\n\tsum=sum+i\n";
            engine.Execute(s, scope);
            int sum = scope.GetVariable<int>("sum");

            MessageDialog dialog = new MessageDialog($"{sum}");
            await dialog.ShowAsync();
        }
    }
}
