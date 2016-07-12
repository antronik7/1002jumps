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
            transform.Translate(Vector3.up * (Time.deltaTime * (2.5f + GameManager.instance.Score / 10)));
        }
    }
}
