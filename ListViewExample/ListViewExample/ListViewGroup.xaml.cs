using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            List<PageTypeGroup> Groups = new List<PageTypeGroup> {
            new PageTypeGroup ("Alpha", "A"){
                new PageModel("Amelia", "Cedar"),
                new PageModel("Alfie", "Spruce"),
                new PageModel("Ava", "Pine"),
                new PageModel("Archie", "Maple")
            },
            new PageTypeGroup ("Bravo", "B"){
                new PageModel("Brooke", "Lumia"),
                new PageModel("Bobby", "Xperia"),
                new PageModel("Bella", "Desire"),
                new PageModel("Ben", "Chocolate")
            }
            };

            this.GroupedView.ItemsSource = Groups;
        }
    }
}