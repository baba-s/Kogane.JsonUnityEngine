using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kogane
{
    public static class JsonUnityEngineSystemInfo
    {
        [Serializable]
        private struct JsonData
        {
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsFragment;
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsVertex;
            [SerializeField][UsedImplicitly] public int                    maxCubemapSize;
            [SerializeField][UsedImplicitly] public int                    maxTextureSize;
            [SerializeField][UsedImplicitly] public NPOTSupport            npotSupport;
            [SerializeField][UsedImplicitly] public bool                   usesReversedZBuffer;
            [SerializeField][UsedImplicitly] public int                    supportsTextureWrapMirrorOnce;
            [SerializeField][UsedImplicitly] public bool                   supportsMultisampleAutoResolve;
            [SerializeField][UsedImplicitly] public bool                   supportsMultisampled2DArrayTextures;
            [SerializeField][UsedImplicitly] public int                    supportsMultisampledTextures;
            [SerializeField][UsedImplicitly] public int                    supportedRandomWriteTargetCount;
            [SerializeField][UsedImplicitly] public bool                   supportsSeparatedRenderTargetsBlend;
            [SerializeField][UsedImplicitly] public int                    supportedRenderTargetCount;
            [SerializeField][UsedImplicitly] public bool                   supportsSparseTextures;
            [SerializeField][UsedImplicitly] public bool                   supports32bitsIndexBuffer;
            [SerializeField][UsedImplicitly] public bool                   supportsHardwareQuadTopology;
            [SerializeField][UsedImplicitly] public bool                   supportsInstancing;
            [SerializeField][UsedImplicitly] public bool                   supportsRenderTargetArrayIndexFromVertexShader;
            [SerializeField][UsedImplicitly] public bool                   supportsTessellationShaders;
            [SerializeField][UsedImplicitly] public bool                   supportsGeometryShaders;
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsGeometry;
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsDomain;
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsHull;
            [SerializeField][UsedImplicitly] public int                    maxComputeBufferInputsCompute;
            [SerializeField][UsedImplicitly] public HDRDisplaySupportFlags hdrDisplaySupportFlags;
            [SerializeField][UsedImplicitly] public bool                   usesLoadStoreActions;
            [SerializeField][UsedImplicitly] public bool                   supportsMipStreaming;
            [SerializeField][UsedImplicitly] public bool                   hasMipMaxLevel;
            [SerializeField][UsedImplicitly] public bool                   supportsConservativeRaster;
            [SerializeField][UsedImplicitly] public int                    constantBufferOffsetAlignment;
            [SerializeField][UsedImplicitly] public bool                   supportsRayTracing;
            [SerializeField][UsedImplicitly] public bool                   supportsAsyncGPUReadback;
            [SerializeField][UsedImplicitly] public bool                   supportsGraphicsFence;
            [SerializeField][UsedImplicitly] public bool                   supportsGpuRecorder;
            [SerializeField][UsedImplicitly] public bool                   supportsAsyncCompute;
            [SerializeField][UsedImplicitly] public int                    maxComputeWorkGroupSizeZ;
            [SerializeField][UsedImplicitly] public int                    maxComputeWorkGroupSizeY;
            [SerializeField][UsedImplicitly] public int                    maxComputeWorkGroupSizeX;
            [SerializeField][UsedImplicitly] public int                    maxComputeWorkGroupSize;
            [SerializeField][UsedImplicitly] public bool                   supportsSetConstantBuffer;
            [SerializeField][UsedImplicitly] public bool                   supportsComputeShaders;
            [SerializeField][UsedImplicitly] public CopyTextureSupport     copyTextureSupport;
            [SerializeField][UsedImplicitly] public bool                   supportsCubemapArrayTextures;
            [SerializeField][UsedImplicitly] public bool                   supportsAudio;
            [SerializeField][UsedImplicitly] public bool                   supportsLocationService;
            [SerializeField][UsedImplicitly] public bool                   supportsGyroscope;
            [SerializeField][UsedImplicitly] public bool                   supportsAccelerometer;
            [SerializeField][UsedImplicitly] public string                 deviceModel;
            [SerializeField][UsedImplicitly] public string                 deviceName;
            [SerializeField][UsedImplicitly] public DeviceType             deviceType;
            [SerializeField][UsedImplicitly] public string                 deviceUniqueIdentifier;
            [SerializeField][UsedImplicitly] public int                    processorCount;
            [SerializeField][UsedImplicitly] public int                    processorFrequency;
            [SerializeField][UsedImplicitly] public string                 processorType;
            [SerializeField][UsedImplicitly] public OperatingSystemFamily  operatingSystemFamily;
            [SerializeField][UsedImplicitly] public string                 operatingSystem;
            [SerializeField][UsedImplicitly] public BatteryStatus          batteryStatus;
            [SerializeField][UsedImplicitly] public float                  batteryLevel;
            [SerializeField][UsedImplicitly] public int                    systemMemorySize;
            [SerializeField][UsedImplicitly] public int                    graphicsMemorySize;
            [SerializeField][UsedImplicitly] public bool                   supportsVibration;
            [SerializeField][UsedImplicitly] public string                 graphicsDeviceVendor;
            [SerializeField][UsedImplicitly] public bool                   supports3DRenderTextures;
            [SerializeField][UsedImplicitly] public bool                   supports2DArrayTextures;
            [SerializeField][UsedImplicitly] public bool                   supportsCompressed3DTextures;
            [SerializeField][UsedImplicitly] public bool                   supports3DTextures;
            [SerializeField][UsedImplicitly] public string                 graphicsDeviceName;
            [SerializeField][UsedImplicitly] public bool                   supportsRawShadowDepthSampling;
            [SerializeField][UsedImplicitly] public bool                   supportsShadows;
            [SerializeField][UsedImplicitly] public bool                   hasDynamicUniformArrayIndexingInFragmentShaders;
            [SerializeField][UsedImplicitly] public bool                   supportsMotionVectors;
            [SerializeField][UsedImplicitly] public RenderingThreadingMode renderingThreadingMode;
            [SerializeField][UsedImplicitly] public bool                   hasHiddenSurfaceRemovalOnGPU;
            [SerializeField][UsedImplicitly] public int                    graphicsDeviceID;
            [SerializeField][UsedImplicitly] public int                    graphicsDeviceVendorID;
            [SerializeField][UsedImplicitly] public GraphicsDeviceType     graphicsDeviceType;
            [SerializeField][UsedImplicitly] public string                 graphicsDeviceVersion;
            [SerializeField][UsedImplicitly] public int                    graphicsShaderLevel;
            [SerializeField][UsedImplicitly] public bool                   graphicsMultiThreaded;
            [SerializeField][UsedImplicitly] public bool                   graphicsUVStartsAtTop;
        }

        public static string Get()
        {
            var jsonData = new JsonData
            {
                maxComputeBufferInputsFragment                  = SystemInfo.maxComputeBufferInputsFragment,
                maxComputeBufferInputsVertex                    = SystemInfo.maxComputeBufferInputsVertex,
                maxCubemapSize                                  = SystemInfo.maxCubemapSize,
                maxTextureSize                                  = SystemInfo.maxTextureSize,
                npotSupport                                     = SystemInfo.npotSupport,
                usesReversedZBuffer                             = SystemInfo.usesReversedZBuffer,
                supportsTextureWrapMirrorOnce                   = SystemInfo.supportsTextureWrapMirrorOnce,
                supportsMultisampleAutoResolve                  = SystemInfo.supportsMultisampleAutoResolve,
                supportsMultisampled2DArrayTextures             = SystemInfo.supportsMultisampled2DArrayTextures,
                supportsMultisampledTextures                    = SystemInfo.supportsMultisampledTextures,
                supportedRandomWriteTargetCount                 = SystemInfo.supportedRandomWriteTargetCount,
                supportsSeparatedRenderTargetsBlend             = SystemInfo.supportsSeparatedRenderTargetsBlend,
                supportedRenderTargetCount                      = SystemInfo.supportedRenderTargetCount,
                supportsSparseTextures                          = SystemInfo.supportsSparseTextures,
                supports32bitsIndexBuffer                       = SystemInfo.supports32bitsIndexBuffer,
                supportsHardwareQuadTopology                    = SystemInfo.supportsHardwareQuadTopology,
                supportsInstancing                              = SystemInfo.supportsInstancing,
                supportsRenderTargetArrayIndexFromVertexShader  = SystemInfo.supportsRenderTargetArrayIndexFromVertexShader,
                supportsTessellationShaders                     = SystemInfo.supportsTessellationShaders,
                supportsGeometryShaders                         = SystemInfo.supportsGeometryShaders,
                maxComputeBufferInputsGeometry                  = SystemInfo.maxComputeBufferInputsGeometry,
                maxComputeBufferInputsDomain                    = SystemInfo.maxComputeBufferInputsDomain,
                maxComputeBufferInputsHull                      = SystemInfo.maxComputeBufferInputsHull,
                maxComputeBufferInputsCompute                   = SystemInfo.maxComputeBufferInputsCompute,
                hdrDisplaySupportFlags                          = SystemInfo.hdrDisplaySupportFlags,
                usesLoadStoreActions                            = SystemInfo.usesLoadStoreActions,
                supportsMipStreaming                            = SystemInfo.supportsMipStreaming,
                hasMipMaxLevel                                  = SystemInfo.hasMipMaxLevel,
                supportsConservativeRaster                      = SystemInfo.supportsConservativeRaster,
                constantBufferOffsetAlignment                   = SystemInfo.constantBufferOffsetAlignment,
                supportsRayTracing                              = SystemInfo.supportsRayTracing,
                supportsAsyncGPUReadback                        = SystemInfo.supportsAsyncGPUReadback,
                supportsGraphicsFence                           = SystemInfo.supportsGraphicsFence,
                supportsGpuRecorder                             = SystemInfo.supportsGpuRecorder,
                supportsAsyncCompute                            = SystemInfo.supportsAsyncCompute,
                maxComputeWorkGroupSizeZ                        = SystemInfo.maxComputeWorkGroupSizeZ,
                maxComputeWorkGroupSizeY                        = SystemInfo.maxComputeWorkGroupSizeY,
                maxComputeWorkGroupSizeX                        = SystemInfo.maxComputeWorkGroupSizeX,
                maxComputeWorkGroupSize                         = SystemInfo.maxComputeWorkGroupSize,
                supportsSetConstantBuffer                       = SystemInfo.supportsSetConstantBuffer,
                supportsComputeShaders                          = SystemInfo.supportsComputeShaders,
                copyTextureSupport                              = SystemInfo.copyTextureSupport,
                supportsCubemapArrayTextures                    = SystemInfo.supportsCubemapArrayTextures,
                supportsAudio                                   = SystemInfo.supportsAudio,
                supportsLocationService                         = SystemInfo.supportsLocationService,
                supportsGyroscope                               = SystemInfo.supportsGyroscope,
                supportsAccelerometer                           = SystemInfo.supportsAccelerometer,
                deviceModel                                     = SystemInfo.deviceModel,
                deviceName                                      = SystemInfo.deviceName,
                deviceType                                      = SystemInfo.deviceType,
                deviceUniqueIdentifier                          = SystemInfo.deviceUniqueIdentifier,
                processorCount                                  = SystemInfo.processorCount,
                processorFrequency                              = SystemInfo.processorFrequency,
                processorType                                   = SystemInfo.processorType,
                operatingSystemFamily                           = SystemInfo.operatingSystemFamily,
                operatingSystem                                 = SystemInfo.operatingSystem,
                batteryStatus                                   = SystemInfo.batteryStatus,
                batteryLevel                                    = SystemInfo.batteryLevel,
                systemMemorySize                                = SystemInfo.systemMemorySize,
                graphicsMemorySize                              = SystemInfo.graphicsMemorySize,
                supportsVibration                               = SystemInfo.supportsVibration,
                graphicsDeviceVendor                            = SystemInfo.graphicsDeviceVendor,
                supports3DRenderTextures                        = SystemInfo.supports3DRenderTextures,
                supports2DArrayTextures                         = SystemInfo.supports2DArrayTextures,
                supportsCompressed3DTextures                    = SystemInfo.supportsCompressed3DTextures,
                supports3DTextures                              = SystemInfo.supports3DTextures,
                graphicsDeviceName                              = SystemInfo.graphicsDeviceName,
                supportsRawShadowDepthSampling                  = SystemInfo.supportsRawShadowDepthSampling,
                supportsShadows                                 = SystemInfo.supportsShadows,
                hasDynamicUniformArrayIndexingInFragmentShaders = SystemInfo.hasDynamicUniformArrayIndexingInFragmentShaders,
                supportsMotionVectors                           = SystemInfo.supportsMotionVectors,
                renderingThreadingMode                          = SystemInfo.renderingThreadingMode,
                hasHiddenSurfaceRemovalOnGPU                    = SystemInfo.hasHiddenSurfaceRemovalOnGPU,
                graphicsDeviceID                                = SystemInfo.graphicsDeviceID,
                graphicsDeviceVendorID                          = SystemInfo.graphicsDeviceVendorID,
                graphicsDeviceType                              = SystemInfo.graphicsDeviceType,
                graphicsDeviceVersion                           = SystemInfo.graphicsDeviceVersion,
                graphicsShaderLevel                             = SystemInfo.graphicsShaderLevel,
                graphicsMultiThreaded                           = SystemInfo.graphicsMultiThreaded,
                graphicsUVStartsAtTop                           = SystemInfo.graphicsUVStartsAtTop,
            };

            return JsonUtility.ToJson( jsonData, true );
        }
    }
}