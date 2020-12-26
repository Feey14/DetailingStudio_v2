﻿using System.ComponentModel.DataAnnotations;

namespace DetailingStudio_v2.Models
{
    public class Affiliate
    {
        /// <summary>
        /// Primary key Affiliate Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Affiliate country.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Country { get; set; }
        
        /// <summary>
        /// Affiliate city.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        /// <summary>
        /// Affiliate phone number.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Affiliate street adress.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string StreetAdress { get; set; }

        /// <summary>
        /// Affiliate e-mail.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
    }
}
