namespace Domain.Extensions
{
    public static class IListExtension
    {
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || (list?.Count ?? 0) == 0;
        }
    }
}