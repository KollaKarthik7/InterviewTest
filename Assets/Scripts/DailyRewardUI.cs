// This script is attachedd to the Reward Panel Prefab. This script sets the reward day ui and reaward details ui when starting the game.

using TMPro;
using UnityEngine;

public class DailyRewardUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI rewardDayText; // Stores the reward day text reference
    [SerializeField] TextMeshProUGUI rewardText; // Stores the reward information text reference (Reward amount + Reward Type)

    DailyReward dReward;

    // Stores daily reward informantion and sets the reward ui.
    public void SetRewardUI(DailyReward dailyReward)
    {
        dReward = dailyReward;

        rewardDayText.text = "Day " + dReward.day;
        rewardText.text = dReward.rewardAmount + " " + dReward.rewardType;
    }

    // Prints the claimed reward details when the button of the respective reward is clicked.
    public void OnRewardButtonClick()
    {
        Debug.Log("Reward Claimed : " + "Day " + dReward.day + ", " + dReward.rewardAmount + " " + dReward.rewardType);
    }
}
