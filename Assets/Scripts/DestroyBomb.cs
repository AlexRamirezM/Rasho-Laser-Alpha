using UnityEngine;
using System.Collections;

public class DestroyBomb : MonoBehaviour {
	private float tiempo;
	public GameObject Laser1, Laser2, Laser3, Laser4;
	public int Angulo;
	public int Velocidad_Rasho = 20;
	public Vector3 Direccion;
	public int i = 0;

	// Use this for initialization
	void Start () {

		tiempo = 3;
	}
	
	// Update is called once per frame
	void Update () {

		if (tiempo < 0) {

			while(i < 4) {
				
//				Network.Instantiate (Laser1, transform.position, Quaternion.identity,0);
				switch (i) {
				case 0:
					Instantiate (Laser1, transform.position, Quaternion.Euler (0, 0, 0));
					break;
				case 1:
					Instantiate (Laser1, transform.position, Quaternion.Euler(0, 90, 0));
					break;
				case 2:
					Instantiate (Laser1, transform.position, Quaternion.Euler (0, 180, 0));
					break;
				case 3:
					Instantiate (Laser1, transform.position, Quaternion.Euler (0, 270, 0));
					break;
				}

				i = i + 1;

			}

			Destroy (gameObject	);

					}

		tiempo -= Time.deltaTime;
	}
	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "CuboDestructible" || collision.gameObject.tag == "CuboIndestructible" || collision.gameObject.tag == "Limiver" || collision.gameObject.tag == "Limihori") {
			
			Destroy (gameObject);

		}

	}
}
