using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
  
    private bool gyroEnable;
    private UnityEngine.Gyroscope gyro;
    private GameObject gyroControl;
    private Quaternion initalRotation;
    // Start is called before the first frame update
    void Start()
    {
       
           
       gyroEnable = EnableGyro();
      initalRotation = Quaternion.Euler(90f,0f,0f);

     
    }
   
 
    // Update is called once per frame
    void Update()
    {   

        if(gyroEnable) 
        {
            Quaternion gyroQuaternion = GyroToUnity(Input.gyro.attitude);
            Quaternion calculatedRotation = initalRotation * gyroQuaternion;
            transform.rotation = calculatedRotation;
        }
      
    }
    /// <summary>
    /// Permet de vérifier si le Gyroscope est possible si oui il active 
    /// </summary>
    /// <returns>Retourne un booléen True ou False</returns>
     private bool EnableGyro()
    {

        if(SystemInfo.supportsGyroscope)
        {

            gyro = Input.gyro;
            gyro.enabled = true;

            gyroControl = new GameObject("Gyro Control");
            gyroControl.transform.position = transform.position;
            transform.SetParent(gyroControl.transform);

            return true;


        }
        return false;
    }
    /// <summary>
    /// Permet de convertir la valeur du gyroscope du téléphone pour que Unity l'interprètre
    /// </summary>
    /// <param name="q">Prends en paramètre </param>
    /// <returns>Retourne la valeur du gyroscope</returns>
    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
 
    
  
}
