using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;
using XFGamingStore.WPF.Renderers;

[assembly: ExportRenderer(typeof(ScrollView), typeof(CustomScrollView))]
namespace XFGamingStore.WPF.Renderers
{
    public class CustomScrollView : ScrollViewRenderer
    {
        public CustomScrollView()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ScrollView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (e.OldElement != null)
                e.OldElement.PropertyChanged -= OnElementPropertyChanged;

            e.NewElement.PropertyChanged += OnElementPropertyChanged;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            this.Control.HorizontalScrollBarVisibility = System.Windows.Controls.ScrollBarVisibility.Hidden;
        }
    }
}
