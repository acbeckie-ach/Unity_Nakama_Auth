//using System;
//using UnityEngine;
//using Nakama;
//using UnityEngine.SceneManagement;

//public class NakamaManager : MonoBehaviour
//{
//    public static NakamaManager Instance;
//    private IClient _client;
//    private ISession _session;

//    private void Awake()
//    {
//        if (Instance == null)
//        {
//            Instance = this;
//            DontDestroyOnLoad(gameObject);  // Persist between scenes
//        }
//        else
//        {
//            Destroy(gameObject);
//        }

//        // Initialize Nakama client (update this with the correct IP/URL if hosted elsewhere)
//        _client = new Client("http", "127.0.0.1", 7350, "defaultkey");
//    }

//    // Register a new user using email
//    public async void RegisterAccount(string email, string password)
//    {
//        try
//        {
//            var session = await _client.AuthenticateEmailAsync(email, password);
//            Debug.Log("Registration successful! Session token: " + session.AuthToken);
//            _session = session;
//            LoadCollaborativeScene();
//        }
//        catch (Exception e)
//        {
//            Debug.LogError("Registration failed: " + e.Message);
//        }
//    }

//    // Login an existing user
//    public async void LoginAccount(string email, string password)
//    {
//        try
//        {
//            var session = await _client.AuthenticateEmailAsync(email, password);
//            Debug.Log("Login successful! Session token: " + session.AuthToken);
//            _session = session;
//            LoadCollaborativeScene();
//        }
//        catch (Exception e)
//        {
//            Debug.LogError("Login failed: " + e.Message);
//        }
//    }

//    // Load the collaborative Unity scene hosted externally
//    private void LoadCollaborativeScene()
//    {
//        // After login or registration, load the next scene
//        // You can replace "CollaborativeTrainingScene" with the actual scene name
//        SceneManager.LoadScene("CollaborativeTrainingScene");
//    }
//}
