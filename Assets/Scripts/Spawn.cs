using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject prefab;
	public Camera mainCam;

	// Use this for initialization
	void OnMouseDown () {

		Vector3 screenPos = Input.mousePosition;
		Vector3 worldPos = mainCam.GetComponent<Camera>().ScreenToWorldPoint(screenPos);

		Instantiate(prefab, new Vector3(worldPos.x, worldPos.y, worldPos.z + 100), Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
