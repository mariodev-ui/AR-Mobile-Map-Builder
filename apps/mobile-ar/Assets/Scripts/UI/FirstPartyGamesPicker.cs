using UnityEngine;
using UnityEngine.UI;

public class FirstPartyGamesPicker : MonoBehaviour
{
    public Button[] gameButtons;

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
        // Add your logic here to handle the selected game
    }
}
