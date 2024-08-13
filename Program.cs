using System;

//Various date string formats to attempt parsing

string[] sampleDateTimes =
{
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string dateStr in sampleDateTimes)
{
    DateTime result;
}