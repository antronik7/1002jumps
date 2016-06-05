using UnityEngine;
using System.Collections;

public class ControllerController : MonoBehaviour {

    public GameObject SmallControler;
    public GameObject arrow;

    private Vector3 initialPos;
    private Vector3 mousePreviousPos;
	// Use this for initialization
	void Start () {
        initialPos = transform.position;
        mousePreviousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        SmallControler.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetMouseButtonUp(0))
        {
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
    }
}
