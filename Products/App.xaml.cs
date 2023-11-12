using Products.Views;

namespace Products
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProductsView();
        }
    }
}