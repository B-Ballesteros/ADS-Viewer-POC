using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS_Viewer.Utilities
{
    internal static class ADSUtility
    {
        public static void GetADSFrom(string fileName, Logger? logger)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    logger?.AddToLog($"Unable to find file: {fileName}");
                    return;
                }
                RunCommandFor(fileName, logger);
            }
            catch (Exception ex)
            {
                logger?.AddToLog($"Error: {ex.Message}");
                Debug.WriteLine(ex.ToString());
            }
        }

        private static void RunCommandFor(string file, Logger? logger)
        {
            try
            {
                logger?.AddToLog("Creating command...");
                string command = @$"Get-Item '{file}' -Stream *";
                ProcessStartInfo info = new()
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"{command}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                logger?.AddToLog("Starting process...");
                Process process = new()
                {
                    StartInfo = info
                };
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                logger?.AddToLog($"{output}");
                string error = process.StandardError.ReadToEnd();
                if (!string.IsNullOrEmpty(error))
                {
                    logger?.AddToLog($"Error: {error}");
                }
                process.WaitForExit();
            }catch(Exception ex)
            {
                logger?.AddToLog($"Error: {ex.Message}");
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}
