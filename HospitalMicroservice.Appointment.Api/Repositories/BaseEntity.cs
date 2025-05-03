using MongoDB.Bson.Serialization.Attributes;

namespace HospitalMicroservice.Doctor.Api.Repositories;

public abstract class BaseEntity
{
    [BsonElement("_id")]
    public Guid Id { get; set; }
}