using UnityEngine;
using System.Collections;

public class MeteorControllers : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(Vector2.left);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
