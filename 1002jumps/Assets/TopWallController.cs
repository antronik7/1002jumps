using UnityEngine;
using System.Collections;

public class TopWallController : MonoBehaviour {

    int side = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (GameManager.instance.gameStart)
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log(coll.rigidbody.velocity);

            if(coll.rigidbody.velocity.x > 0)
            {
                side = -1;
            }
            else
            {
                side = 1;
            }

            //coll.transform.rotation.SetFromToRotation(coll.rigidbody.velocity,Vector3.Reflect(coll.rigidbody.velocity, Vector2.left));
            Vector3 laNouvelleDir = Vector3.Reflect(coll.rigidbody.velocity, Vector3.down);

            coll.transform.rotation = Quaternion.Euler(0, 0, side * Vector3.Angle(Vector3.down, laNouvelleDir));
        }
    }
}
