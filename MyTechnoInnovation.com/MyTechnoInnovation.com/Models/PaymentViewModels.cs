using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTechnoInnovation.com.Models
{
    public class PaymentViewModels
    {
        public decimal UserId { get; set; }

        [Required(ErrorMessage = "Payment Amount is required.")]
        public decimal PaymentAmt { get; set; }

        [Required(ErrorMessage = "Payment Date is required.")]
        public string PaymentDate { get; set; }

        [Required(ErrorMessage = "Payment Method is required.")]
        public string PaymentMethod { get; set; }

    }
}