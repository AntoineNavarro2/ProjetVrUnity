using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroscope : MonoBehaviour
{
  

    Vector3 rota;

    // Start is called before the first frame update
    void Start()
    {
        rota = Vector3.zero;
      Input.gyro.enabled = true;       
       
      
     
    }
   
 

    // Update is called once per frame
    void Update()
    {   
        
       rota.x = -Input.gyro.rotationRateUnbiased.x;
        rota.y = -Input.gyro.rotationRateUnbiased.y;
        rota.z = -Input.gyro.rotationRateUnbiased.z;
        
        transform.Rotate ( rota.x,  rota.y,  rota.z);
        
    }
 
    
  
}
