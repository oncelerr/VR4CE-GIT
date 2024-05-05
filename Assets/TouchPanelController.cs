using UnityEngine;

public class TouchPanelController : MonoBehaviour
{
    public GameObject panel; // Reference to the panel to open/close
    public GameObject hand; // Reference to the hand GameObject

    private bool handTouching = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == hand)
        {
            handTouching = true;
            // Open the panel
            OpenPanel();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == hand)
        {
            handTouching = false;
            // Close the panel
            ClosePanel();
        }
    }

    private void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Panel reference is not set in TouchPanelController.");
        }
    }

    private void ClosePanel()
    {
        if (panel != null && !handTouching)
        {
            panel.SetActive(false);
        }
    }
}
