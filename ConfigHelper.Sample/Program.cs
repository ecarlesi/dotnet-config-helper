using ConfigHelper.Manager;
using ConfigHelper.Sample;

MyConfig myConfig = Configuration.GetCustomSection<MyConfig>("Sample");

Console.WriteLine("Hello, World!");
Console.WriteLine($"Key: {myConfig.Key}");
