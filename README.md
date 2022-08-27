# Kogane Json Unity Engine

UnityEngine のいくつかの API の静的プロパティの情報を JSON 形式で取得できるクラス

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log( JsonUnityEngineApplication.Get() );
        Debug.Log( JsonUnityEngineDebug.Get() );
        Debug.Log( JsonUnityEngineSceneManagement.Get() );
        Debug.Log( JsonUnityEngineScreen.Get() );
        Debug.Log( JsonUnityEngineSystemInfo.Get() );
        Debug.Log( JsonUnityEngineTime.Get() );
    }
}
```
