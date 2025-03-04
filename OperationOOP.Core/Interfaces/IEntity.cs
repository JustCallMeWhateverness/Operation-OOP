
namespace OperationOOP.Core.Interfaces;
 public interface IEntity //Makes sure that all classes that implement IEntity have an Id property
    {
        int Id { get; set; } 
    }