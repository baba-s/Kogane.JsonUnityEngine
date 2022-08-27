using System;
using JetBrains.Annotations;
using UnityEngine;

namespace Kogane
{
    public static class JsonUnityEngineApplication
    {
        [Serializable]
        private struct JsonData
        {
            [SerializeField][UsedImplicitly] public string                 installerName;
            [SerializeField][UsedImplicitly] public string                 version;
            [SerializeField][UsedImplicitly] public string                 unityVersion;
            [SerializeField][UsedImplicitly] public string                 absoluteURL;
            [SerializeField][UsedImplicitly] public string                 temporaryCachePath;
            [SerializeField][UsedImplicitly] public string                 persistentDataPath;
            [SerializeField][UsedImplicitly] public string                 identifier;
            [SerializeField][UsedImplicitly] public string                 streamingAssetsPath;
            [SerializeField][UsedImplicitly] public bool                   isBatchMode;
            [SerializeField][UsedImplicitly] public string                 buildGUID;
            [SerializeField][UsedImplicitly] public bool                   isFocused;
            [SerializeField][UsedImplicitly] public bool                   isPlaying;
            [SerializeField][UsedImplicitly] public string                 dataPath;
            [SerializeField][UsedImplicitly] public ApplicationInstallMode installMode;
            [SerializeField][UsedImplicitly] public ApplicationSandboxType sandboxType;
            [SerializeField][UsedImplicitly] public string                 productName;
            [SerializeField][UsedImplicitly] public NetworkReachability    internetReachability;
            [SerializeField][UsedImplicitly] public SystemLanguage         systemLanguage;
            [SerializeField][UsedImplicitly] public bool                   isConsolePlatform;
            [SerializeField][UsedImplicitly] public bool                   isMobilePlatform;
            [SerializeField][UsedImplicitly] public RuntimePlatform        platform;
            [SerializeField][UsedImplicitly] public bool                   genuineCheckAvailable;
            [SerializeField][UsedImplicitly] public bool                   genuine;
            [SerializeField][UsedImplicitly] public ThreadPriority         backgroundLoadingPriority;
            [SerializeField][UsedImplicitly] public string                 consoleLogPath;
            [SerializeField][UsedImplicitly] public int                    targetFrameRate;
            [SerializeField][UsedImplicitly] public string                 cloudProjectId;
            [SerializeField][UsedImplicitly] public string                 companyName;
            [SerializeField][UsedImplicitly] public bool                   runInBackground;
            [SerializeField][UsedImplicitly] public bool                   isEditor;
        }

        public static string Get()
        {
            var jsonData = new JsonData
            {
                installerName             = Application.installerName,
                version                   = Application.version,
                unityVersion              = Application.unityVersion,
                absoluteURL               = Application.absoluteURL,
                temporaryCachePath        = Application.temporaryCachePath,
                persistentDataPath        = Application.persistentDataPath,
                identifier                = Application.identifier,
                streamingAssetsPath       = Application.streamingAssetsPath,
                isBatchMode               = Application.isBatchMode,
                buildGUID                 = Application.buildGUID,
                isFocused                 = Application.isFocused,
                isPlaying                 = Application.isPlaying,
                dataPath                  = Application.dataPath,
                installMode               = Application.installMode,
                sandboxType               = Application.sandboxType,
                productName               = Application.productName,
                internetReachability      = Application.internetReachability,
                systemLanguage            = Application.systemLanguage,
                isConsolePlatform         = Application.isConsolePlatform,
                isMobilePlatform          = Application.isMobilePlatform,
                platform                  = Application.platform,
                genuineCheckAvailable     = Application.genuineCheckAvailable,
                genuine                   = Application.genuine,
                backgroundLoadingPriority = Application.backgroundLoadingPriority,
                consoleLogPath            = Application.consoleLogPath,
                targetFrameRate           = Application.targetFrameRate,
                cloudProjectId            = Application.cloudProjectId,
                companyName               = Application.companyName,
                runInBackground           = Application.runInBackground,
                isEditor                  = Application.isEditor,
            };

            return JsonUtility.ToJson( jsonData, true );
        }
    }
}