namespace StaticExercise;

public static class TempConverter
{
    public static double FtoC(double f)
    {
        
        return (f - 32) / 1.8;

    }

    public static double CtoF(double c)
    {
        return (c * 9) / 5 + 32;
    }
}