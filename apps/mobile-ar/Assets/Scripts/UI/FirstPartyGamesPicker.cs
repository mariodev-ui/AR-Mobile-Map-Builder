using UnityEngine;
using UnityEngine.UI;

public class FirstPartyGamesPicker : MonoBehaviour
{
    public Button[] gameButtons;
    public Text selectedGameText; // Add a Text component to display the selected game

    void Start()
    {
        for (int i = 0; i < gameButtons.Length; i++)
        {
            int index = i;
            gameButtons[i].onClick.AddListener(() => OnGameSelected(index));
        }
    }

    void OnGameSelected(int index)
    {
        Debug.Log($"Game {index + 1} selected");
        // Update the UI to show the selected game
        if (selectedGameText != null)
        {
            selectedGameText.text = $"Selected Game: {index + 1}";
        }
        // Add your logic here to handle the selected game
    }
}
