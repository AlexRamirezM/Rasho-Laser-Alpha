using UnityEngine;
using System.Collections;

public class Back_Check : MonoBehaviour {

	public bool Block_Back;

	void OnTriggerEnter(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Back = true;
		}

	}

	void OnTriggerExit(Collider Col) {

		if (Col.gameObject.tag == "CuboIndestructible") {

			Block_Back = false;
		}
	}
}
