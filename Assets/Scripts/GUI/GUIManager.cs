using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject audioManager;
    public GameObject gameController;

    public void Scene_Loader(int index)
    {
        SceneManager.LoadScene(index);
    }
}
