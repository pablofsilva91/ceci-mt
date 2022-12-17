﻿using Microsoft.AspNetCore.Mvc;

namespace CeciMT.Domain.DTO.Address
{
    public class AddressIdentifierDTO
    {
        /// <summary>
        /// Identifier address
        /// </summary>
        [BindProperty(Name = "addressId")]
        public int AddressId { get; set; }
    }
}
