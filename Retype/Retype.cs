using System;
using System.Management.Automation;
using System.Diagnostics;
using Microsoft.PowerShell;
namespace RetypeProject
{
    [Cmdlet(VerbsData.Initialize, "ReTypeProject")]
    public class Retype : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string? Path { get; set; }
        protected override void EndProcessing()
        {
            string projectPath = Path;
            ProcessStartInfo ProcessInfo;
            Process ProcessInitialise;
            ProcessInfo = new ProcessStartInfo("retype.exe", "init" + " " + projectPath);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;
            ProcessInitialise = Process.Start(ProcessInfo);
            WriteObject("Initialization process started .yml file will be output here:-" + " ");
        }
    }
}



