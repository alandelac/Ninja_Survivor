using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlHighScore : MonoBehaviour
{
    public int highscore;
    // Start is called before the first frame update
    void Start()
    {
        SetScore();
    }
    public void SetScore()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        gameObject.GetComponent<Text>().text="HIGHSCORE: "+highscore;
    }
}
