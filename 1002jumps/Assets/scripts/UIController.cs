using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

    Text scoreText;
    Text HighScoreText;
    // Use this for initialization
    void Start () {
        scoreText = transform.GetChild(0).GetComponent<Text>();
        HighScoreText = transform.GetChild(1).GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = GameManager.instance.Score.ToString();
        HighScoreText.text = GameManager.instance.HighScore.ToString();
    }
}
