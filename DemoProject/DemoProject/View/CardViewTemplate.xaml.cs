using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoProject.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardViewTemplate : ContentView
	{
		public CardViewTemplate ()
		{
			InitializeComponent ();
		}
	}
}