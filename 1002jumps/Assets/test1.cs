using UnityEngine;
using System.Collections;

public class test1 : MonoBehaviour {

    public int lol;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(lol, 0) * 100);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
