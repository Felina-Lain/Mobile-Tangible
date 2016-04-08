using UnityEngine;
using System.Collections;

public class DeletePawn : MonoBehaviour {

	// Use this for initialization
	void OnMouseOver () {

		if (Input.GetMouseButtonDown (1)) {
			
			Destroy (this.gameObject);

		}

		if (Input.GetMouseButtonDown (2)) {
		
			NextTurn.turnNum -= 1;
			Destroy (this.gameObject);
		
		}
	}
}
