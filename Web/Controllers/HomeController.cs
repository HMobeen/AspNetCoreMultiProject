using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            // Debugging Information 
            ViewData["Message"] = "Debugging Info.";

            ViewData["HOSTNAME"] = Environment.GetEnvironmentVariable("COMPUTERNAME") ??
                                            Environment.GetEnvironmentVar);
            ViewData["OSARCHITECTURE"] = RuntimeInformation.OSArchitecture;
            ViewData["OSDESCRIPTION"] = RuntimeInformation.OSDescription;
            ViewData["PROCESSARCHITECTURE"] = RuntimeInformation.ProcessArchitecture;
            ViewData["FRAMEWORKDESCRIPTION"] = RuntimeInformation.FrameworkDescription;
            ViewData["ASPNETCOREPACKAGEVERSION"] = Environment.GetEnvironmentVariable
            ViewData["ASPNETCORE_ENVIRONMENT"] = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            StringBuilder envVars = new StringBuilder();
            foreach (DictionaryEntry de in Environment.GetEnvironmentVariables())
                envVars.Append(string.Format("<strong>{0}</strong>:{1}<br \\>", de.Key, de.Value));

            ViewData["ENV_VARS"] = envVars.ToString();

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.traceback.Exception.TraceIdentifier });
        }

        using System;
using System.Diagnostics;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Create a long command with excessive arguments
                string longArgument = new string('a', 8000);  // A long argument
                string command = "curl";  // The command to run
                string arguments = $"{longArgument}";  // Argument that will be too long

                // Constructing the full command string
                string fullCommand = $"{command} {arguments}";
                
                // Attempt to execute the command
                ExecuteCommand(fullCommand);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private static void ExecuteCommand(string fullCommand)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("bash", $"-c \"{fullCommand}\"")
            {
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = processInfo;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine($"Output: {output}");
                Console.WriteLine($"Error: {error}");
            }
        }
    }
}

    }
}
