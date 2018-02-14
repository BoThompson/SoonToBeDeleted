using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavyMovableObject : MovableObject {

	// Use this for initialization
	void Start () {
		
	}
	public override void Move()
    {
        transform.position += Mathf.Sin(Time.time) * Vector3.right;

    }
	// Update is called once per frame
	void Update () {
	}
}
