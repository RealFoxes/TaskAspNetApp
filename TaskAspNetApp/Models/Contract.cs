using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskAspNetApp.Models
{
	public class Contract
	{
		[Key]
		public int Id { get; set; }
		[Required, MaxLength(256)]
		public string Code { get; set; }
		[Required, MaxLength(256)]
		public string Name { get; set; }
		[Required, MaxLength(256)]
		public string Client { get; set; }
		public List<StageContract> Stages { get; set; }

		public Contract()
		{
			Stages = new List<StageContract>();
		}


	}
}
