using Newtonsoft.Json;

namespace QrAuto;

public partial class ShowCars : ContentPage
{
    public ShowCars(List<Car> cars)
    {
        InitializeComponent();

        //Car car = new Car("Mikkel", "adsdw", 32, DateTime.Now);

        //List<Car> cars = new List<Car>();

        //List<string> contacts = new List<string>() { "Mikkel", "Sebastian", "Jesper" };
        //List<Car> cars = new List<Car>();
        //cars.Add(new Car() { Name = "SHIWE arm", SerialNumber = "hej", PhaseStart = DateTime.Now, PlateNumber = 2345 });
        //cars.Add(new Car() { Name = "QIWJE arm", SerialNumber = "NEJ", PhaseStart = DateTime.Now, PlateNumber = 6969 });
        //cars.Add(new Car() { Name = "crank arm", SerialNumber = "JA", PhaseStart = DateTime.Now, PlateNumber = 8888 });


        //ListContacts.ItemsSource = cars;
        ListContacts.ItemsSource = cars;




    }


    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {

        if (e.SelectedItem == null)
            return;

        // Navigate to the new page and pass the selected item's data
        await Navigation.PushAsync(new ShowCar((Car)e.SelectedItem));

        // Deselect the item
        ListContacts.SelectedItem = null;
    }
  
}


