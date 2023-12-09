using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject congrats;
    // Start is called before the first frame update
    void Start()
    {
        Congrats(false);
    }

    void OnTriggerEnter()
    {
        Congrats(true);
        Invoke("NextLvl", 3f);
    }

    void NextLvl()
    {
        print("NextLevel");

        int nextSceneId = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextSceneId >= SceneManager.sceneCountInBuildSettings) {
            SceneManager.LoadScene(0);
        } else {
            SceneManager.LoadScene(nextSceneId);
        }
    }

    void Congrats(bool state)
    {
        congrats.SetActive(state);
    }
}
