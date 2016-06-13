using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreController : MonoBehaviour {

    Text scoreText;
	// Use this for initialization
	void Start () {
        scoreText = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "x " + GameManager.instance.Gold;
	}
}
