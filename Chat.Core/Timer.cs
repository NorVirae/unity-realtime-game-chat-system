namespace Chat.Core
{
    public class Timer
    {

        public DateTime serverStartTime;
        public double time;
        public DateTime Now { get{
                return DateTime.UtcNow;
            }
        }

        public void Init()
        {
            serverStartTime = DateTime.UtcNow;
        }

        public bool CheckTick()
        {
            double totalsec = Now.GetTotalSeconds();
            double delta = totalsec - time;

            time = totalsec;
            if (delta > 0.5f)
            {
                return true; 
            }

            return false;
        }
    }

    internal static class DateTimeEx
    {
        public static double GetTotalSeconds(this DateTime time)
        {
            return (time.ToUniversalTime().Subtract(new DateTime(2020, 1, 1))).TotalSeconds;
        }

        /// <summary>
        /// Gets the Unix timestamp of the DateTime object
        /// </summary>
        public static ulong ToUnixTimestamp(this DateTime time)
        {
            return (ulong)Math.Truncate(time.GetTotalSeconds());
        }
    }
}