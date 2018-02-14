using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MovableObjectCoordinator : MonoBehaviour{
    [SerializeField]
    List<MovableObject> objects;
    [SerializeField]
    public IFuckedUp thisClass;
	// Use this for initialization
	void Start () {
    }
	
   
	// Update is called once per frame
	void Update () {
	    foreach(MovableObject mo in objects)
        {
            mo.Move();
            if(mo is IFuckedUp)
            {
                mo.WhatTheActualFuck();
            }
        }

        
	}
}
