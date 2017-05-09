using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SteamGameIdler
{
    class Program
    {
        [DllImport("steam_api.dll")]
        private static extern bool SteamAPI_Init();
        static void Main(string[] args)
        {
            Array.Resize(ref args, args.Length + 1);
            args[0] = "730";
            Console.Title = "Steam Game Faker Idler";
            Console.SetWindowSize(80, 5);
            foreach (string s in args)
            {
                Console.WriteLine("Steam Game {0} ready to start..", s);
            }
            Environment.SetEnvironmentVariable("SteamAppId", args[0]);
            if (SteamAPI_Init())
            {
                Console.Title = "Steam Game Faker Idler [CONNECTED]";
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("{0} started successfully!", args[0]);
            }
            else
            {
                Console.Title = "Steam Game Faker Idler [NOT ACTIVE]";
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} failed!", args[0]);
                Console.WriteLine("Connection failed!");
            }
            ConsoleIdle();
        }

        static string SteamRunning()
        {
            return (Process.GetProcessesByName("Steam").Length > 0) ? "Steam is running" : "Steam is not active. Please start or restart it.";
        }

        static void ConsoleIdle()
        {
            Console.WriteLine(SteamRunning());
            Console.WriteLine("Idling now..");
            Console.ReadLine();
        }
    }
}
