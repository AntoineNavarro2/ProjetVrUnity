using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quitter : MonoBehaviour
{
    public Button Quitter;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = Quitter.GetComponent<Button>();
        btn.onClick.AddListener(Quit);
    }

    /// <summary>
    /// Permet lors du clic sur le bouton Quitter de supprimer coté Android et Pc de remettre les ressources à 0
    /// </summary>
    void Quit()
    {

        GameObject ClientSync = GameObject.Find("ClientSync");
        ClientSync.GetComponent<client>().DeleteData();


        var current_phobie = GameObject.Find("SpiderServer");

        if (current_phobie == null)
        {
            current_phobie = GameObject.Find("SnakeServer");
            if(current_phobie == null)
            {
                current_phobie=GameObject.Find("AcroServer");
            }
           
        }



        if (current_phobie != null)
        {
            Destroy(current_phobie);
        }



        var music = GameObject.Find("MusicServer");
        if (music != null)
        {
            Destroy(music);
        }

        var sky = Resources.Load($"skybox/base") as Material;

        RenderSettings.skybox = sky;



    }
}
