
using Core.MvvmCrossRealm_RecyclerView.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Core.MvvmCrossRealm_RecyclerView
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<HomeViewModel>());
        }
    }
}
