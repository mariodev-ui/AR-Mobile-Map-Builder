using UnityEngine;

public class OverlayMode : MonoBehaviour
{
    public GameObject event5Overlay;
    private bool isEvent5Active = false;

    void Start()
    {
        // Initialize the overlay and set it to inactive initially
        if (event5Overlay != null)
        {
            event5Overlay.SetActive(false);
        }
    }

    public void ActivateEvent5Overlay()
    {
        if (!isEvent5Active && event5Overlay != null)
        {
            isEvent5Active = true;
            event5Overlay.SetActive(true);
        }
    }

    public void DeactivateEvent5Overlay()
    {
        if (isEvent5Active && event5Overlay != null)
        {
            isEvent5Active = false;
            event5Overlay.SetActive(false);
        }
    }
}
