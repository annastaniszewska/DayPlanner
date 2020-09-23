using System;

namespace DayPlanner.Helpers
{
    public class DirectoryHelper
    {
        public static string ProjectRoot()
        {
            return AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.LastIndexOf("DayPlanner"));
        }
    }
}
