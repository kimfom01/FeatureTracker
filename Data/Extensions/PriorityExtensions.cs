using Data.Models;

namespace Data.Extensions;

public static class PriorityExtensions
{
    static readonly Dictionary<Priority, string> priorityColorDictionary = new()
    {
        {Priority.Low , "badge bg-success"},
        {Priority.Medium, "badge bg-warning text-dark"},
        {Priority.High, "badge bg-danger"}
    };

    public static string ToCssClass(this Priority priority)
    {
        return priorityColorDictionary[priority];
    }
}
