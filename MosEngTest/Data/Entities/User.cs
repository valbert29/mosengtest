using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MosEngTest.Data.Entities
{
    [Table("users")]
    public class User
    {
        [Column("id")][JsonPropertyName("id")]
        public int Id { get; set; }
        [Column("username")][JsonPropertyName("username")]
        public string Username { get; set; }
        [Column("password")][JsonPropertyName("password")]
        public string Password { get; set; }
        public virtual ICollection<Todo> Todos { get; set; }
    }
}