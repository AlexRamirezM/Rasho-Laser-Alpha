using UnityEngine;
using System.Collections;

public class Forward_Check : MonoBehaviour {

	 public bool Block_Forward;

	void OnTriggerEnter(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Forward = true;
		}

	}

	void OnTriggerExit(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Forward = false;
		}
	}
}
