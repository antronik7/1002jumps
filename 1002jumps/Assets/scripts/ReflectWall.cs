using UnityEngine;
using System.Collections;

public class ReflectWall : MonoBehaviour {

    public int side;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player")
        {
            //coll.transform.rotation.SetFromToRotation(coll.rigidbody.velocity,Vector3.Reflect(coll.rigidbody.velocity, Vector2.left));
            Vector3 laNouvelleDir = Vector3.Reflect(coll.rigidbody.velocity, Vector3.left);

            Debug.Log(Vector3.Angle(Vector3.up, laNouvelleDir));

            coll.transform.rotation = Quaternion.Euler(0, 0, side * Vector3.Angle(Vector3.up, laNouvelleDir));
        }
    }
}
