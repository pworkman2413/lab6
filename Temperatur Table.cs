
static double celsiusConverter(double fahren)
{
    double celsiusMath;
    celsiusMath = (5.0/9.0) * (fahren - 32.0);
    return celsiusMath;
}

double fahren = 80.0;

for(int i = 80;i < 101;i++)
{
    Console.WriteLine($"The celsius conversion for {i} is {celsiusConverter(fahren)}");
    fahren++;
}