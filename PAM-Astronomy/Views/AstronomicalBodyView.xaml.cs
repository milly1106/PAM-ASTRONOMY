namespace PAM_Astronomy.Views;

public partial class AstronomicalBodyView : ContentPage
{
    public AstronomicalBodyView()
    {
        InitializeComponent();
    }
    string astroName;
    public string AstroName
    {
    get => astroName;
    set
        {
            astroName = value;
            UpdateAstroBodyUI(astroName);
        }
    }
    [QueryProperty(nameof(AstroName), "astroName")]
    public partial class AstronomicalBodyPage
    {

    }

    public object SolarSystemData { get; private set; }

    void UpdateAstroBodyUI(string astroName)
    {
        AstronomicalBody body = FindAstroData(astroName);

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }
    AstronomicalBody FindAstroData(string astronomicalBodyName) => astronomicalBodyName switch
    {
        "comet" => SolarSystemData.HalleysComet,
        "earth" => SolarSystemData.Earth,
        "moon" => SolarSystemData.Moon,
        "sun" => SolarSystemData.Sun,
        _ => throw new ArgumentException()
    };

}