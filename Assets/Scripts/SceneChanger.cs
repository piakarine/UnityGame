using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {
	
	// Update is called once per frame
	public void ChangeScence (int scene) {
        
            SceneManager.LoadScene(scene);
        
        
	}

    public void increaseLevel(int level) {
        if (level == 2 && GameMaster.totalScore >= 100) {
            GameMaster.playerSpeed += 4;
            SceneManager.LoadScene(1);
        }
    }
}
