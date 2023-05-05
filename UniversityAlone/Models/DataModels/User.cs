﻿namespace UniversityAlone.Models.DataModels
{
    using System.ComponentModel.DataAnnotations;
    using UniversityAlone.Models.DataModels;
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string? Name { get; set; }
        [Required, StringLength(100)]
        public string? LastName { get; set; }
        [Required, EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? SomethingElse { get; set; }
    }
}