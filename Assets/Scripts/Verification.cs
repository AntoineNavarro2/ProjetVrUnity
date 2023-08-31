using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Mirror.Discovery;

public class Verification : MonoBehaviour
{



    public bool DEBUG;
    public GameObject networkManager;
    private NetworkDiscovery discovery;
    private NetworkManager CurrentNetworkManager;
   
    // Start is called before the first frame update
    void Start()
    { 
        CurrentNetworkManager = networkManager.GetComponent<MyNetworkManager>();
        if (DEBUG)
        {
            CurrentNetworkManager.StartServer();
            CurrentNetworkManager.StartClient();

            return;

        }

        RuntimePlatform platform = Application.platform;
        discovery = networkManager.GetComponent<NetworkDiscovery>();

        if (platform == RuntimePlatform.WindowsEditor || platform == RuntimePlatform.WindowsPlayer)
        {
            Debug.Log("Application is running on Windows");
                            
            SetupServer();
        }
        else if (platform == RuntimePlatform.Android)
        {
            Debug.Log("Application is running on Android");
            Screen.orientation = ScreenOrientation.LandscapeLeft;
                    
            SetupClient();
             
        }




    }

    /// <summary>
    /// Permet de lancer le serveur et afficher les menus
    /// </summary>
    void SetupServer()
    {
        CurrentNetworkManager.StartServer();
        discovery.AdvertiseServer();
        Debug.Log("Server OK!");

    }

    /// <summary>
    /// Permet de lancer la synchronisation 
    /// </summary>
    void SetupClient()
    {
        discovery.StartDiscovery();
        

    }

    /// <summary>
    /// Permet de connecter le client au serveur
    /// </summary>
    /// <param name="inf">Prends en paramètre l'url du serveur</param>
    public void OnDiscoveredServer(ServerResponse inf)
    {

        Connect(inf);

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="inf">Prends en paramètre la réponse du serveur</param>
    void Connect(ServerResponse inf)
    {
        discovery.StopDiscovery();
       CurrentNetworkManager.StartClient(inf.uri);
    }

}
