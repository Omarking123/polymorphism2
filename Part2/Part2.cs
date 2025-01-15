public class duration
{
    public int h { get; set; }
    public int min { get; set; }
    public int sec { get; set; }

    
    public duration(int h = 0, int min = 0, int sec = 0)
    {
        this.h = h;
        this.min = min;
        this.sec = sec;
        time();
    }

    
    public duration(int tseconds)
    {
        h = tseconds / 3600;
        min = (tseconds % 3600) / 60;
        sec = tseconds % 60;
    }

    private void time()
    {
        min += sec / 60;
        sec %= 60;

        h += min / 60;
        min %= 60;
    }


    public override string ToString()
    {
        if (h > 0)
            return $"h: {h}, m: {min}, s: {sec}";
        else if (min > 0)
            return $"m: {min}, s: {sec}";
        else
            return $"s: {sec}";
    }

 
    public override bool Equals(object? obj)
    {
        if (obj is duration other)
        {
            return h == other.h &&
                   min == other.min &&
                   sec == other.sec;
        }
        return false;
    }

   
   



    public static duration operator +(duration d1, duration d2)
    {
        return new duration(d1.h + d2.h, d1.min + d2.min, d1.sec + d2.sec);
    }

    
    public static duration operator -(duration d1, duration d2)
    {
        int total_seconds1 = d1.h * 3600 + d1.min * 60 + d1.sec;
        int total_seconds2 = d2.h * 3600 + d2.min * 60 + d2.sec;

        return new duration(total_seconds1 - total_seconds2);
    }

    public static duration operator ++(duration d1)
    {
        return new duration(d1.h, d1.min + 1, d1.sec);
    }

    public static duration operator --(duration d1)
    {
        return new duration(d1.h, d1.min - 1, d1.sec);
    }

    public static bool operator >(duration d1, duration d2)
    {
        int total_seconds1 = d1.h * 3600 + d1.min * 60 + d1.sec;
        int total_seconds2 = d2.h * 3600 + d2.min * 60 + d2.sec;

        return total_seconds1 > total_seconds2;
    }

    public static bool operator <(duration d1, duration d2)
    {
        return !(d1 > d2) && d1 != d2;
    }

    public static bool operator >=(duration d1, duration d2)
    {
        return d1 > d2 || d1 == d2;
    }

    public static bool operator <=(duration d1, duration d2)
    {
        return d1 < d2 || d1 == d2;
    }

    public static bool operator ==(duration d1, duration d2)
    {
        return d1==(d2);
    }

    public static bool operator !=(duration d1, duration d2)
    {
        return d1!=(d2);
    }

    public static explicit operator DateTime(duration d)
    {
        return new DateTime(1, 1, 1, d.h, d.min, d.sec);
    }

  
}
