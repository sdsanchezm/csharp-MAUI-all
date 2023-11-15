# .Net MAUI documentation

## Pages, Layout and Views

- Page: Pre-defined structures of the app
    - [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage?view=net-maui-8.0]
- Layout: Organize components
    - [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/layouts/?view=net-maui-8.0]
- Views: components
    - [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/controls/contentview?view=net-maui-8.0]

~~~mermaid
flowchart TD
    Pages --> Layouts
    Layouts --> Views
~~~

### Pages

#### ContentPage

- [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/contentpage?view=net-maui-8.0]

```
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyMauiApp.MyPage"
             Title="MyPage"
             BackgroundColor="White">
    <StackLayout>
        <Label Text="Welcome to .NET MAUI!"
                VerticalOptions="Center"
                HorizontalOptions="Center" />
        <!-- Other views go here -->
    </StackLayout>
</ContentPage>
```

#### FlyoutPage




#### NavigationPage

- [https://learn.microsoft.com/en-us/dotnet/maui/user-interface/pages/navigationpage?view=net-maui-8.0]

#### TabbedPage

- [https://learn.microsoft.com/en-us/dotnet/api/microsoft.maui.controls.tabbedpage?view=net-maui-8.0]


### DataTemplates

- [https://learn.microsoft.com/en-us/dotnet/maui/fundamentals/datatemplate?view=net-maui-8.0]



### Pages 






