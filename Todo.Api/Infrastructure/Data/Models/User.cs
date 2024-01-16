﻿using System.ComponentModel.DataAnnotations;

namespace Todo.Api.Infrastructure.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicPath { get; set; }
        public string Email { get; set; }
        public HashSet<TodoTask>? Tasks { get; set; }
    }
}
