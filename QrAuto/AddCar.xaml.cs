
using Microsoft.Maui.Graphics.Text;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json;

namespace QrAuto;



public partial class AddCar : ContentPage
{
	public AddCar()
	{
		InitializeComponent();
	}

    private async void SendButton_Clicked(object sender, EventArgs e)
    {
        Car car = new Car();
        car.Name = NameText.Text;
        car.SerialNumber = SerialNumberText.Text;
        car.PhaseStart = DateTime.Today;
        car.PlateNumber = PlateNumberText.Text;
        car.phase_name = PhaseNameText.Text;
        car.department_address = DepartmentAddressText.Text;


        Activity.IsRunning = true;


        using (HttpClient client = new HttpClient())
        {
            var formContent = new FormUrlEncodedContent(new[]
            {
        new KeyValuePair<string, string>("name", car.Name),
        new KeyValuePair<string, string>("serialnumber", car.SerialNumber.ToString()),
        new KeyValuePair<string, string>("phasestart", car.PhaseStart.ToString("yyyy-MM-dd")),
        new KeyValuePair<string, string>("platenumber", car.PlateNumber),
        new KeyValuePair<string, string>("phase_name", car.phase_name),
        new KeyValuePair<string, string>("department_address", car.department_address)
    });

            try
            {
                var response = await client.PostAsync($"http://10.0.2.2:8000/cars/", formContent);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    // process the response content
                    Console.WriteLine("Success: " + responseContent);
                }
                else
                {
                    var errorMessage = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Error: " + errorMessage);
                }
            }
            catch (HttpRequestException y)
            {
                Console.WriteLine("Error: " + y.Message);
            }
        }

        
        //Thread.Sleep(5000);

        await DisplayAlert("Success", "The car data was sent successfully.", "OK");

        Activity.IsRunning = false;

        await Navigation.PopAsync();

    }
}