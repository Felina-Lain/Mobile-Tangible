using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {



	void Start(){

		for (int i = 0; i < Manager.PlayersS.Count; i++) {
			if (Manager.turnsS == Manager.PlayersS[i]) {
				SetupPlayers ("Player 1", "Player1", i);
			}
		}
	}



	public void SetupPlayers (string _name, string _tag, int _i){

		this.gameObject.layer = _i + 10;
		this.gameObject.tag = _tag;
		//this.GetComponentInChildren<GameObject>().tag = _tag;
		this.GetComponent<Renderer> ().material.color = Manager.colorListS[_i];


	}
		
}
