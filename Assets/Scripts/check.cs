using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class check : MonoBehaviour
{
    public Scrollbar diffuclte_selector;
    public TMP_Text difficulty_text;
    public TMP_Text descprition_text;

    public int mini = 1;
    public int maxi = 8;


    string Despcrition(int level_diffculte)
    {
        string msg = "";

        switch(level_diffculte)
        {
            case 1:
                msg += "Espace calme\n- Un son pouvant faire penser à la phobie est joué";
                break;
            case 2:
                msg += "Espace calme\n- Un son de la phobie est joué";
                break;
            case 3:
                msg += "Espace moyen\n- Une image lointain ou floue est visible";
                break;
            case 4:
                msg += "Espace moyen\n- Une image d'un jouet est visble";
                break;
            case 5:
                msg += "Espace moyen\n- Une image de la phobie mais avec des éléments rassurants";
                break;
            case 6:
                msg += "Espace agité\n- Une image 3d réel de la phobie est visible";
                break;
            case 7:
                msg += "Espace calme\n-  Une image 3d réel de la phobie est visible et un son environnement";
                break;
            case 8:
                msg += "Espace calme\n-  Une image 3d réel de la phobie est visible et le son de la phobie";
                break;

        }
        return msg;
    }

    private void OnScrollbarValue(float value)
    {
        int currentStep = Mathf.RoundToInt(value * (maxi - mini) + mini);
        difficulty_text.text = "Niveau " + currentStep.ToString();
        descprition_text.text = Despcrition(currentStep);

    }

    // Start is called before the first frame update
    void Start()
    {
        diffuclte_selector.onValueChanged.AddListener(OnScrollbarValue);
    }

    
}
