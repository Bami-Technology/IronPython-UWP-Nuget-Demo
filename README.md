### IronPython-UWP-Nuget-Demo

This is an example of using the nuget packages `IronPython2.UWP.Unoffcial` and `IronPython3.UWP.Unoffcial`.

In the two projects, there will be a button test on the interface after startup. After clicking it, a `for i in range(0, count) expression` will be calculated. If you use the specially processed nuget package, it will crash in the release environment.


### Keycode In Demo
``` cs
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
```

### Progress


 - [x] IronPython2.UWP.Unoffcial
 - [ ] IronPython3.UWP.Unoffcial
