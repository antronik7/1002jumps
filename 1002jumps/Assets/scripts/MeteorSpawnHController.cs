using UnityEngine;
using System.Collections;

public class MeteorSpawnHController : MonoBehaviour {

    public GameObject[] meteors;
    public int Direction;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            int randomIndex = Random.Range(0, meteors.Length);
            float randomY = Random.Range(transform.position.y + 1f, transform.position.y + 3f);

            int randomAngle;

            if (randomY > 1)
            {
                randomAngle = Random.Range(20, -10);
            }
            else
            {
                randomAngle = Random.Range(20, 0);
            }

            GameObject leMeteor = Instantiate(meteors[randomIndex], new Vector3(4 * Direction, randomY, 0), Quaternion.Euler(new Vector3(0, 0, randomAngle))) as GameObject;

            int angle = randomAngle * Direction;

            

            Vector3 dir;

            if (Direction < 0)
            {
                dir = Quaternion.AngleAxis(angle, Vector3.up) * Vector3.right;
            }
            else
            {
                dir = Quaternion.AngleAxis(angle, Vector3.up) * Vector3.left;
            }
            

            leMeteor.GetComponent<Rigidbody2D>().AddForce(new Vector2 (dir.x, dir.z) * 150);

            Destroy(gameObject);
        }
    }
}
