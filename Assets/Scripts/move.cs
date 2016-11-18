using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public float stepCount = 0;
    public GameObject spooder;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
            spooder.GetComponent<Rigidbody>().velocity = new Vector3(Mathf.Sin(stepCount), 0, Mathf.Cos(stepCount));
       

        stepCount+= (float) .01;
    }
}
