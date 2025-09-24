using UnityEngine;
using UnityEngine.UI;

public class GrowdeckButtonHandler : MonoBehaviour
{
    void Start()
    {
        // (Optional) Init SDK at app start
        GrowdeckPlugin.Init("APP_ID", "USER_ID", "SECRET");
    }

    public void OnShowOfferwallClicked()
    {
        GrowdeckPlugin.ShowOfferwall();
    }
}
