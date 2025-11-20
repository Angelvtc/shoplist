using shoptList.GUI.ViewModels;

namespace shoptList.GUI.Views;

public partial class ShoptListPage : ContentPage
{
    public ShoptListPage()
    {
        InitializeComponent();
        BindingContext = new shoplistViewModels();
    }
}