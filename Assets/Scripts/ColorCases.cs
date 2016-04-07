using UnityEngine;
using System.Collections;

public class ColorCases : MonoBehaviour {

	// Use this for initialization
	void Start () {

		for (int i = 0; i < Manager.PlayersS.Count; i++) {
			if (this.name == Manager.PlayersS[i]) {
				this.GetComponent<Renderer> ().material.color = Manager.colorListS [i];
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
