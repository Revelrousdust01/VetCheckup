namespace VetCheckup.Domain.Entities;

public class Owner : BaseAuditableEntity
{

    #region Properties
    
    public DateTime DateOfBirth { get; set; }

    public required string Name { get; set; }

    public Guid OwnerId { get; set; } 

    #endregion

}
