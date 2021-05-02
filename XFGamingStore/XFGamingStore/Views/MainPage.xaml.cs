using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFGamingStore.ViewModels;

namespace XFGamingStore.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _viewModel;
        private int _lastSelectedIndex;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new MainPageViewModel();
        }

        private async void CoverFlowView_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals("SelectedIndex"))
            {
                var currentIndex = ((PanCardView.CoverFlowView)sender).SelectedIndex;

                if (currentIndex != _lastSelectedIndex)
                {
                    _lastSelectedIndex = currentIndex;

                    lbName.Opacity = 0;
                    lbIconPlayCircle.Opacity = 0;
                    lbDescription.Opacity = 0;
                    lbImgBackground.Opacity = 0;

                    _viewModel.SetGameDetails(_lastSelectedIndex);

                    await Task.Delay(250);

                    await Task.WhenAll(
                         lbImgBackground.FadeTo(0.5, 500, Easing.Linear),
                        lbImgBackground.FadeTo(1, 800, Easing.Linear),
                        lbName.FadeTo(0.5, 500, Easing.Linear),
                        lbName.FadeTo(1, 800, Easing.Linear),
                        lbIconPlayCircle.FadeTo(0.5, 500, Easing.Linear),
                        lbIconPlayCircle.FadeTo(1, 800, Easing.Linear),
                        lbDescription.FadeTo(0.5, 500, Easing.Linear),
                        lbDescription.FadeTo(1, 800, Easing.Linear)
                    );
                }
            }
        }
    }
}
