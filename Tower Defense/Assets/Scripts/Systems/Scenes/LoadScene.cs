using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    [SerializeField] private string scene;
    
    public void OnButtonPress()
    {
        SceneManager.LoadScene(scene);
    }
}
