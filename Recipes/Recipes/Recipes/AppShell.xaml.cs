using Recipes.Views;
using Xamarin.Forms;

namespace Recipes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecipeEntryPage), typeof(RecipeEntryPage));
        }

    }
}
