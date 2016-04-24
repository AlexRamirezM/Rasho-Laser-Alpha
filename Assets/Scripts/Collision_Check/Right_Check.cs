using UnityEngine;
using System.Collections;

public class Right_Check : MonoBehaviour {

	public bool Block_Right;

	void OnTriggerEnter(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Right = true;
		}

	}

	void OnTriggerExit(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Right = false;
		}
	}
}
