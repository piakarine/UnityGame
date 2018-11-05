using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createPath : MonoBehaviour {
    public Transform lane1;
    public Transform lane2;
    public Transform lane3;
    public Transform lane4;
    public Transform lane5;
    private int lastPos = 0;



    // Use this for initialization
    void Start () {
        lastPos = createLanes(lastPos);
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 last = new Vector3(0,0,lastPos);
        float dist = Vector3.Distance(last, GameObject.Find("Player").transform.position);
        if (dist < 15f) {
            lastPos = createLanes(lastPos);
        }
		
	}

    int createLanes(int lastBlock) {
        int temp = 0;

        for (var i = lastBlock; i < lastBlock+60; i += 9) {
            int block = Random.Range(0, 6);
            switch (block)
            {
                case 1:
                    Instantiate(lane1, new Vector3(0, 0, i), lane1.rotation);
                    break;
                case 2:
                    Instantiate(lane2, new Vector3(0, 0, i), lane2.rotation);
                    break;
                case 3:
                    Instantiate(lane3, new Vector3(0, 0, i), lane3.rotation);
                    break;
                case 4:
                    Instantiate(lane4, new Vector3(0, 0, i), lane4.rotation);
                    break;
                case 5:
                    Instantiate(lane5, new Vector3(0, 0, i), lane4.rotation);
                    break;
                default:
                    Instantiate(lane1, new Vector3(0, 0, i), lane1.rotation);
                    break;

            }
            temp = i;

        }
        return temp+9;

    }
}
