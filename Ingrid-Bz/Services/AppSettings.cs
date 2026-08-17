namespace Services
{
    public class AppSettings
    {
        public string ApplicationName { get; set; } = "Ingrid BZ";
        public int Major { get; set; } = 1;
        public int Minor { get; set; } = 0;
        public int Build { get; set; } = 0;
        public int Revision { get; set; } = 0;
    }

    public static class Function
    {
        public static string GetDevelopmentYear(int developmentyear)
        {
            if (developmentyear == System.DateTime.Now.Year)
            {
                return $"{System.DateTime.Now.Year}";
            }
            else
            {
                return $"{developmentyear} - {System.DateTime.Now.Year}";
            }
        }
    }
}
