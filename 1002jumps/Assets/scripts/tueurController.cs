using UnityEngine;
using System.Collections;

public class tueurController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(GameManager.instance.gameStart)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * (GameManager.instance.speed + GameManager.instance.Score / 10)));
        }
    }
}
