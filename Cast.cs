using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloweenLightsWFA
{
    class Cast
    {
        public string castName;
        public string mediaURL;
        public void Start()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Python39\python.exe";
            

            var script = @"C:\Users\Vincent\Documents\Code\CrazySceneBuilder\PythonScripts\CastingScript.py";
            castName = "http://192.168.42.28:5000/fbdownload/ScarySounds.mp3?tid=%22WzDZi755bSOGOQ4fgzESMxJY3mvk4eLMG9rXQ%22&mode=open&dlink=%222f5365727665722f56696e63656e74204f6e7a696e2f5363617279536f756e64732e6d7033%22&stdhtml=true&SynoToken=U9caDTlMRY6KM";
            mediaURL = "Televisie";
            psi.Arguments = $"\"{script}\"\"{castName}\"\"{mediaURL}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
        }
    }
}
