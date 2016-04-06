﻿using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	public Camera mainCam;

	// Use this for initialization
	void OnMouseDown () {

		Vector3 screenPos = Input.mousePosition;
		Vector3 worldPos = mainCam.GetComponent<Camera>().ScreenToWorldPoint(screenPos);

		GameObject _inst = Instantiate(prefab, new Vector3(worldPos.x, worldPos.y, worldPos.z + 100), Quaternion.identity) as GameObject;
		_inst.transform.name = Manager.turnsS;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
