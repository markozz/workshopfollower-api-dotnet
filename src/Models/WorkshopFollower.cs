using System;
using System.Text.Json.Serialization;

public class WorkshopFollower {
    public Guid id {get; set;}
    public String name {get; set;}
    public String email {get; set;}
    public DateTime createdAt {get; set;}

    [JsonConstructor]
    public WorkshopFollower()
    {

    }

    public WorkshopFollower(String id, String name, String email, String createdAt)
    {
        this.id = Guid.Parse(id);
        this.name = name;
        this.email = email;
        this.createdAt = DateTime.Parse(createdAt);
    }
    
}