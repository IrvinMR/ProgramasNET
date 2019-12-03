using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  Customers{
        public int CustomerID {get ; set;}
        public string CustomerTitle {get; set;}
        public string CustomerForenames {get; set;}
        public string CustomerSurnames {get; set;}
        public string CustomerDOB {get; set;}
        public string CustomerAddressStreet {get; set;}
        public string CustomerAddressTown {get; set;}
        public string CustomerAddressCountry {get; set;}
        public string CustomerAddressPostalCode {get; set;}
        public string CustomerHomePhone {get; set;}
        public string CustomerWorkPhone {get; set;}
        public string CustomerMobilePhone {get; set;}
        public string CustomerEmail {get; set;}

        public ICollections<Bookings> Bookings {get; set;}
        public ICollections<Payments> Payments {get; set;}
    }
}