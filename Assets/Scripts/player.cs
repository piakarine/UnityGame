using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour {

    public AudioClip audioClip;
    public AudioClip coinsClip;
    public AudioSource audioSource;
    //public float horizPos = 0;
    public int row = 2;
    public int horizMove=0;
    private int lockMove = 0;
    private float ScreenWidth;



    // Use this for initialization
    void Start () {
        StartCoroutine(finishGame());
        ScreenWidth = Screen.width*0.5f;

    }
	
	// Update is called once per frame
	void Update () {
       // horizMove = (int)(Input.GetAxis("Horizontal"));
        GetComponent<Rigidbody>().velocity = new Vector3(GameMaster.horizPos, 0, GameMaster.playerSpeed);
        int i = 0;
        while (i < Input.touchCount) {
            // move right
            if (Input.GetTouch(i).position.x > ScreenWidth) {
                moveP(2);
            }
            if (Input.GetTouch(i).position.x < ScreenWidth)
            {
                moveP(1);
            }
            ++i;
        }
        
    }
    void FixedUpdate() {
#if UNITY_EDITOR
        if(Input.GetAxis("Horizontal")> 0){
        moveP(2);
        }
        if(Input.GetAxis("Horizontal")< 0){
        moveP(1);
        }
#endif
#if UNITY_WEBGL
        if(Input.GetAxis("Horizontal")> 0){
        moveP(2);
        }
        if(Input.GetAxis("Horizontal")< 0){
        moveP(1);
        }
#endif
    }

    void moveP(int k) {
        if (k==1 && row > 1 && lockMove == 0)
        {
            GameMaster.horizPos = -2;
            StartCoroutine(movePlayer());
            row -= 1;
            lockMove = 1;
        }
        if (k==2 && row < 4 && lockMove == 0)
        {
            GameMaster.horizPos = 2;
            StartCoroutine(movePlayer());
            row += 1;
            lockMove = 1;
        }

    }
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "killer") {
            //Destroy(gameObject);
            // change scene to final scene
            audioSource.clip = audioClip;
            audioSource.Play();
            GameMaster.totalScore = 0;
            SceneManager.LoadScene(2);



        }
        if (other.gameObject.name == "Capsule") {
            audioSource.clip = coinsClip;
            audioSource.Play();
            Destroy(other.gameObject);
            // increase a counter
            GameMaster.totalScore += 2;
        }
    }

    void OnTriggerEnter(Collider other) {

        if (other.gameObject.name == "Black") {
            // decrease a variable
            GameMaster.totalScore -= 2;
        }
    }
    IEnumerator movePlayer() {
        yield return new WaitForSeconds(0.5f);
        GameMaster.horizPos = 0;
        lockMove = 0;
    }

    IEnumerator finishGame()
    {
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene(2);
    }

}
