float[,,] measurements3D = new float[12, 31, 24];

// fill the 3D array with random values between 0 and 15
Random random = new Random();
for (int month = 0; month < measurements3D.GetLength(0); month++)
{
  for (int day = 0; day < measurements3D.GetLength(1); day++)
  {
    for (int hour = 0; hour < measurements3D.GetLength(2); hour++)
    {
      measurements3D[month, day, hour] = (float)random.NextDouble() * 15;
    }
  }
}

Console.WriteLine("3D array created");

// all values between August 13th and September 16th should be corrected by a factor of 1.1
for (int day = 12; day <= 15; day++)
{
  for (int hour = 0; hour < measurements3D.GetLength(2); hour++)
  {
    measurements3D[7, day, hour] *= 1.1f;
  }
}
for (int day = 0; day <= 15; day++)
{
  for (int hour = 0; hour < measurements3D.GetLength(2); hour++)
  {
    measurements3D[8, day, hour] *= 1.1f;
  }
}

// output of all values beween March and June and output the smallest and largest value in this range
int minMonthIndex = 2, minDayIndex = 0, minHourIndex = 0;
int maxMonthIndex = 5, maxDayIndex = 0, maxHourIndex = 0;

for (int month = 2; month <= 5; month++)
{
  for (int day = 0; day < measurements3D.GetLength(1); day++)
  {
    for (int hour = 0; hour < measurements3D.GetLength(2); hour++)
    {
      Console.WriteLine($"Month: {month + 1}, Day: {day + 1}, Hour: {hour}, Value: {measurements3D[month, day, hour]}");
      if (measurements3D[month, day, hour] < measurements3D[minMonthIndex, minDayIndex, minHourIndex])
      {
        minMonthIndex = month;
        minDayIndex = day;
        minHourIndex = hour;
      }
      if (measurements3D[month, day, hour] > measurements3D[maxMonthIndex, maxDayIndex, maxHourIndex])
      {
        maxMonthIndex = month;
        maxDayIndex = day;
        maxHourIndex = hour;
      }
    }
  }
}
Console.WriteLine($"Smallest value: {measurements3D[minMonthIndex, minDayIndex, minHourIndex]} at Month: {minMonthIndex + 1}, Day: {minDayIndex + 1}, Hour: {minHourIndex}");
Console.WriteLine($"Largest value: {measurements3D[maxMonthIndex, maxDayIndex, maxHourIndex]} at Month: {maxMonthIndex + 1}, Day: {maxDayIndex + 1}, Hour: {maxHourIndex}");

// average value of all measurements in the 3D array
float sum = 0;
for (int month = 0; month < measurements3D.GetLength(0); month++)
{
  for (int day = 0; day < measurements3D.GetLength(1); day++)
  {
    for (int hour = 0; hour < measurements3D.GetLength(2); hour++)
    {
      sum += measurements3D[month, day, hour];
    }
  }
}
Console.WriteLine($"Average value: {sum / (measurements3D.GetLength(0) * measurements3D.GetLength(1) * measurements3D.GetLength(2))}");

