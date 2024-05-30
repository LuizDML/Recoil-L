using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class AutoskipVideo : MonoBehaviour {
    VideoPlayer player;

    bool played = false;

    //[SerializeField]
    //private string ProximoLevel;
    //[SerializeField]
    //private string TransitionType;

    //bool carregar = false;

    // Start is called before the first frame update
    void Start() {
        player = this.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update() {
        if (player.isPlaying) played = true;

        if (played && player != null && (long) player.frameCount - 10 <= player.frame)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            //if (carregar == false)
            //{
                //LevelManager.Instance.LoadScene(ProximoLevel, TransitionType);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //carregar = true;
                //GameObject.Find("Canvas").GetComponent<Canvas>().worldCamera = GameObject.Find("Main Camera").GetComponent<Camera>();

            //}
    }
}
