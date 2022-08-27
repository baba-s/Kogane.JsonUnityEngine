using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Kogane
{
    public static class JsonUnityEngineSceneManagement
    {
        [Serializable]
        private struct JsonData
        {
            [SerializeField][UsedImplicitly] public int sceneCountInBuildSettings;
            [SerializeField][UsedImplicitly] public int sceneCount;
        }

        public static string Get()
        {
            var jsonData = new JsonData
            {
                sceneCountInBuildSettings = SceneManager.sceneCountInBuildSettings,
                sceneCount                = SceneManager.sceneCount,
            };

            return JsonUtility.ToJson( jsonData, true );
        }
    }
}