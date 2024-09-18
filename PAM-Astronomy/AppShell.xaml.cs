
using PAM_Astronomy.Views;

namespace PAM_Astronomy
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyView));
        }

     
    }
}
