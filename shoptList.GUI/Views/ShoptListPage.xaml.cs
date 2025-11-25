using ShopListViewModels;

namespace shoptList.GUI.Views;

public partial class ShoptListPage : ContentPage
{
    public ShoptListPage()
    {
        InitializeComponent();
        BindingContext = new shopListViewModels();
    }
}