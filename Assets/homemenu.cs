using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void ReturnHome()
    {
        SceneManager.LoadSceneAsync(0);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
