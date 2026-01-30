namespace Ecom.Core.DTOs
{
    //the reason of using record instead of class is that the dto is just a container not a real class and auto property initializer for easy and clean code
    public record CategoryDTO(string Name,string Description);
    public record UpdateCategoryDTO(string Name, string Description, int id);
}
