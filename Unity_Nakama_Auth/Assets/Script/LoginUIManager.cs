using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading.Tasks;
using Nakama;
using UnityEngine.SceneManagement;


public class LoginUIManager : MonoBehaviour
{
    public TMP_InputField emailInputField;
    public TMP_InputField passwordInputField;
    public TMP_Text errorMessageText;
    public Button LoginButton;
    public Button forgotPasswordButton;

    private RegisterManager registerManager;

    private void Start()
    {
        //the RegisterManager is already present because its a singleton
        registerManager = FindObjectOfType<RegisterManager>();

        //attach the listener to the login button
        LoginButton.onClick.AddListener(async () => await OnLoginButtonClicked());

        //attach the listener to forgotpassword button
        forgotPasswordButton.onClick.AddListener(OnForgotPasswordClicked);

    }

    private async Task OnLoginButtonClicked()
    {
        string email = emailInputField.text;
        string password = passwordInputField.text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
        {
            errorMessageText.text = "Email or password cannot be empty.";
            return;
        }

        //call RegisterUIManager to log in the user and pass the error message text object
        await registerManager.LoginUser(email, password, errorMessageText);
        
    }

    private void OnForgotPasswordClicked()
    {
        SceneManager.LoadScene("ForgotPasswordScene");
    }


}


