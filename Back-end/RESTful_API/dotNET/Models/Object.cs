using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace project.Model;

public class Object
{
    [BsonId]
    [BsonRepresentation(BsonType.String)] // MongoDB의 ObjectId를 문자열로 표현
    public string? _id { get; set; }

    public DateTime? LastHeartbeatMessage { get; set; }
    public string? DroneId { get; set; }
    public float[]? DroneLogger { get; set; }
    public bool? IsOnline { get; set; }
    public bool? HasDeliveryPlan { get; set; }
    public float[]? WaypointsDistance { get; set; }
    public object? DroneRawState { get; set; }
    public float? PathIndex { get; set; }
    public float[]? DroneTrails { get; set; }
    public float[]? DroneProgress { get; set; }
    public float[]? DroneProgressPercentages { get; set; }
    public float? ElapsedDistance { get; set; }
    public float? RemainDistance { get; set; }
    public float? TotalDistance { get; set; }
    public string? CameraIP { get; set; }
    public string? CameraURL1 { get; set; }
    public string? CameraURL2 { get; set; }
    public string? CameraProtocolType { get; set; }
    public string? MavMission { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? CompleteTime { get; set; }
    public object? CommunicationLink { get; set; }
    public float? DroneSpeed { get; set; }
}