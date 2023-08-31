using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
  

   // Vector3 rota;
    private bool gyroEnable;
    private UnityEngine.Gyroscope gyro;
    private GameObject gyroControl;
    private Quaternion initalRotation;
    // Start is called before the first frame update
    void Start()
    {
       // rota = Vector3.zero;
           
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
        /*
       rota.x = -Input.gyro.rotationRateUnbiased.x;
        rota.y = -Input.gyro.rotationRateUnbiased.y;
        rota.z = -Input.gyro.rotationRateUnbiased.z;
        
        transform.Rotate ( rota.x,  rota.y,  rota.z);*/
        
    }
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
    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
 
    
  
}
