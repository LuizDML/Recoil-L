using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private string LevelInicial;
    [SerializeField]
    private string TransitionType;

    public void Jogar()
    {
        LevelManager.Instance.LoadScene(LevelInicial, TransitionType);
        //SceneManager.LoadScene(LevelInicial);

    }

    public void Sair()
    {
        Application.Quit();
    }

}
