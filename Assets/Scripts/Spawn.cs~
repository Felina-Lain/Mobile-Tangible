using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Spawn : MonoBehaviour {


	public static GameObject prefabS;

	public Camera mainCam;

	public GameObject _inst;

	void Start(){

		mainCam = GameObject.Find ("Main Camera").GetComponent<Camera>();

	}

	// Use this for initialization
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray r = Camera.main.ScreenPointToRay (Input.mousePosition);
			Collider c = GetComponentInChildren<Collider> ();
			RaycastHit hitInfo;
			if (!c.Raycast (r, out hitInfo, Mathf.Infinity)) {		

				if (!UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject ()) {
					Vector3 screenPos = Input.mousePosition;
					Vector3 worldPos = mainCam.GetComponent<Camera> ().ScreenToWorldPoint (screenPos);

					_inst = Instantiate (prefabS, new Vector3 (worldPos.x, worldPos.y, worldPos.z + 100), Quaternion.identity) as GameObject;
					_inst.transform.name = Manager.turnsS;

					if (prefabS == Manager.specialFabS) {

						_inst.transform.name = prefabS.name;

						for (int i = 0; i < Manager.PlayersS.Count; i++) {
							if (Manager.PlayersS [i] == Manager.turnsS) {

								Special.canSpecialS [i] = false;
								Special._On = false;
								Spawn.prefabS = Manager.playerFabS;

							}
						}
				
					}
				}
			}
		}
	}
}

