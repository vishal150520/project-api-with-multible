﻿namespace Projectapi.Data
{
    public class CustomerAddressesDto
    {
        public int Id { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public int CustomerId { get; set; }
    }
}
