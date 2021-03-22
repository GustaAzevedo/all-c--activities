using System;
using System.Collections.Generic;
using modulo14.Atividade2.Entities;

namespace modulo14.Atividade2.Services
{
    class RentalService
    {
        public double PriceHour { get; set; }
        public double PriceDay { get; private set; }

        private ITaxService _TaxService;

        public RentalService(double priceHour, double priceDay, ITaxService taxService)
        {
            PriceHour = priceHour;
            PriceDay = priceDay;
            _TaxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;

            if(duration.TotalHours <= 12){
                basicPayment = PriceHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PriceDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
