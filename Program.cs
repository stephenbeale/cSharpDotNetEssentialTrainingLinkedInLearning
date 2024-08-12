﻿using System.Net;

int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 10000, 150000, 20000, 2250000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

//Specifying numerical formatting
/*
 * N = number
 * D = decimal
 * F = float
 * G = general
 * etc
 */
Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");