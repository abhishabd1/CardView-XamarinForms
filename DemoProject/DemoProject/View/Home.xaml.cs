using DemoProject.Api;
using DemoProject.BusinessLogic;
using DemoProject.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
       public ObservableCollection<Employee> employees;
        EmplyeeBL _EBL = new EmplyeeBL();
		public Home ()
		{
			InitializeComponent ();

            FillList();
        }
        
        public async void FillList()
        {
            employees = new ObservableCollection<Employee>();
            var _data = await _EBL.GetRecord();
            if (_data.Count != 0)
            {
                employees = _data;
                Emplist.ItemsSource = _data;
            }
            else
            {
                employees = null;
            }
            
        }
	}
}