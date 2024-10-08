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

    public partial class Skill
    {
        public int SkillID { get; set; }
        [Required(ErrorMessage ="Yetenek ba�l��� gereklidir.")]
        [MinLength(1,ErrorMessage ="Yetenek ba�l��� en az 1 karakter olmal�d�r.")]
        public string SkillName { get; set; }
        [Required(ErrorMessage = "Yetenek de�eri gereklidir.")]
        [Range(1, 100, ErrorMessage = "Yetenek de�eri 1 ile 100 aras�nda olmal�d�r.")]
        public Nullable<byte> Rate { get; set; }
        public string Icon { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
