using UnityEngine;
using System.Collections;

public class ForRotation : MonoBehaviour {

    private int speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(-60, 60);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, Time.deltaTime * speed);
    }
}
