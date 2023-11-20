using Products.ViewModels;

namespace Products.Views;

public partial class GridLayoutView : ContentPage
{
	public GridLayoutView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}