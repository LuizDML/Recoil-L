using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipManager : MonoBehaviour
{
    //[SerializeField]
    //private string ProximoLevel;
    //[SerializeField]
    //private string TransitionType;

    public void Skip()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //LevelManager.Instance.LoadScene(ProximoLevel, TransitionType);
    }

}
