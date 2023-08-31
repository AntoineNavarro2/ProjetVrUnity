using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class client : NetworkBehaviour
{
    private  GameObject la_phobie = null;
    [ClientRpc]
    public void UpdateQuelqueChose(string nom_son, string nom_skybox)
    {
        Debug.Log("Client Only SON");
        AudioClip son = null;
        Material skybox = null;

        son = Resources.Load($"sounds/{nom_son}") as AudioClip;
        skybox = Resources.Load($"skybox/{nom_skybox}") as Material;

        GameObject mp3 = new GameObject("MusicClient");
        mp3.AddComponent<AudioSource>();
        mp3.GetComponent<AudioSource>().clip = son;
        mp3.GetComponent<AudioSource>().loop = true;
        mp3.GetComponent<AudioSource>().Play();

        RenderSettings.skybox = skybox;
    }



    [ClientRpc]
    public void DeleteData()
    {
        Debug.Log("Client Only DELETE");
        var music = GameObject.Find("MusicClient");
        if(music != null)
        {
            Destroy(music);
        }

        var sky = Resources.Load($"skybox/base") as Material;

        RenderSettings.skybox = sky;


        if(la_phobie!= null)
        {
            Destroy(la_phobie);
        }
        
    }

    [ClientRpc]

    public void UpdateGameObject(string type_niveau, int difficulte)
    {
        Debug.Log("Client Only OBJECT");
        switch (type_niveau)
        {
            case "Arachnophobie":

             if (difficulte == 5)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderClient";
                    la_phobie.transform.position = spiderPosition;
                }
                 if (difficulte == 6)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderClient";
                    la_phobie.transform.position = spiderPosition;
                }
                 if (difficulte == 7)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderClient";
                    la_phobie.transform.position = spiderPosition;
                }
                if (difficulte == 8)
                {
                    var spiderPrefab = Resources.Load($"3d/spider") as GameObject;
                    Vector3 spiderPosition = new Vector3(10, -10, 1);
                    la_phobie = Instantiate(spiderPrefab);
                    la_phobie.name = "SpiderClient";
                    la_phobie.transform.position = spiderPosition;
                }


                break;
            case "Ophiophobie":
              if (difficulte== 5)
                {
                    var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                    Vector3 snakePosition = new Vector3(18, -25, 60);
                    la_phobie = Instantiate(snakePrefab);
                    la_phobie.name = "SnakeClient";
                    la_phobie.transform.position = snakePosition;
                }
               if(difficulte==6)
               {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition = new Vector3(18, -25, 60);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeClient";
                la_phobie.transform.position = snakePosition;
               }
                if(difficulte==7)
               {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition =new Vector3(18, -25, 60);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeClient";
                la_phobie.transform.position = snakePosition;
               }
                if(difficulte==8)
               {
                var snakePrefab = Resources.Load($"3d/snake") as GameObject;
                Vector3 snakePosition = new Vector3(18, -25, 60);
                la_phobie = Instantiate(snakePrefab);
                la_phobie.name = "SnakeClient";
                la_phobie.transform.position = snakePosition;
               }
               
                break;
            case "Acrophobie":
              if (difficulte == 5)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3 acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroClient";
                    la_phobie.transform.position = acroPosition;
                }
                if(difficulte==6)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroClient";
                    la_phobie.transform.position = acroPosition;
                }
                 if(difficulte==7)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroClient";
                    la_phobie.transform.position = acroPosition;
                }
                if(difficulte==8)
                {
                    var acroPrefab = Resources.Load($"3d/acro") as GameObject;
                    Vector3  acroPosition = new Vector3(5, 1, -4);
                    la_phobie = Instantiate(acroPrefab);
                    la_phobie.name = "AcroClient";
                    la_phobie.transform.position = acroPosition;
                }
                break;
        }


    }


    public void UpdatePhobieObject(string type_niveau, int difficulte)
    {
        Debug.Log("UpdataData From Client Phobie");
        UpdateGameObject(type_niveau, difficulte);

    }

    public void UpdateData(string nom_son, string nom_skybox)
    {
        Debug.Log("UpdataData From Client Son");
        UpdateQuelqueChose(nom_son,nom_skybox);

    }
}
