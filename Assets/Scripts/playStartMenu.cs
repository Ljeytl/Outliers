using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class playStartMenu : MonoBehaviour
{

    public void sceneLoader(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
