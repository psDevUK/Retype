using System;
using System.Management.Automation;
using System.Diagnostics;

namespace RetypeRun
{
    [Cmdlet(VerbsData.Initialize, "ReTypeRun")]
    public class Retype : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string? Path { get; set; }
        protected override void EndProcessing()
        {
            string runPath = Path;
            ProcessStartInfo ProcessInfo;
            Process ProcessRun;
            ProcessInfo = new ProcessStartInfo("retype.exe", "run" + " " + runPath + " " + "--verbose");
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;
            ProcessRun = Process.Start(ProcessInfo);
            WriteObject("Running your Retype website:-" + " " + runPath);
        }
    }
}



namespace RetypeWatch
{
    [Cmdlet(VerbsData.Initialize, "ReTypeWatch")]
    public class Retype : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string? Path { get; set; }
        protected override void EndProcessing()
        {
            string watchPath = Path;
            ProcessStartInfo ProcessInfo;
            Process ProcessWatch;
            ProcessInfo = new ProcessStartInfo("retype.exe", "watch" + " " + watchPath + " " + "--verbose");
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;
            ProcessWatch = Process.Start(ProcessInfo);
            WriteObject("Building your Retype website which will be output to:-" + " " + watchPath);
        }
    }
}


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
            WriteObject("Initialization process started .yml file will be output here:-" + " " + projectPath);
        }
    }
}

namespace RetypeBuild
{
    [Cmdlet(VerbsData.Initialize, "ReTypeBuild")]
    public class Retype : PSCmdlet
    {
        [Parameter(Mandatory = true)]
        public string? Path { get; set; }
        protected override void EndProcessing()
        {
            string websitePath = Path;
            ProcessStartInfo ProcessInfo;
            Process ProcessBuild;
            ProcessInfo = new ProcessStartInfo("retype.exe", "build" + " " + websitePath + " " + "--verbose");
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;
            ProcessBuild = Process.Start(ProcessInfo);
            WriteObject("Building your Retype website which will be output to:-" + " " + websitePath);
        }
    }
}