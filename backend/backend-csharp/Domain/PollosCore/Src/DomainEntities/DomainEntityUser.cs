﻿namespace PollosCore.Src.DomainEntities
{
    public class DomainEntityUser : DomainEntity
    {
        public string Dni { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
