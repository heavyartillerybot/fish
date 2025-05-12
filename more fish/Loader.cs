using UnityEngine;

namespace more fish
{
	public class Loader
	{
		/// <summary>
		/// This method is run by Winch to initialize your mod
		/// </summary>
		public static void Initialize()
		{
			var gameObject = new GameObject(nameof(more fish));
			gameObject.AddComponent<more fish>();
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}
}