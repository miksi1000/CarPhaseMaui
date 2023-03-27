using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrAuto
{
    public class Car
    {

        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int PlateNumber { get; set; }
        public DateTime PhaseStart { get; set; }

        //public Phase Phase_Id { get; set; }

        //public Department Department_Id { get; set; }

        //public Car(string name, string serialNumber, int plateNumber, DateTime phaseStart /*Phase phase_Id, Department department_Id*/)
        //{
        //    Name = name;
        //    SerialNumber = serialNumber;
        //    PlateNumber = plateNumber;
        //    PhaseStart = phaseStart;
        //    //Phase_Id = phase_Id;
        //    //Department_Id = department_Id;
        //}
    }
}
