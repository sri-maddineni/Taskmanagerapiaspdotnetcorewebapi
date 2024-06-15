using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Mongocrud.Models
{
	public class GetAllRecordResponse
	{
		public bool success { get; set; }

		public string message { get; set; }

		public List<InsertRecordRequest> data { get; set; }

	}

	
}
