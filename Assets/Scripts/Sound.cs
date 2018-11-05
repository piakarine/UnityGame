using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {

    public void SoundCtl(int j) {

        if (j == 1) {
            AudioListener.volume = 1;
        }
        if (j == 0)
        {
            AudioListener.volume = 0;
        }


    }
}
