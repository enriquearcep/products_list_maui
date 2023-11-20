using Products.ViewModels;

namespace Products.Views;

public partial class LinearLayoutView : ContentPage
{
	public LinearLayoutView()
	{
		InitializeComponent();
		BindingContext = new ProductsViewModel();
	}
}