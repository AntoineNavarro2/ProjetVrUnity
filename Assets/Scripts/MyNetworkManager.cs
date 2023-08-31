using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MyNetworkManager : NetworkManager
{
    /// <summary>
    /// Permet d'indiquer que l'application PC est lancé
    /// </summary>
    public override void OnStartServer()
    {
        Debug.Log("Server Started!");
    }
    /// <summary>
    /// Permet d'indiquer que l'application PC est stoppé
    /// </summary>
    public override void OnStopServer()
    {
        Debug.Log("Server Stopped!");
    }
    /// <summary>
    /// Permet d'indiquer que l'application Android est connecté
    /// </summary>
    public override void OnClientConnect()
    {
        Debug.Log("Connected to Server!");
    }
    /// <summary>
    /// Permet d'indiquer que l'application Android est arreté
    /// </summary>
    public override void OnClientDisconnect()
    {
        Debug.Log("Disconnected from Server!");
    }
}
