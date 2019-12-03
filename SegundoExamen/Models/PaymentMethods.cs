using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace SegundoExamen.Models{

    public class  PaymentMethods{
        public int PaymentMethodID {get ; set;}
        public string PaymentMethod {get; set;}

        private ICollections<PaymentMethods> paymentMethods;

        public ICollections<PaymentMethods> GetPaymentMethods()
        {
            return paymentMethods;
        }

        public void SetPaymentMethods(ICollections<PaymentMethods> value)
        {
            paymentMethods = value;
        }
    }
}