using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TaskAspNetApp.Models
{
	public class StageContract
	{
		[Key]
		public int Id { get; set; }
		[Required, JsonIgnore]
		public virtual Contract contract { get; set; }
		[Required, MaxLength(256)]
		public string Name { get; set; }
		[Required, Column(TypeName = "date")]
		public DateTime DateStart { get; set; }
		[Required, Column(TypeName = "date")]
		public DateTime DateEnd { get; set; }
	}
}
