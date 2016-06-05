using UnityEngine;
using System.Collections;

public class ControllerController : MonoBehaviour {

    public GameObject SmallControler;

    private GameObject player;
    private GameObject rotator;
    private GameObject arrow;
    private Vector3 initialPos;
    private Vector3 mousePreviousPos;
    private Vector3 difference;

    // Use this for initialization
    void Start () {
        initialPos = transform.position;
        mousePreviousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        SmallControler.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        player = GameObject.Find("player");
        rotator = GameObject.Find("player/rotator");
        arrow = GameObject.Find("player/rotator/arrow");
        arrow.GetComponent<SpriteRenderer>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonUp(0))
        {
            player.GetComponent<Rigidbody2D>().AddForce(-difference.normalized * arrow.transform.localScale.y * 100);
            arrow.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject);
        }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Vector3 objectPos = mousePos;

        Vector3 objectPos = SmallControler.transform.position + (mousePos - mousePreviousPos);

        objectPos.z = 0f;


        Vector3 allowedPos = objectPos - initialPos;

        allowedPos = Vector3.ClampMagnitude(allowedPos, 0.5f);


        SmallControler.transform.position = initialPos + allowedPos;

        mousePreviousPos = mousePos;

        difference = SmallControler.transform.position - transform.position;

        float rotZ = (Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg) -270;

        rotator.transform.rotation = Quaternion.AngleAxis(rotZ, Vector3.forward);

        arrow.transform.localScale = new Vector3(arrow.transform.localScale.x, 1 + difference.magnitude, arrow.transform.localScale.z);
    }
}
