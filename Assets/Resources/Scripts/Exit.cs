using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button ExitButton;

   public void exitGame()
   {
    Application.Quit();
   }
}
