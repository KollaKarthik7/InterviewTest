// This script instantiates and fills the Rect container with the reward information.

using UnityEngine;
using UnityEngine.UI;

public class RewardManager : MonoBehaviour
{
    [SerializeField] DailyRewardInfo rewardInfo; // Stores the reward info scripatble object reference
    [SerializeField] GameObject rewardPanelPrefab; // Stores the reward panel prefab reference
    [SerializeField] Transform rewardPanelContainer; // Stores the transform of Rect where the rewards are instantiated

    private void Start()
    {
        InitializeRewards(); // Initializing rewards at the start of the game
    }

    void InitializeRewards()
    {
        // Loops through the RewardInfo scriptable object and instantiates the reward panels according to the data in the scriptable object
        foreach(DailyReward reward in rewardInfo.dailyRewards)
        {
            GameObject rewardPanel = Instantiate(rewardPanelPrefab, rewardPanelContainer); // Instantiate a reward panel for each data element in the scriptable object
            DailyRewardUI rewardUI = rewardPanel.GetComponent<DailyRewardUI>(); // Stores a reference of the DailyRewardUI script attached to the reward panel
            rewardUI.SetRewardUI(reward); // Sets the UI of the reward panel with the respective data in scriptable object

            Button claimButton = rewardPanel.GetComponentInChildren<Button>(); // Stores a reefrence of the button of the reward panel
            claimButton.onClick.AddListener(rewardUI.OnRewardButtonClick); // Assining a function to call when the button is clicked. (In this case the reward details are printed)
        }
    }
}
