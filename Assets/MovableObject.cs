using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IFuckedUp
{
    void WhatTheActualFuck();
}
[ExecuteInEditMode]
public class MovableObject : MonoBehaviour, IFuckedUp
{

	// Use this for initialization
	void Start () {
		
	}
    public void WhatTheActualFuck()
    {
        Debug.Log("Bullshit goes here.");
    }
    public virtual void Move()
    {
        transform.position += Vector3.forward * Time.deltaTime;
    }
	// Update is called once per frame
	void Update () {
        
	}
}
