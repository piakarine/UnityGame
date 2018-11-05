using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Player").transform.position.z - transform.position.z > 15) {
            Destroy(this.gameObject);
        }
		
	}
}
