using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace QrAuto;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	

	private void Button_Clicked(object sender, EventArgs e)
	{
        //App.Current.MainPage = new NavigationPage(new ShowCars());
    }

	private void Button_Clicked_1(object sender, EventArgs e)
	{


	}

    
   


    private async void Button_Clicked_2(object sender, EventArgs e)
	{
        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetStringAsync($"http://10.0.2.2:8000/cars/");
            //var responseBody = await response.Content.ReadAsStringAsync();
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(response);
            //listcontacts.itemssource = cars;

            App.Current.MainPage = new NavigationPage(new ShowCars(cars));
            //await Navigation.PushAsync(new ShowCars(cars));

        }
    }




    public class Root
    {
        public string serialnumber { get; set; }
        public string name { get; set; }
        public string platenumber { get; set; }
        public string phase_name { get; set; }
        public DateTime phasestart { get; set; }
        public string department_address { get; set; }
    }
}


