using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkademiPlus_Transportation.Models
{
    public class Class1
    {
        [Required(ErrorMessage ="lütfen adı boş geçmeyin")]
        [StringLength(30,ErrorMessage ="lütfen en fazla 30 karakter giriniz")]
        public string Name { get; set; }
    }
}