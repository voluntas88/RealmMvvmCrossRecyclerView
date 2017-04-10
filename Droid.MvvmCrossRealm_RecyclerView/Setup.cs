using Android.Content;
using Core.MvvmCrossRealm_RecyclerView;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace Droid.MvvmCrossRealm_RecyclerView
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}