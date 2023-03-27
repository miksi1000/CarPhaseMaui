namespace QrAuto;

public partial class ShowCars : ContentPage
{
	public ShowCars()
	{
		InitializeComponent();

        //Car car = new Car("Mikkel", "adsdw", 32, DateTime.Now);

        //List<Car> cars = new List<Car>();

        List<string> contacts = new List<string>() { "Mikkel", "Sebastian", "Jesper" };
        List<Car> cars = new List<Car>();
        cars.Add(new Car() { Name = "SHIWE arm", SerialNumber = "hej", PhaseStart = DateTime.Now, PlateNumber = 2345 });
        cars.Add(new Car() { Name = "QIWJE arm", SerialNumber = "NEJ", PhaseStart = DateTime.Now, PlateNumber = 6969 });
        cars.Add(new Car() { Name = "crank arm", SerialNumber = "JA", PhaseStart = DateTime.Now, PlateNumber = 8888 });


        ListContacts.ItemsSource = cars;

        
    }

    private void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new ShowCar());
    }
}
