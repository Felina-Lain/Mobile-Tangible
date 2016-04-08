using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CampCounts : MonoBehaviour {

	public static List<Collider> _inCamps = new List<Collider>();

	void OnTriggerEnter(Collider col){

		_inCamps.Add(col);


	}

}
