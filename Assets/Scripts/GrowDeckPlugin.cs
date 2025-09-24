using UnityEngine;

public class GrowdeckPlugin : MonoBehaviour
{
#if UNITY_ANDROID && !UNITY_EDITOR
    private static AndroidJavaObject GetCurrentActivity()
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        return unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
    }

    public static void Init(string appId, string userId, string secretKey)
    {
        AndroidJavaObject activity = GetCurrentActivity();
        AndroidJavaClass sdkBridge = new AndroidJavaClass("io.growdeck.unity.GrowDeckSDK");
        sdkBridge.CallStatic("init", activity, appId, userId, secretKey);
    }

    public static void ShowOfferwall()
    {
        AndroidJavaObject activity = GetCurrentActivity();
        AndroidJavaClass sdkBridge = new AndroidJavaClass("io.growdeck.unity.GrowDeckSDK");
        sdkBridge.CallStatic("showOfferwall", activity);
    }
#else
    public static void Init(string appId, string userId, string secretKey)
    {
        Debug.Log("Growdeck Init called in Editor (no effect)");
    }

    public static void ShowOfferwall()
    {
        Debug.Log("Growdeck ShowOfferwall called in Editor (no effect)");
    }
#endif
}
