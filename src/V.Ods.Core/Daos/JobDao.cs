using SqlKata.Execution;

namespace V.Ods.Core.Daos;

public class JobDao
{
    private QueryFactory db;
    
    public JobDao(QueryFactory db)
    {
        this.db = db;
    }

    public List<string> GetInitParams(string jobId) => this.db.Query("ods_job_init_param")
        .Where("job_id", jobId)
        .Select("param")
        .Get<string>()
        .ToList();
}