using Mongocrud.TaskModels;

namespace Mongocrud.DataAccessLayer
{
    public interface ICrudDL
	{
		
		public Task<GetAllTasksResponse> GetAllTasks();

		public Task<GetAllTasksResponse> DeleteAllTasks();

















		/*
		 * public Task<InsertRecordResponse> InsertRecord(InsertRecordRequest req);

		public Task<GetRecordByIdResponse> GetRecordById(string Id);

		public Task<GetRecordByNameResponse> GetRecordByName(string Name);

		public Task<UpdateRecordByIdResponse> UpdateRecordById(InsertRecordRequest req);

		public Task<UpdateSalaryByIdResponse> UpdateSalaryById(UpdateSalaryByIdRequest req);

		public Task<DeleteRecordByIdResponse>DeleteRecordById(string Id);

		public Task<UpdateSalaryByIdResponse> DeleteAllRecord();

		*/

	}
}
