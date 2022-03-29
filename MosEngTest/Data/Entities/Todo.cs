using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MosEngTest.Data.Entities
{
    [Table("todos")]
    public class Todo
    {
        [Column("id")][JsonPropertyName("id")]
        public int Id { get; set; }
        [Column("title")][JsonPropertyName("title")]
        public string Title { get; set; }
        [Column("user_id")][JsonPropertyName("user_id")]
        public int UserId { get; set; }
    }
}