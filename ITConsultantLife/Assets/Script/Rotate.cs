﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	public int RotateSpeed;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0,RotateSpeed,0, Space.World);
		
	}
}
