using UnityEngine;

[System.Serializable]
public class DailyReward // A class holding the daily reward details
{
    public int day;
    public string rewardType;
    public int rewardAmount;
}

[CreateAssetMenu(fileName = "DailyRewardInfo", menuName = "ScriptableObjects/DailyRewardInfo")]
public class DailyRewardInfo : ScriptableObject // A scriptable object which can hold an array of daily reward details
{
    public DailyReward[] dailyRewards;
}
