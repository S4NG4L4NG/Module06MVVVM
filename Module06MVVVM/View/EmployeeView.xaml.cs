using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module06MVVVM.ViewModel;
using Module06MVVVM.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module06MVVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeView : ContentPage
    {

        //Set a Variable

        EmployeeViewModel _viewModel;
        bool _isUpdate;
        int employeeID;

        public EmployeeView()
        {
            InitializeComponent();
            //BindingContext = new EmployeeViewModel();

            _viewModel = new EmployeeViewModel();
            _isUpdate = false;
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{

        //}
        public EmployeeView(EmployeeModel obj)
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            if (obj != null)
            {
                employeeID = obj.Id;
                txtName.Text = obj.Name;
                txtEmail.Text = obj.Email;
                txtAddress.Text = obj.Address;
            }

        }

           private void btnSaveUpdate_Clicked(object sender, EventArgs e)
            {
            
            EmployeeModel obj = new EmployeeModel();
            employeeID = obj.Id;
            txtName.Text = obj.Name;
            txtEmail.Text = obj.Email;
            txtAddress.Text = obj.Address;

            _viewModel.InsertEmployee(obj);

        }
        
    }
}