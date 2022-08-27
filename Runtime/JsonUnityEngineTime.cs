using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
    public static class JsonUnityEngineTime
    {
        [Serializable]
        private struct JsonData
        {
            [SerializeField][UsedImplicitly] public float captureDeltaTime;
            [SerializeField][UsedImplicitly] public float realtimeSinceStartup;
            [SerializeField][UsedImplicitly] public int   renderedFrameCount;
            [SerializeField][UsedImplicitly] public int   frameCount;
            [SerializeField][UsedImplicitly] public float timeScale;
            [SerializeField][UsedImplicitly] public float maximumParticleDeltaTime;
            [SerializeField][UsedImplicitly] public float smoothDeltaTime;
            [SerializeField][UsedImplicitly] public float maximumDeltaTime;
            [SerializeField][UsedImplicitly] public float fixedDeltaTime;
            [SerializeField][UsedImplicitly] public float fixedUnscaledDeltaTime;
            [SerializeField][UsedImplicitly] public float unscaledDeltaTime;
            [SerializeField][UsedImplicitly] public float fixedUnscaledTime;
            [SerializeField][UsedImplicitly] public float unscaledTime;
            [SerializeField][UsedImplicitly] public float fixedTime;
            [SerializeField][UsedImplicitly] public float deltaTime;
            [SerializeField][UsedImplicitly] public float timeSinceLevelLoad;
            [SerializeField][UsedImplicitly] public float time;
            [SerializeField][UsedImplicitly] public int   captureFramerate;
            [SerializeField][UsedImplicitly] public bool  inFixedTimeStep;
        }

        public static string Get()
        {
            var jsonData = new JsonData
            {
                captureDeltaTime         = Time.captureDeltaTime,
                realtimeSinceStartup     = Time.realtimeSinceStartup,
                renderedFrameCount       = Time.renderedFrameCount,
                frameCount               = Time.frameCount,
                timeScale                = Time.timeScale,
                maximumParticleDeltaTime = Time.maximumParticleDeltaTime,
                smoothDeltaTime          = Time.smoothDeltaTime,
                maximumDeltaTime         = Time.maximumDeltaTime,
                fixedDeltaTime           = Time.fixedDeltaTime,
                fixedUnscaledDeltaTime   = Time.fixedUnscaledDeltaTime,
                unscaledDeltaTime        = Time.unscaledDeltaTime,
                fixedUnscaledTime        = Time.fixedUnscaledTime,
                unscaledTime             = Time.unscaledTime,
                fixedTime                = Time.fixedTime,
                deltaTime                = Time.deltaTime,
                timeSinceLevelLoad       = Time.timeSinceLevelLoad,
                time                     = Time.time,
                captureFramerate         = Time.captureFramerate,
                inFixedTimeStep          = Time.inFixedTimeStep,
            };

            return JsonUtility.ToJson( jsonData, true );
        }
    }
}