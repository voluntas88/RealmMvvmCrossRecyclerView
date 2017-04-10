using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Core.MvvmCrossRealm_RecyclerView.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Views;

namespace Droid.MvvmCrossRealm_RecyclerView
{
    [Activity(Label = "Droid.MvvmCrossRealm_RecyclerView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : MvxActivity<HomeViewModel>
    {
        private MvxRecyclerView PersonssGrid { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Main);

            PersonssGrid = FindViewById<MvxRecyclerView>(Resource.Id.persons_grid_view);
            PersonssGrid.HasFixedSize = true;
            PersonssGrid.SetLayoutManager(new GridLayoutManager(this, 2, LinearLayoutManager.Horizontal, false));
            PersonssGrid.AddItemDecoration(new DividerItemDecoration(this, LinearLayoutManager.Horizontal));

            ViewModel.PopulatePersons();
            ViewModel.FetchPersons();
            
        }
    }
}

