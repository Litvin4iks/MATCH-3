using UnityEngine;
using YG;

public class RewardAdManager : MonoBehaviour
{
    public YandexGame sdk;

    public void ClickingButtomPlay()
    {
        sdk._RewardedShow(1);
    }
}
