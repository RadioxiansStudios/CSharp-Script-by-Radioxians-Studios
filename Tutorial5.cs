// © 2026 Radioxians Studios. All Rights Reserved.
// v 1.0
//  You can study and observe this script, but you cannot modify it, publish it, or sell it; it will violate the copyright (©) of Radioxians Studios.
// This script is on Git Hub

using System.Collections.Generic;
using UnityEngine;

public class Tutorial5 : MonoBehaviour
{
    [SerializeField] private List<string> videogame = new List<string> {"Roblox", "FNF"};
    [SerializeField] private List<string> graphicengines = new List<string> {"Unity", "Unreal", "Godot", "Core", "Roblox Studio"};

    void Start()
    {
        foreach(string videogioco in videogame)
        {
            Debug.Log("My favourite game is " + videogioco);
        }

        videogame.Add("FNAF");
        Debug.Log("My favourite game is " + videogame[2]);

        int scelta = 2; 

        switch (scelta)
        {
                case 1:
                Debug.Log("I like " + graphicengines[0]); 
                break;

                case 2:
                Debug.Log("I like " + graphicengines[1]); 
                break;

                case 3:
                Debug.Log("I like" + graphicengines[2]); 
                break;

                case 4:
                Debug.Log("I like " + graphicengines[3]); 
                break;

                case 5:
                Debug.Log("I like " + graphicengines[4]); 
                break;

            default:
                Debug.Log("I dont like graphic engines");
                break;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            videogame.Add("Poppy Playtime");
            Debug.Log("New Game Added! I also like: " + videogame.Count);
        }
    }
}