//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Programming.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Languages
    {
        public int ID { get; set; }

        [Required]
        public string language { get; set; }

        [Required]
        public string founder { get; set; }

        [Required]
        [Range(1900,2019)]
        public int year { get; set; }

        public Nullable<bool> isPopular { get; set; }
    }
}
