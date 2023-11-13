using Products.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Products.ViewModels
{
    public class ProductsViewModel : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Full properties
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get => _products;

            set
            {
                if (_products != value)
                {
                    _products = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Products)));
                }
            }
        }

        private bool _isRefreshing;

        public bool IsRefreshing
        {
            get => _isRefreshing;

            set
            {
                if(_isRefreshing != value)
                {
                    _isRefreshing = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRefreshing)));
                }
            }
        }
        #endregion

        #region Commands
        public ICommand RefreshCommand => new Command(async () =>
        {
            IsRefreshing = true;

            await Task.Delay(3000);

            RefreshProducts();

            IsRefreshing = false;
        });

        public ICommand ThresholdReachedCommand => new Command(async () =>
        {
            RefreshProducts(Products.Count);
        });

        public ICommand DeleteCommand => new Command((product) =>
        {
            Products.Remove(product as Product);
        });
        #endregion

        #region Constructors
        public ProductsViewModel()
        {
            Products = new ObservableCollection<Product>();

            RefreshProducts();
        }
        #endregion

        #region Methods
        private void RefreshProducts(int lastIndex = 0)
        {
            if(lastIndex == 0)
            {
                Products = new ObservableCollection<Product>();
            }

            int itemsPerPage = 10;

            var items = new ObservableCollection<Product>()
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
                },

                new Product()
                {
                    Name = "Echo Dot",
                    Price = 1215,
                    HasOffer = false,
                    Stock = 54
                },
                new Product()
                {
                    Name = "Cable HDMI 3m",
                    Price = 215,
                    HasOffer = true,
                    OfferPrice = 188,
                    Stock = 20
                },
                new Product()
                {
                    Name = "Audífonos JBL",
                    Price = 780,
                    HasOffer = true,
                    OfferPrice = 699,
                    Stock = 2
                },
                new Product()
                {
                    Name = "Porta cables",
                    Price = 100,
                    HasOffer = true,
                    OfferPrice = 70,
                    Stock = 65
                },
                new Product()
                {
                    Name = "Tenis Lacoste",
                    Price = 1800,
                    HasOffer = false,
                    Stock = 5
                },
                new Product()
                {
                    Name = "Micro SD 128GB",
                    Price = 130,
                    HasOffer = false,
                    Stock = 200
                },
                new Product()
                {
                    Name = "Pintura blanca 3L",
                    Price = 180,
                    HasOffer = false,
                    Stock = 15
                },
                new Product()
                {
                    Name = "Collar mediando p/p",
                    Price = 120,
                    HasOffer = true,
                    OfferPrice = 105,
                    Stock = 120
                },
                new Product()
                {
                    Name = "Almohada T600",
                    Price = 280,
                    HasOffer = false,
                    Stock = 6
                },
                new Product()
                {
                    Name = "Teclado Logitech",
                    Price = 400,
                    HasOffer = true,
                    OfferPrice = 389,
                    Stock = 20
                },
                new Product()
                {
                    Name = "Stream Deck 15t",
                    Price = 2900,
                    HasOffer = false,
                    Stock = 1
                },
                new Product()
                {
                    Name = "Bivlia RV 1960",
                    Price = 1000,
                    HasOffer = false,
                    Stock = 16
                },
                new Product()
                {
                    Name = "Mouse Logitech",
                    Price = 215,
                    HasOffer = false,
                    Stock = 10
                },
                new Product()
                {
                    Name = "Silla Gamer",
                    Price = 6900,
                    HasOffer = true,
                    OfferPrice = 5500,
                    Stock = 2
                },
                new Product()
                {
                    Name = "Escritorio CC",
                    Price = 1800,
                    HasOffer = false,
                    Stock = 1
                },
                new Product()
                {
                    Name = "Plumones T55",
                    Price = 180,
                    HasOffer = true,
                    OfferPrice = 120,
                    Stock = 20
                }
            };

            var pageItems = items.Skip(lastIndex).Take(itemsPerPage).ToList();

            foreach (var item in pageItems)
            {
                Products.Add(item);
            }
        }
        #endregion
    }
}