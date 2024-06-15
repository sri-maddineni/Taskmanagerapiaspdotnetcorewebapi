using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace Mongocrud.TaskModels
{
    public class GetAllTasksResponse
    {

        public bool success { get; set; }

        public string message { get; set; }

        public List<GetAllTasksRequest> data { get; set; }


    }

    public class GetAllTasksRequest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }


        [Required]

        public string? user_id { get; set; }

        [Required]
        public string? name { get; set; }

        [Required]
        public string? role { get; set; }


    }
}
