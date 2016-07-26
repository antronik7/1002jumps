using UnityEngine;
using System.Collections;

public class spikeController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Pas sposser passer la");
            GameManager.instance.RestartGame();
        }
    }
}
