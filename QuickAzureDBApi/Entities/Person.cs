﻿using System.ComponentModel.DataAnnotations;

namespace QuickAzureDBApi.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
