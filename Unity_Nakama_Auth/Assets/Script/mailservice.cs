using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
public class EmailSender : MonoBehaviour
{
    public string apiUrl = "http://localhost:8081/send_email";
    public void SendEmail(string recipientEmail, string subject, string body, string token)
    {
        StartCoroutine(SendEmailCoroutine(recipientEmail, subject, body, token));
    }
    private IEnumerator SendEmailCoroutine(string recipientEmail, string subject, string body, string token)
    {
        EmailRequest emailRequest = new EmailRequest
        {
            recipientEmail = recipientEmail,
            subject = subject,
            body = body,
            token = token
        };
        string jsonData = JsonUtility.ToJson(emailRequest);
        UnityWebRequest request = new UnityWebRequest(apiUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        yield return request.SendWebRequest();
        if (request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Email sent successfully: " + request.downloadHandler.text);
        }
        else
        {
            Debug.LogError("Error sending email: " + request.error);
        }
    }
    [System.Serializable]
    public class EmailRequest
    {
        public string recipientEmail;
        public string subject;
        public string body;
        public string token;
    }
}