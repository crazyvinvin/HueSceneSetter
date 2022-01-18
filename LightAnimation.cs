using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Newtonsoft.Json;

namespace HalloweenLightsWFA
{
	public class LightAnimation
	{
		public int LightAnimationNumber { get; }
		public string LightName { get; set; }
		public int[] RGB { get; set; }
		public int Repeat { get; set; }
		public TimeSpan TransitionTime { get; set; }

		public LightAnimation(int _lightAnimationNumber)
		{
			LightAnimationNumber = _lightAnimationNumber;
		}

		public bool CheckLightNameUniqueness(List<LightAnimation> _lightAnimations)
		{
			foreach (LightAnimation _Animation in _lightAnimations)
			{
				if (_Animation.LightName == LightName)
				{
					return false;
				}
			}
			return true;
		}

		public string GetInJson()
		{
			string JSON = JsonConvert.SerializeObject(this);
			return JSON;
		}	
	}
}
