using UnityEngine;
using System.Collections;

public class DestruirObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(transform.position == new Vector3(18,2,-10) || transform.position == new Vector3(18,2,10) || transform.position == new Vector3(-10,2,-10) || transform.position == new Vector3(-10,2,10) ){
			Destroy (gameObject);
		}


	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Laser") {
			//Intervalotime debe ser 1 + el numero de minutos transcurridos.
			Destroy (gameObject);


		}

		}
}
