using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
    public static class JsonUnityEngineScreen
    {
        [Serializable]
        private struct JsonData
        {
            [SerializeField][UsedImplicitly] public FullScreenMode    fullScreenMode;
            [SerializeField][UsedImplicitly] public float             brightness;
            [SerializeField][UsedImplicitly] public int               sleepTimeout;
            [SerializeField][UsedImplicitly] public ScreenOrientation orientation;
            [SerializeField][UsedImplicitly] public bool              autorotateToLandscapeRight;
            [SerializeField][UsedImplicitly] public bool              autorotateToLandscapeLeft;
            [SerializeField][UsedImplicitly] public bool              autorotateToPortraitUpsideDown;
            [SerializeField][UsedImplicitly] public bool              autorotateToPortrait;
            [SerializeField][UsedImplicitly] public Rect[]            cutouts;
            [SerializeField][UsedImplicitly] public Rect              safeArea;
            [SerializeField][UsedImplicitly] public bool              fullScreen;
            [SerializeField][UsedImplicitly] public Resolution[]      resolutions;
            [SerializeField][UsedImplicitly] public Resolution        currentResolution;
            [SerializeField][UsedImplicitly] public float             dpi;
            [SerializeField][UsedImplicitly] public int               height;
            [SerializeField][UsedImplicitly] public int               width;
        }

        public static string Get()
        {
            var jsonData = new JsonData
            {
                fullScreenMode                 = Screen.fullScreenMode,
                brightness                     = Screen.brightness,
                sleepTimeout                   = Screen.sleepTimeout,
                orientation                    = Screen.orientation,
                autorotateToLandscapeRight     = Screen.autorotateToLandscapeRight,
                autorotateToLandscapeLeft      = Screen.autorotateToLandscapeLeft,
                autorotateToPortraitUpsideDown = Screen.autorotateToPortraitUpsideDown,
                autorotateToPortrait           = Screen.autorotateToPortrait,
                cutouts                        = Screen.cutouts,
                safeArea                       = Screen.safeArea,
                fullScreen                     = Screen.fullScreen,
                resolutions                    = Screen.resolutions,
                currentResolution              = Screen.currentResolution,
                dpi                            = Screen.dpi,
                height                         = Screen.height,
                width                          = Screen.width,
            };

            return JsonUtility.ToJson( jsonData, true );
        }
    }
}