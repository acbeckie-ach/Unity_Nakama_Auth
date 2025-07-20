//using System.Collections;
//using System.Collections.Generic;
//using Nakama;
//using UnityEngine;

//public class NakamaConnect : MonoBehaviour
//{
//    private string scheme = "http";

//    private string host = "localhost";

//    private int port = 7350;

//    private string serverKey = "defaultkey";

//    private IClient client;
//    private ISession session;
//    private ISocket socket;

  
//    async void Start()
//    {
//        client = new Nakama.Client(scheme, host, port, serverKey, UnityWebRequestAdapter.Instance);
//        session = await client.AuthenticateDeviceAsync(SystemInfo.deviceUniqueIdentifier);
//        socket = client.NewSocket();
//        await socket.ConnectAsync(session, true);

//        Debug.Log(session);
//        Debug.Log(socket);
//    }

    
//}
