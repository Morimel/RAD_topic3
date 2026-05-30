namespace MyMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = "Profile loaded: Name = Alex, Role = Student";
        }

        private void OnSubscriptionClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = "Subscription Tier: PREMIUM (Simulation Mode)";
        }

        private void OnEmailClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = "Email sent successfully (Simulated)";
        }
    }
}
