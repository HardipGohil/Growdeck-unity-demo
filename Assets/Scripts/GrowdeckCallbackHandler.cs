using UnityEngine;

public class GrowdeckCallbackHandler : MonoBehaviour
{
    public void OnGrowdeckInitSuccess(string message)
    {
        Debug.Log("GrowDeck Init Success: " + message);
    }

    public void OnGrowdeckInitFailed(string error)
    {
        Debug.LogError("GrowDeck Init Failed: " + error);
    }

    public void OnRewardReceive(string rewardStr)
    {
         if (decimal.TryParse(rewardStr, out decimal reward))
        {
            Debug.Log("GrowDeck Reward: " + reward);
        }
        else
        {
            Debug.LogError("GrowDeck Invalid reward format: " + rewardStr);
        }
    }
}
