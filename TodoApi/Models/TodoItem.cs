using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoApi.Models
{
    [Table("TodoItem", Schema = "Todos")]
    public class TodoItems
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
