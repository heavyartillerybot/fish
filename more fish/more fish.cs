using UnityEngine;
using Winch.Core;

namespace more fish
{
	public class more fish : MonoBehaviour
	{
		public void Awake()
		{
			WinchCore.Log.Debug($"{nameof(more fish)} has loaded!");
		}
	}
}
