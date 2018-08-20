using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class molmotto : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 po = transform.localEulerAngles;
        po.z = 90;
        this.transform.localEulerAngles = po;
	}
}
