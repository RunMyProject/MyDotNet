using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PlayTennis.Models
{
    // Modelli restituiti dalle azioni MeController.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}