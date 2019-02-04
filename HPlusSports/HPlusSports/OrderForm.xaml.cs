using HPlusSports.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlusSports
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderForm : TabbedPage
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var order = BindingContext as Order;
            DisplayAlert("Order Placed", $"Order placed for {order.Quantity} of {order.ProductName}", "Ok");
        }
    }
}