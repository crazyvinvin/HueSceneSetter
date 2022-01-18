using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using Q42.HueApi;
using Q42.HueApi.ColorConverters;
using System.Threading;
using Q42.HueApi.ColorConverters.Gamut;
using Q42.HueApi.ColorConverters.HSB;
using Q42.HueApi.ColorConverters.Original;

namespace HalloweenLightsWFA
{
	class SceneController
	{
		public string IP { get; set; }
		public string Situation { get; set; }
		private bool Registered { get; set; }
		private bool ClientInited;
		private LocalHueClient Client;

		public SceneController()  
		{
			if (File.Exists("BridgeIP.txt") == false)
			{
				File.WriteAllText("BridgeIP.txt", "empty");
			}

			if(File.ReadAllText("BridgeIP.txt") != "empty")
			{
				CreateHueClient();
			} 
			else 
			{
				CreateHueClient("000.000.00.00");
				Console.WriteLine("[SceneController] IP not obtained yet, created fake Client");
			}
			ClientInited = false;
		}

		public void StartConnectToBridge()
		{
			CreateHueClient(IP);
		}

		public void StartConnectToBridge(string IP)
		{
			CreateHueClient(IP);
		}

		public async Task<Boolean> FinishConnectToBridge()
		{
			bool finished = false;
			await Register();
			return finished;
		}

		private void CreateHueClient()
		{
			IP = File.ReadAllText("BridgeIP.txt");
			Client = new LocalHueClient(IP);
			Console.WriteLine($"[SceneController] Created Client with IP: {IP}");
		}
		private void CreateHueClient(string IP)
		{
			Client = new LocalHueClient(IP);
			Console.WriteLine($"[SceneController] Created Client with IP: {IP}");
			File.WriteAllText("BridgeIP.txt", IP);
		}

		public async Task<Boolean> Register()
		{
			try
			{
				string appKey = await Client.RegisterAsync("CrazySceneBuilder", "Device");
				Console.WriteLine($"[SceneController] Register app at Hue Bridge, received appkey is: {appKey}");
				File.WriteAllText("Config.txt", appKey);
				Registered = true;
				return Registered;
			}
			catch(Exception)
			{
				Registered = false;
				return Registered;
			}
		}
		private async void Register(int SleepMiliseconds = 0)
		{
			try
			{
				Thread.Sleep(SleepMiliseconds);
				string appKey = await Client.RegisterAsync("CrazySceneBuilder", "Device");
				Console.WriteLine($"[SceneController] Register app at Hue Bridge, received appkey is: {appKey}");
				File.WriteAllText("Config.txt", appKey);
				Registered = true;
			}
			catch (Exception)
			{
				Registered = false;
			}
		}
		public bool IsRegistered()
		{
			return Registered;
		}

		public bool StartLights(List<LightAnimation> lightAnimations)
		{
			InitClient();

			foreach(LightAnimation animation in lightAnimations)
			{
				LightCommand command = new LightCommand
				{
					On = true,
					TransitionTime = animation.TransitionTime,
				};
				command.SetColor(new RGBColor(animation.RGB[0], animation.RGB[1], animation.RGB[2]));
				Client.SendCommandAsync(command, new List<string> { animation.LightName });
			}

			LightCommand command2 = new LightCommand
			{
				//Alert = Alert.Once
				On = true,
				Effect = Effect.ColorLoop
			};

			Client.SendCommandAsync(command2, new List<string> { "38" });
			//Client.SendCommandAsync(command);
			return true;
		}

		public async Task<IEnumerable<Light>> getLights()
		{
			InitClient();
			IEnumerable<Light> Lights = await Client.GetLightsAsync();
			IEnumerable<Light> OrderedLights = Lights.OrderBy(light => light.Id);
			return OrderedLights;
		}

		private bool InitClient()
		{
			if (ClientInited == true) { return true; }
			else
			{
				string appkey = File.ReadAllText("Config.txt");
				Client.Initialize(appkey);
				ClientInited = true;
				Console.WriteLine($"[SceneController] Initialized Client with appkey: {appkey}");
			}
			return true;
		}
	}
}
