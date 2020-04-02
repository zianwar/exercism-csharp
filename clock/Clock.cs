using System;

public class Clock
{
    private readonly int minutes = 0;

    public Clock(int hours, int minutes)
    {
        while (minutes < 0)
        {
            minutes += 60;
            hours -= 1;
        }
        while (hours < 0)
        {
            hours += 24;
        }
        this.minutes = (hours * 60 + minutes) % (60 * 24);
    }

    public Clock Add(int minutesToAdd)
        => new Clock(0, this.minutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract)
        => new Clock(0, this.minutes - minutesToSubtract);

    public override bool Equals(Object obj)
        => Equals(obj as Clock);

    public override string ToString()
        => String.Format("{0:00}:{1:00}", this.minutes / 60, this.minutes % 60);

    public bool Equals(Clock other)
    {
        if (other == null)
            return false;

        if (this.minutes == other.minutes)
            return true;

        return false;
    }
}
