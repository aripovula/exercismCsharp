using System;

public static class Leap {
    public static bool IsLeapYear(int year)
    {
        Boolean by4 = year%4 == 0;
        Boolean by100 = year%100 == 0;
        Boolean by400 = year%400 == 0;
        return !by4 ? false : (by400 ? true : (by100 ? false : true ) );
    }
}