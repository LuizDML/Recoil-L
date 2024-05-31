using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelObjective : Collectable {

    [SerializeField]
    private string ProximoLevel;

    protected override void CollectableEffect() {
        GameController.Checkpoint = Vector2.zero;

        LevelManager.Instance.LoadScene(ProximoLevel, "CrossFade");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
