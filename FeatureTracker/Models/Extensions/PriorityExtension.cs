namespace FeatureTracker.Models.Extensions;

public static class PriorityExtension
{
    public static string ToCssClass(this Priority priority)
    {
        var cssClassDictionary = new Dictionary<Priority, string>
        {
            {Priority.High, "badge bg-danger"},
            {Priority.Medium, "badge bg-warning text-dark"},
            {Priority.Low , "badge bg-success"}
        };

        return cssClassDictionary[priority];
    }
}
