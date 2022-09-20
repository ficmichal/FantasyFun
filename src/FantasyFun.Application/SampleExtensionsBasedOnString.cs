namespace FantasyFun.Application
{
    public static class SampleExtensionsBasedOnString
    {
        public static bool ContainsLewandowski(this string value)
        {
            return value.Contains("Lewandowski");
        }
    }
}
