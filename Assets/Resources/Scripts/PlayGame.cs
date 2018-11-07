using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void Play()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(nextScene + 1);
    }
}
