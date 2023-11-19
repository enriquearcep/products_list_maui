using Products.ViewModels;

namespace Products.Views;

public partial class LayoutView : ContentPage
{
	public LayoutView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}