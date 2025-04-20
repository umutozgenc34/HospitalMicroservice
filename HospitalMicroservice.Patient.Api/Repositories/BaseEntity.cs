using MongoDB.Bson.Serialization.Attributes;

namespace HospitalMicroservice.Patient.Api.Repositories;

public abstract class BaseEntity
{
    [BsonElement("_id")]
    public Guid Id { get; set; }
}
