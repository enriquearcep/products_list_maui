using Products.Models;
using System.Collections.ObjectModel;

namespace Products.ViewModels
{
    public class ProductsViewModel
    {
        #region Properties
        public ObservableCollection<Product> Products { get; set; }
        #endregion

        #region Constructors
        public ProductsViewModel()
        {
            Products = new ObservableCollection<Product>()
            {
                new Product()
                {
                    Name = "Taza Harry Potter",
                    Price = 85,
                    HasOffer = false,
                    Stock = 32
                },
                new Product()
                {
                    Name = "Par de Baterías AA",
                    Price = 79,
                    HasOffer = false,
                    Stock = 101
                },
                new Product()
                {
                    Name = "Cargador tipo C",
                    Price = 145,
                    HasOffer = true,
                    OfferPrice = 105,
                    Stock = 8
                },
                new Product()
                {
                    Name = "Tapete para yoga 2m",
                    Price = 220,
                    HasOffer = false,
                    Stock = 12
                },
                new Product()
                {
                    Name = "Cubo Rubik",
                    Price = 120,
                    HasOffer = true,
                    OfferPrice = 80,
                    Stock = 15
                },
                new Product()
                {
                    Name = "Tablero de Ajedrez",
                    Price = 200,
                    HasOffer = false,
                    Stock = 12
                },
                new Product()
                {
                    Name = "Kit de desarmadores",
                    Price = 310,
                    HasOffer = false,
                    Stock = 5
                },
                new Product()
                {
                    Name = "Guitarra acústica",
                    Price = 850,
                    HasOffer = false,
                    Stock = 6
                },
                new Product()
                {
                    Name = "Agenda 2024",
                    Price = 520,
                    HasOffer = true,
                    OfferPrice = 400,
                    Stock = 10
                },
                new Product()
                {
                    Name = "Ext eléctrica 6e",
                    Price = 120,
                    HasOffer = false,
                    Stock = 105
                },
                new Product()
                {
                    Name = "Paquete 500 hojas blancas",
                    Price = 412,
                    HasOffer = true,
                    OfferPrice = 380,
                    Stock = 6
                },
                new Product()
                {
                    Name = "Bolígrafo R54",
                    Price = 160,
                    HasOffer = true,
                    OfferPrice = 150,
                    Stock = 35
                },
                new Product()
                {
                    Name = "20m cable RJ45",
                    Price = 310,
                    HasOffer = true,
                    OfferPrice = 250,
                    Stock = 6
                },
                new Product()
                {
                    Name = "Pintura negra 3L",
                    Price = 180,
                    HasOffer = false,
                    Stock = 12
                },
                new Product()
                {
                    Name = "Correa 4m",
                    Price = 100,
                    HasOffer = true,
                    OfferPrice = 95,
                    Stock = 36
                }
            };
        }
        #endregion
    }
}