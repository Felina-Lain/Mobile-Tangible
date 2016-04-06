using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Detector : MonoBehaviour {

	public List<Collider> allies1 = new List<Collider>();
	public List<Collider> allies2 = new List<Collider>();



	void OnTriggerStay(Collider col){

		ListAdding (col, "Player1", allies1, Manager.colorListS[0]);
		ListAdding (col, "Player2", allies2, Manager.colorListS[1]);

			                                         
	}


	void Update () {

		for (int i = 0; i < allies1.Count; i++) {

			if (allies1 [i] == null) {
				allies1.RemoveAt (i);
			}


		}

		for (int j = 0; j < allies2.Count; j++) {

			if (allies2 [j] == null) {
				allies2.RemoveAt (j);
			}

		}

	}

	public void LineTracing (Color aColor, int aCount, int aIndex, Collider aCol){


		GetComponent<LineRenderer>().material.color = aColor;
		GetComponent<LineRenderer>().SetWidth(0.1f , 0.1f);
		GetComponent<LineRenderer>().SetPosition(0, this.transform.position);
		GetComponent<LineRenderer>().SetVertexCount(aCount);
		GetComponent<LineRenderer>().SetPosition(aIndex, aCol.transform.position);


	}

	public void ListAdding (Collider _col, string _tag, List<Collider> _list, Color _color)
	{
		if (!_list.Contains (this.GetComponent<Collider> ())) {

			_list.Add(this.GetComponent<Collider> ());
		
		}
	
		if (_col.tag == this.tag && this.tag == _tag) {
			if (!_list.Contains (_col)) {


				_list.Add (_col);

				}

				for (int i = 0; i < _list.Count; i++) {

				LineTracing (_color, _list.Count, i, _list [i].GetComponent<Collider> ());
							
				}


			} else {}
	

	}
}