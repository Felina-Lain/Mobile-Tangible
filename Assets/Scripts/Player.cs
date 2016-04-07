using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {



	void Start(){

		for (int i = 0; i < Manager.PlayersS.Count; i++) {
			if (Manager.turnsS == Manager.PlayersS[i]) {
				SetupPlayers (i);
			}
		}
	}



	public void SetupPlayers (int _i){

		this.gameObject.layer = _i + 10;
		this.GetComponent<Renderer> ().material.SetColor ("_TintColor", Manager.colorListS[_i]);
		//color = Manager.colorListS[_i]; 


	}

		
}
