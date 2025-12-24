using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int score = 0;
    public float MyFloat;
    public Text TextScore;

    // Start is called before the first frame update
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Save()
    {
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.Save();
        TextScore.text = "Score: "+score.ToString();
    }
    public void Load()
    {
        score = PlayerPrefs.GetInt("Score");
        TextScore.text = "Score: "+score.ToString();
    }
}
