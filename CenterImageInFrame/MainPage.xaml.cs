

namespace CenterImageInFrame
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();
        void foo()
        {
            var aspect = Aspect.AspectFill;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var timeSpan = 0.5;

            var widthAnimation = new Animation(v => ImageFrame.WidthRequest = v, 780, 1920);
            var heightAnimation = new Animation(v => ImageFrame.HeightRequest = v, 640, 1080);
            var marginAnimation = new Animation(v => ImageFrame.Margin = new Thickness(v, v, v, v), 130, 0);

            var parentAnimation = new Animation
            {
                { 0, 1, widthAnimation },
                { 0, 1, heightAnimation },
                { 0, 1, marginAnimation }
            };

            MainImage.MaximumHeightRequest = 1080;
            MainImage.MaximumWidthRequest = 1920;

            parentAnimation.Commit(this, "ExpandImage", 16, (uint)(timeSpan * 10000), Easing.CubicInOut, (v, c) => AnimationCompleted());

        }

        private void AnimationCompleted()
        {
        }
    }
}
