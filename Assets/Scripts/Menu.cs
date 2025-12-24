using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
    public void Settings()
    {
        print("Settings");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
