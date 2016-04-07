using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Detector : MonoBehaviour {

	public List<Collider> _allies = new List<Collider>();

	void Update () {


	for(int i = 0; i < _allies.Count; i++) {

			if (_allies[i] == null) {
				_allies.RemoveAt (i);
			}

		}
	}

	void OnTriggerEnter(Collider col){

		for (int i = 0; i < Manager.PlayersS.Count; i++) {
			ListAdding (col, _allies);

		}
	
	}



	public void LineTracing (Color aColor, int aCount, int aIndex, Collider aCol){


		GetComponent<LineRenderer>().material.color = aColor;
		GetComponent<LineRenderer>().SetWidth(0.05f , 0.05f);
		GetComponent<LineRenderer>().SetPosition(0, this.transform.position);
		GetComponent<LineRenderer>().SetVertexCount(aCount);
		GetComponent<LineRenderer>().SetPosition(aIndex, aCol.transform.position);


	}

	public void ListAdding (Collider _col, List<Collider> _list)
	{
		if (!_list.Contains (this.GetComponent<Collider> ())) {

			_list.Add(this.GetComponent<Collider> ());
		
		}
	
		if (_col.name == this.transform.parent.name  || _col.name == "Special" ) {
			if (!_list.Contains (_col)) {


				_list.Add (_col);

				}

				for (int i = 0; i < _list.Count; i++) {
					
				Color _color = this.transform.parent.GetComponent<Renderer> ().material.GetColor("_TintColor");

				LineTracing (_color, _list.Count, i, _list [i].GetComponent<Collider> ());
							
				}


		}

		if (this.name == "Special" ) {
			if (!_list.Contains (_col)) {


				_list.Add (_col);

			}

			for (int i = 0; i < _list.Count; i++) {

				Color _color = this.transform.parent.GetComponent<Renderer> ().material.GetColor("_TintColor");

				LineTracing (_color, _list.Count, i, _list [i].GetComponent<Collider> ());

			}


		}


	}

}