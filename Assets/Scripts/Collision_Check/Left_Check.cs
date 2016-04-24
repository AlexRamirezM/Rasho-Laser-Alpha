using UnityEngine;
using System.Collections;

public class Left_Check : MonoBehaviour {

	public bool Block_Left;

	void OnTriggerEnter(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Left = true;
		}

	}

	void OnTriggerExit(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Left = false;
		}
	}
}
