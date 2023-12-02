using project.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using Object = project.Model.Object;

namespace project.Service;

public class ProjectService
{
    private readonly IMongoCollection<Object> _projectCollection;
    private readonly ILogger<ProjectService> _logger;

    public ProjectService(ILogger<ProjectService> logger, IConfiguration configuration)
    {
        _logger = logger;
        var connectionString = configuration.GetConnectionString("MongoDB");
        var mongoClient = new MongoClient(connectionString);
        var database = mongoClient.GetDatabase("databseName");
        _projectCollection = database.GetCollection<Object>("collectionName");
    }

    public List<Object> Get()
    {
        try
        {
            // _droneCollection 으로 모든 Document 가져와서 .Find() 메서드에 빈 BsonDcoumet를 사용하여 모든 문서 선택
            var res = _projectCollection
                .Find(new BsonDocument()) // BsonDocument는 MongoDB형식으로(Binary JSON) 데이터를 나타내는 클래스
                .ToList(); // 문서의 목록을 List 형태로 반환

            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while fetching drone data from MongoDB.");
            throw; // 오류를 호출자에게 전달
        }
    }

    public Object GetById(string droneId)
    {
        try
        {
            
            var filter = Builders<Object>.Filter.Eq("DroneId", droneId);
            var res = _projectCollection.Find(filter).FirstOrDefault();
            return res;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while fetching drone data from MongoDB.");
            throw;
        }
    }
}