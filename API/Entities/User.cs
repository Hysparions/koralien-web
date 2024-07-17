using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class User
{
    
    [Key]
    // Unique ID of the user [Key] marks this field as primary key in a Database
    // It is not required normally for fields named Id, but for clarity we mark it as Key
    public int Id {get; set;}
    // name of the user
    public required string name {get; set;}
}