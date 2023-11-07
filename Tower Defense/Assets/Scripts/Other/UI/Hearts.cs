using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Hearts : MonoBehaviour
{
    void Start()
    {
        GetComponent<TMP_Text>().text = GameManager.hearts.ToString();
    }

    public void LoseHearts()
    {
        GameManager.hearts--;
        GetComponent<TMP_Text>().text = GameManager.hearts.ToString();
        if (GameManager.hearts <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
