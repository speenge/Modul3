using System;
using System.Diagnostics;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace poweroff
{
    class Program
    {
        static void Main(string[] args)
        {

            Process p = new();
            p.StartInfo.FileName = "powershell.exe";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.StandardInput.WriteLine("function a($var){$dsd = $var * 60 shutdown - t $dsd - s }");
            p.StandardInput.WriteLine(args[0]);
            p.StandardInput.Flush();
            p.StandardInput.Close();

            Console.WriteLine("Job's done!");
        }
    }
}
