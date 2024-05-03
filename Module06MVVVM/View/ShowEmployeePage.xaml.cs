using Module06MVVVM.Model;
using Module06MVVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module06MVVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeePage : ContentPage
    {
        EmployeeViewModel viewModel;

        public ShowEmployeePage()
        {
            InitializeComponent();
        }

        private void showEmployeePage()
        {
            var res = viewModel.GetAllEmployees().Result;
           lstData.ItemsSource = res;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showEmployeePage();
        }

        private void btnAddRecord(object sender, EventArgs e) 
        {
            this.Navigation.PushAsync(new EmployeeView());
        }       

    }
}