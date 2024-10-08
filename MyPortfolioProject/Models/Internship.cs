//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPortfolioProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Internship
    {
        public int InternshipID { get; set; }

        [Required(ErrorMessage = "�irket ad�n� girin.")]
        [StringLength(100, ErrorMessage = "�irket ad� 100 karakterden fazla olmamal�d�r.")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Ba�lang�� tarihini girin.")]
        [DataType(DataType.Date, ErrorMessage = "Ge�ersiz tarih format�.")]
        public string StartDate { get; set; }

        [Required(ErrorMessage = "Biti� tarihini girin.")]
        [DataType(DataType.Date, ErrorMessage = "Ge�ersiz tarih format�.")]
        public string EndDate { get; set; }

        [Required(ErrorMessage = "Pozisyonu girin.")]
        [StringLength(50, ErrorMessage = "Pozisyon 50 karakterden fazla olmamal�d�r.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "A��klama girin.")]
        [StringLength(500, ErrorMessage = "A��klama 500 karakterden fazla olmamal�d�r.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Referans ad�n� girin.")]
        [StringLength(100, ErrorMessage = "Referans ad� 100 karakterden fazla olmamal�d�r.")]
        public string ReferenceName { get; set; }

        [Required(ErrorMessage = "Referans e-posta adresini girin.")]
        [EmailAddress(ErrorMessage = "Ge�ersiz e-posta adresi.")]
        [StringLength(100, ErrorMessage = "E-posta adresi 100 karakterden fazla olmamal�d�r.")]
        public string ReferenceEmail { get; set; }
    }
}
