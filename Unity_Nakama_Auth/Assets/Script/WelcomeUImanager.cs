using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;
using TMPro;

public class WelcomeUIManager : MonoBehaviour
{
    public TMP_Text messageText;
    public Button connectButton;

    private void Start()
    {
        connectButton.onClick.AddListener(async () => await OnConnectButtonClicked());
    }

    private async Task OnConnectButtonClicked()
    {
        messageText.text = "connecting";
        bool connected = await NakamaSessionManager.Instance.Connect();

        if (connected)
        {
            messageText.text = "connected";
            Debug.Log("Connected successfully.");
            SceneManager.LoadScene("AboutScene");
            // Load the next scene or handle post-connection logic here
        }
        else
        {
            Debug.LogError("Failed to connect.");
        }
    }
}