﻿using UnityEngine;
using System.Collections;

public class ColorCases : MonoBehaviour {


	public Color campColor;

	// Use this for initialization
	void Start () {

	this.GetComponent<Renderer> ().material.color = campColor;
				
}
	
	// Update is called once per frame
	void Update () {

		}

}
