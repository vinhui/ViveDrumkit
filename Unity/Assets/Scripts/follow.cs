using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
	// Update is called once per frame
	void FixedUpdate () {
        GetComponent<Rigidbody>().MovePosition(transform.parent.position);
        GetComponent<Rigidbody>().MoveRotation(transform.parent.rotation);
    }
}
