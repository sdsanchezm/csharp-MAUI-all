namespace MauiAppTabbedMenu;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // MainPage = new AppShell();
        //MainPage = new Views.TabbedMenu.TabbedPageSample();
        //MainPage = new Views.TabbedMenu2.TabbedPageSample();
        MainPage = new Views.TabbedMenu3.MainPageTabbedMenu();
    }
}
