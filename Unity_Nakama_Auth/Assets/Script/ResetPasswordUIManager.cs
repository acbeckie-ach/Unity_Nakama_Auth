using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Threading.Tasks;

public class ResetPasswordUIManager : MonoBehaviour
{
    public TMP_InputField emailInputField;
    public TMP_InputField tokenInputField;
    public TMP_InputField newPasswordInputField;
    public TMP_Text messageText;
    public Button resetPasswordButton;

    private RegisterManager registerManager;

    private void Start()
    {
        registerManager = FindObjectOfType<RegisterManager>();
        resetPasswordButton.onClick.AddListener(async () => await OnResetPasswordClicked());
    }

    private async Task OnResetPasswordClicked()
    {
        string email = emailInputField.text;
        string token = tokenInputField.text;
        string newPassword = newPasswordInputField.text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(token) || string.IsNullOrEmpty(newPassword))
        {
            messageText.text = "Please fill in all fields.";
            return;
        }

        await registerManager.ResetPassword(email, token, newPassword, messageText);
    }
}
