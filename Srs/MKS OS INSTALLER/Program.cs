using System;
using System.Diagnostics;

namespace MKSOS_Installer
{
    class Program
    {
        static void Main()
        {
            Console.Title = "MKS-OS Downloader";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("MKS-OS DOWNLOADER");
                Console.WriteLine("=================\n");

                Console.WriteLine("1. Download MKS-OS Alpha");
                Console.WriteLine("2. Download MKS-OS 1.1");
                Console.WriteLine("3. Download MKS-OS 1.2");
                Console.WriteLine("4. Download MKS-OS 1.3");
                Console.WriteLine("5. Exit\n");

                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        OpenBrowser("https://github.com/maksimka1855/mks-oc");
                        break;
                    case "2":
                        OpenBrowser("https://github.com/maksimka1855/mks-oc-1.1");
                        break;
                    case "3":
                        OpenBrowser("https://github.com/maksimka1855/mks-os-bundle-set");
                        break;
                    case "4":
                        OpenBrowser("https://github.com/maksimka1855/mks-os-1.3");
                        break;
                    case "5":
                        Console.WriteLine("\nGoodbye!");
                        return;
                    default:
                        Console.WriteLine("\nInvalid choice!");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void OpenBrowser(string url)
        {
            Console.WriteLine($"\nOpening: {url}");

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
                Console.WriteLine("Browser opened successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"Please visit: {url}");
            }
        }
    }
}