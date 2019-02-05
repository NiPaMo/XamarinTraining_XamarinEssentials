using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductDetail : ContentPage
    {
        public ProductDetail(Services.Product target)
        {
            InitializeComponent();
        }

        public ProductDetail(ProductDetail target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        private void OrderBtn_Clicked(object sender, EventArgs e)
        {
            var target = BindingContext as Product;
            Navigation.PushAsync(new OrderForm(
                new Order { ProductName = target.Name, Quantity = 1 }));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var prod = BindingContext as Product;

            ProductService.WishList.Add(prod);
        }
    }
}