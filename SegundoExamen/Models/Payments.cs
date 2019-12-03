using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  Payments{
        public int PaymentID {get ; set;}
        public int BookingID {get; set;}
        public int CustomerID {get; set;}
        public int PaymentMethodID {get; set;}
        public string PaymentAmount {get; set;}
        public string PaymentComments {get; set;}
        
        public PaymentMethods paymentMethods  {get; set;}
        public Customers Customers  {get; set;}
        public Bookings Bookings  {get; set;}
    }
}