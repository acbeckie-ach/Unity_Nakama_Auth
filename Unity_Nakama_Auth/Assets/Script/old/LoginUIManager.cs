using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegisterUIManager : MonoBehaviour
{
    public TMP_InputField EmailInputField;
    public TMP_InputField PasswordInputField;
    public Text errorMessageText;
    public Button LoginButton;

    //private void Start()
    //{
    //    RegisterButton.onClick.AddListener(OnRegisterButtonClicked);
    //    LoginButton.onClick.AddListener(OnLoginButtonClicked);
    //}

    //private void OnRegisterButtonClicked()
    //{
    //    string email = EmailInputField.text;
    //    string password = PasswordInputField.text;

    //    if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
    //    {
    //        // Call the registration function in NakamaManager
    //        NakamaManager.Instance.RegisterAccount(email, password);
    //    }
    //    else
    //    {
    //        Debug.LogError("Email or Password cannot be empty!");
    //    }
    //}

    //private void OnLoginButtonClicked()
    //{
    //    string email = EmailInputField.text;
    //    string password = PasswordInputField.text;

    //    if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
    //    {
    //        // Call the login function in NakamaManager
    //        NakamaManager.Instance.LoginAccount(email, password);
    //    }
    //    else
    //    {
    //        Debug.LogError("Email or Password cannot be empty!");
    //    }
    //}
}
