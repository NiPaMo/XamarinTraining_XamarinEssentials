using HPlusSports.Services;
using Xamarin.Forms;

namespace HPlusSports
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
        //    Navigation.PushAsync(new ProductDetail());
        //}

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Product target = e.Item as Product;
            Navigation.PushAsync(new ProductDetail(target));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var products = await ProductService.GetProductsAsync();
            BindingContext = products;
        }
    }
}
