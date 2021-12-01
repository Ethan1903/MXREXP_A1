using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Simple menu navigation
public class MenuNavigation : MonoBehaviour
{
    public GameObject currentPanel;

    private void Start()
    {
        currentPanel.SetActive(true);
    }

    public void SwitchPage(GameObject nextPage)
    {
        currentPanel.SetActive(false);
        currentPanel = nextPage;
        nextPage.SetActive(true);
    }

    public void OnStartScanningPressed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void OnLoginClicked()
    {

    }
}
