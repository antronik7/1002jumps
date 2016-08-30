using UnityEngine;
using System.Collections;

public class gunController : MonoBehaviour {

    public GameObject laser;
    GameObject player;
    GameObject leLaser;
    float angle;

    bool goThere = true;

    // Use this for initialization
    void Start () {
        player = GameManager.instance.getPlayer();
        //InvokeRepeating("LaunchProjectile", 4, 2);
    }
	
	// Update is called once per frame
	void Update () {
        if(player != null)
        {
            Vector3 dir = player.transform.position - transform.position;
            angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        if(GameManager.instance.gameStart)
        {
            if(goThere)
            {
                float randomTime = Random.Range(3, 10);
                Invoke("LaunchProjectile", randomTime);
                goThere = false;
            }
        }
    }

    void LaunchProjectile()
    {
        if(player != null)
        {
            leLaser = Instantiate(laser, transform.position + new Vector3(0, 0, 0), transform.rotation) as GameObject;
            leLaser.GetComponent<Rigidbody2D>().AddForce(transform.right * 300);

            float randomTime = Random.Range(3, 10);
            Invoke("LaunchProjectile", randomTime);
        }
    }
}
