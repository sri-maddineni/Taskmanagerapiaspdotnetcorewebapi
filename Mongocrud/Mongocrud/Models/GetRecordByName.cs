namespace Mongocrud.Models
{
	public class GetRecordByNameResponse
	{
		public bool success { get; set; }

		public string message { get; set; }

		public List<InsertRecordRequest> data { get; set; }


	}
}
