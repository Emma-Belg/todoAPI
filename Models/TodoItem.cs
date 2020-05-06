//Following this code
//https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code

//A model is a set of classes that represent the data that the app manages. The model for this app is a single TodoItem class.
namespace todoAPI.Models
{
    public class TodoItem
    {
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    }
}