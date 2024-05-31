using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigation : MonoBehaviour
{
    public static void ToScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
