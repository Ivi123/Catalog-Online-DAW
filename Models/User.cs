﻿namespace Catalog_Online.Models
{
    public class User
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        public string FirstName { get; set; }   
        public string LastName { get; set; } 
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}
