using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


//http://answers.unity3d.com/questions/387790/generic-list-how-to-add-item-at-specific-point-c.html
//http://answers.unity3d.com/questions/502335/how-to-check-if-object-already-exists-in-a-list.html


public class Detector : MonoBehaviour {
	
	public List<Collider> allies1 = new List<Collider>();
	public List<Collider> allies2 = new List<Collider>();
	

	void OnTriggerStay(Collider col){
		
		if(col.tag == this.tag){
			if(this.tag == "Player1"){
			if(!Manager.allies1S.Contains(col)){
				
				Manager.allies1S.Add(col);
				
				}

				GetComponent<LineRenderer>().enabled = true;
				GetComponent<LineRenderer>().material.color = Manager.Player1S;
				GetComponent<LineRenderer>().SetWidth(0.1f , 0.1f);
				GetComponent<LineRenderer>().SetPosition(0, transform.position);
				GetComponent<LineRenderer>().SetPosition(1, col.transform.position);

			
			}else{}
			if(this.tag == "Player2"){
			if(!Manager.allies2S.Contains(col)){
				
				Manager.allies2S.Add(col);
				
				}

				GetComponent<LineRenderer>().enabled = true;
				GetComponent<LineRenderer>().material.color = Manager.Player2S;
				GetComponent<LineRenderer>().SetWidth(0.1f , 0.1f);
				GetComponent<LineRenderer>().SetPosition(0, transform.position);
				GetComponent<LineRenderer>().SetPosition(1, col.transform.position);
			
			}else{}
		}
		
	}
	
	void OnTriggerExit(Collider col){
		
		if(Manager.allies1S.Contains(col)){
		
		Manager.allies1S.Remove(col);
			GetComponent<LineRenderer>().enabled = false;
				
		}
		
		if(Manager.allies2S.Contains(col)){
		
		Manager.allies2S.Remove(col);
				
		}
	}
	
	
	void Update () {
		
		for (int i = 0; i < Manager.allies1S.Count; i++) {
			
		 if (Manager.allies1S[i] == null){
		 Manager.allies1S.RemoveAt(i);
		 }

		}
		
		for (int j = 0; j < Manager.allies2S.Count; j++) {
			
		 if (Manager.allies1S[j] == null){
		 Manager.allies1S.RemoveAt(j);
		 }

		}
		
		allies1 = Manager.allies1S;
		allies2 = Manager.allies2S;
	
	}
}
