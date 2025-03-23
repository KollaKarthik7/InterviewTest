# InterviewTest
 Daily reward UI (Scroll View)

Please read before downloading the project.

Developed in Unity 6 (6000.0.28f1)

Daily Rewards System in Unity

This Unity project implements a Daily Rewards System using a ScrollView to display rewards for each day. 
Rewards are stored in a ScriptableObject, and clicking a reward logs the reward details in the Console.

Features
     1. Vertically Scrollable UI: Displays daily rewards in a ScrollView.
     2. ScriptableObject Data Storage: Stores rewards for easy customization.
     3. Dynamic UI Population: Automatically creates UI elements for each reward.
     4. Clickable Rewards: Logs the reward details when clicked.

Project Structure
     Assets/
     ├── Scripts/
     │   ├── DailyRewardData.cs        # ScriptableObject for reward storage
     │   ├── DailyRewardUI.cs          # Handles individual reward UI
     │   ├── DailyRewardManager.cs     # Manages UI population
     │
     ├── Prefabs/
     │   ├── RewardItem.prefab         # UI template for rewards
     │
     ├── UI/
     │   ├── ScrollRect                # Parent UI element for reward list

