using UnityEngine;
using System.Collections;

public class ReflectWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision collision)
    {
        if(collision.gameObject.tag == "player")
        {
            collision.rigidbody.velocity = Vector3.Reflect(collision.rigidbody.velocity, Vector2.left);
        }

        //rigidbody.velocity = Vector3.Reflect(rigidbody.velocity, collision.contacts[0].normal);
    }
}
