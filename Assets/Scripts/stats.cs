using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class stats : MonoBehaviour {
   // public Text score;

	// Use this for initialization
	void Start () {
        if (gameObject.name == "Score")
        {
            if (GameMaster.totalScore >= 100)
            {
                GetComponent<Text>().text = " " + GameMaster.totalScore;
            }
            else
            {
                GetComponent<Text>().text = " You have lost!";
            }

        }
        // score.text = "" + GameMaster.totalScore;

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
