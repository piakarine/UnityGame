using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour {
    public Transform target;
    public Vector3 offSet;
    public float smoothedSpeed = 0.125f;

	// Use this for initialization
	/*void Start () {
        playerObj = GameObject.Find("Player");
        offSet = new Vector3(0, 5, -5);
        
	}*/
	
	// Update is called once per frame
	void FixedUpdate () {
        // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, GameMaster.playerSpeed);
        Vector3 desiredPos = target.position + offSet;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothedSpeed);
        smoothedPos.x = 0;
        transform.position = smoothedPos;

       // transform.LookAt(target);

    }
}
