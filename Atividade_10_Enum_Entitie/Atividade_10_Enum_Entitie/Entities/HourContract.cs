using System;

namespace Atividade_10_Enum_Entitie.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() //Constructor
        {
        }

        public HourContract(DateTime date, double valuePerHour, int hours) //constuctor with arguments
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() //method
        {
            return Hours * ValuePerHour;
        }
    }
}
