using Products.ViewModels;

namespace Products.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}