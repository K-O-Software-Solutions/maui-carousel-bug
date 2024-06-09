namespace maui_carousel_bug;

public partial class MainPage : ContentPage
{
  public MainPage()
  {
    InitializeComponent();

    carouselView.ItemsSource = new List<string>
    {
      "Item 1",
      "Item 2",
      "Item 3"
    };
  }
}

