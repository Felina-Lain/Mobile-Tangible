using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Player : MonoBehaviour {



	void Start(){

		SetupPlayers (NextTurn.turnNum);
			
	}



	public void SetupPlayers (int _i){

		this.gameObject.layer = 10;
		this.GetComponent<Renderer> ().material.SetColor ("_TintColor", Manager.colorListS[_i]);
		NextTurn.turnNum += 1;
	}

		
}
