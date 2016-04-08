using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class CampClass {

	public string campName;
	public List<Collider> campList = new List<Collider>();

	public CampClass(string _Listname, List<Collider> tmplist){

		campName = _Listname;
		campList = tmplist;

	}

}