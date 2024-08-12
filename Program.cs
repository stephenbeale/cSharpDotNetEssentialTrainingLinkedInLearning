//DateTime.Now to get current Dt
DateTime now = DateTime.Now;
Console.WriteLine(now);

//DateTime.Today
DateTime today = DateTime.Today;
Console.WriteLine(today);

//DateOnly and TimeOnly
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tm = TimeOnly.FromDateTime(now);
Console.WriteLine(dt);
Console.WriteLine(tm);

//Inspecting properties on dates
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);
//Can add multiple
Console.WriteLine(
    today
    .AddDays(23.65)
    .AddMonths(12)
    .AddYears(43));

now = now.AddDays(87);
Console.WriteLine(now);
Console.WriteLine(now.ToUniversalTime().ToString());

//Methods on dates to change values

//TimeSpan class for a duration of time