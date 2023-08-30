using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Niveau : MonoBehaviour
{
    
    public (string, string) ChoixNiveau(string type_niveau, int difficulte_niveau)
    {
        string skybox_nom = "";
        string son_nom = "";
        GameObject la_phobie = null;



        switch (type_niveau)
        {
            case "Arachnophobie":
                skybox_nom = "spider_skybox";
                son_nom = "spider_audio";
               

                 if (difficulte_niveau == 5)
                {
                    skybox_nom = "rassurantspider";
                     var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderServer";
                    la_phobie.transform.position = spiderPosition;
                }

                if(difficulte_niveau==6)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderServer";
                    la_phobie.transform.position = spiderPosition;
                }
                 if(difficulte_niveau==7)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderServer";
                    la_phobie.transform.position = spiderPosition;
                }
                 if(difficulte_niveau==8)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderServer";
                    la_phobie.transform.position = spiderPosition;
                }
               

                break;
            case "Ophiophobie":
                skybox_nom = "snake_skybox";
                son_nom = "snake_audio";
               

                if (difficulte_niveau == 5)
                {
                    skybox_nom = "rassurantsnake";
                    var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                    Vector3 snakePosition = new Vector3(1, -100, 0);
                    la_phobie = Instantiate(snakePrefab);
                    la_phobie.name = "SnakeServer";
                    la_phobie.transform.position = snakePosition;
                }
                if(difficulte_niveau ==6)
                {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition = new Vector3(10, 1, 0);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeServer";
                la_phobie.transform.position = snakePosition;
                }
                if(difficulte_niveau ==7)
                {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition = new Vector3(10, 1, 0);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeServer";
                la_phobie.transform.position = snakePosition;
                }
                 if(difficulte_niveau ==8)
                {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition = new Vector3(10, 1, 0);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeServer";
                la_phobie.transform.position = snakePosition;
                }
                
                break;
            case "Acrophobie":
                skybox_nom = "acro_skybox";
                son_nom = "acro_audio";
              

                 if (difficulte_niveau == 5)
                {
                    skybox_nom = "rassurantacro";
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroServer";
                    la_phobie.transform.position = acroPosition;
                }
                if(difficulte_niveau==6)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroServer";
                    la_phobie.transform.position = acroPosition;
                }

                if(difficulte_niveau==7)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroServer";
                    la_phobie.transform.position = acroPosition;
                }

                if(difficulte_niveau==8)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroServer";
                    la_phobie.transform.position = acroPosition;
                }
                break;
        }
        switch (difficulte_niveau)
        {

            case 1:
                skybox_nom += "1";
                son_nom += "1";
                break;
            case 2:
                skybox_nom += "2";
                son_nom += "2";
                break;
            case 3:
                skybox_nom += "3";
                son_nom += "3";
                break;
            case 4:
                skybox_nom += "4";
                son_nom += "4";
                break;
            case 5:
                skybox_nom += "5";
                son_nom += "5";
                break;
            case 6:
                skybox_nom += "6";
                son_nom += "6";
                break;
            case 7:
                skybox_nom += "7";
                son_nom += "7";
                break;
            case 8:
                skybox_nom += "8";
                son_nom += "8";
                break;
        }

        return (skybox_nom, son_nom);

    }



    public GameObject choixniveau;
    public Scrollbar difficulte;
    public Button commencer;

    public int mini = 1;
    public int maxi = 8;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = commencer.GetComponent<Button>();
        btn.onClick.AddListener(Load);

    }

    void Load()
    {
        var difficulte_niveau = Mathf.RoundToInt(difficulte.value * (maxi - mini) + mini);

        Debug.Log(choixniveau.tag);
        Debug.Log(difficulte_niveau);
       

        AudioClip son = null;
        Material skybox = null;
        string son_nom = null;
        string skybox_nom = null;
      

        (skybox_nom, son_nom) = ChoixNiveau(choixniveau.tag, difficulte_niveau);


        Debug.Log(skybox_nom);
        Debug.Log(son_nom);
       


        son = Resources.Load($"sounds/{son_nom}") as AudioClip;
        skybox = Resources.Load($"skybox/{skybox_nom}") as Material;

        GameObject mp3 = new GameObject("MusicServer");
        mp3.AddComponent<AudioSource>();
        mp3.GetComponent<AudioSource>().clip = son;
        mp3.GetComponent<AudioSource>().loop = true;
        mp3.GetComponent<AudioSource>().Play();

        RenderSettings.skybox = skybox;


        GameObject ClientSync = GameObject.Find("ClientSync");
        ClientSync.GetComponent<client>().UpdateData(son_nom, skybox_nom);
        ClientSync.GetComponent<client>().UpdatePhobieObject(choixniveau.tag, difficulte_niveau);




    }

    
      
    





}
