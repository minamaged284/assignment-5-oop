namespace assignment_5
{
    public class Duration
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }

        public Duration(int hours, int minutes, int seconds
            )
        {
            Hours = hours;

            Minutes = minutes;
            Seconds = seconds;

        }

        public Duration(int duration)
        {

            Hours = duration / 3600;
            Minutes = (duration % 3600) / 60;
            Seconds = duration - ((Hours * 3600) + (Minutes * 60));


        }

        public override string ToString()
        {
            return $"Hours: {Hours} , Minutes: {Minutes} , Seconds: {Seconds}";
        }

        public override bool Equals(object? obj)
        {
            Duration duration = obj as Duration;
            if (obj == null) { return false ; }

            else if (duration.Hours==this.Hours && duration.Minutes==this.Minutes && duration.Seconds==this.Seconds) {return true;}
            else {return false;}

        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
