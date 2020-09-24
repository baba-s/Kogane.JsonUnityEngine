using JetBrains.Annotations;
using System;
using UnityEngine;

namespace Kogane
{
	public static class JsonUnityEngineDebug
	{
		[Serializable]
		private struct JsonData
		{
			[SerializeField][UsedImplicitly] public bool    developerConsoleVisible;
			[SerializeField][UsedImplicitly] public ILogger unityLogger;
			[SerializeField][UsedImplicitly] public bool    isDebugBuild;
		}

		public static string Get()
		{
			var jsonData = new JsonData
			{
				developerConsoleVisible = Debug.developerConsoleVisible,
				unityLogger             = Debug.unityLogger,
				isDebugBuild            = Debug.isDebugBuild,
			};

			return JsonUtility.ToJson( jsonData, true );
		}
	}
}