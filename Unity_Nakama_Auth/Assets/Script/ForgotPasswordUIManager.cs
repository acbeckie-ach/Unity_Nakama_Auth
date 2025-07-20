using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class ForgotPasswordUIManager : MonoBehaviour
{
    public TMP_InputField emailInputField;
    public TMP_Text messageText;
    public Button sendResetTokenButton;
    public Button continueButton;

    private RegisterManager registerManager;

    private void Start()
    {
        registerManager = FindObjectOfType<RegisterManager>();
        sendResetTokenButton.onClick.AddListener(async () => await OnSendResetTokenClicked());
        continueButton.onClick.AddListener(OnContinueButtonClicked);
        continueButton.gameObject.SetActive(false);
    }

    private async Task OnSendResetTokenClicked()
    {
        string email = emailInputField.text;
        Debug.Log($"[ForgotPasswordUIManager] Reset button clicked for email: {email}");

        if (string.IsNullOrEmpty(email))
        {
            messageText.text = "Please enter your email.";
            Debug.LogError("[ForgotPasswordUIManager] No email entered.");
            return;
        }

        string token = await registerManager.RequestPasswordReset(email, messageText);
        Debug.Log($"[ForgotPasswordUIManager] Token generated: {token}");

        if (!string.IsNullOrEmpty(token))
        {
            messageText.text = "Password reset email sent!";
            continueButton.gameObject.SetActive(true);
        }
        else
        {
            messageText.text = "Failed to generate reset token.";
            Debug.LogError("[ForgotPasswordUIManager] Failed to generate reset token.");
        }
    }

    private void OnContinueButtonClicked()
    {
        SceneManager.LoadScene("ResetPasswordScene");
    }
}
