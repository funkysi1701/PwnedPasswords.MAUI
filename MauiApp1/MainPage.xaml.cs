namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    public void TapGestureRecognizer_Tapped(object sender, TappedEventArgs args)
    {
        var url = (string)args.Parameter;
        Launcher.OpenAsync(new Uri(url));
    }
}
