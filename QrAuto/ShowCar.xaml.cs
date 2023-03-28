using System.Xml;

namespace QrAuto;

public partial class ShowCar : ContentPage
{
	public ShowCar(Car car)
	{
		InitializeComponent();

        NameLabel.Text = $"Name: {car.Name}";
        SerialNumberLabel.Text = $"SerialNumber: {car.SerialNumber}";
        DepartmentLabel.Text = $"Department: {car.Department_address}";
        PlateNumberLabel.Text = $"PlateNumber: {car.PlateNumber} ";
        PhaseStartLabel.Text = $"PhaseStart: {car.PhaseStart.ToString()}";
        PhaseNameLabel.Text = $"PhaseName: {car.phase_name} ";


        /*        public string PlateNumber { get; set; }
        public DateTime PhaseStart { get; set; }*/

    }
}