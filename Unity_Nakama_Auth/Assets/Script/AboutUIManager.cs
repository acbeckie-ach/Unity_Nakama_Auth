using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutUIManager : MonoBehaviour
{
    // Method for the New User button
    public void OnNewUserButtonClicked()
    {
        SceneManager.LoadScene("RegisterScene"); // Load RegisterScene for new users
    }

    // Method for the Existing User button
    public void OnExistingUserButtonClicked()
    {
        SceneManager.LoadScene("LoginScene"); // Load LoginScene for existing users
    }
}
