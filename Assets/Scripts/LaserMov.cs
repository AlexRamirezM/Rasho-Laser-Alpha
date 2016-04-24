using UnityEngine;
using System.Collections;

public class LaserMov : MonoBehaviour {
	private float Vel_X;
	private float Vel_Z;

	public int Velocidad_Rasho = 20;
	public Vector3 Desplazamiento;
	private float Direccion;

	Quaternion Rotacion = new Quaternion ();

	// Use this for initialization
	void Start () {

		Direccion = transform.eulerAngles.y;

		if (Direccion == 0) {
		
			Vel_X = 0;
			Vel_Z = Velocidad_Rasho;
		
		} else if (Direccion == 90) {
		
			Vel_X = Velocidad_Rasho;
			Vel_Z = 0;

		} else if (Direccion > 170 && Direccion < 190) {

			Vel_X = 0;
			Vel_Z = -Velocidad_Rasho;
	
		} else if (Direccion == 270) {

			Vel_X = -Velocidad_Rasho;
			Vel_Z = 0;
		}
			

	}
	
	// Update is called once per frame


	void Update () {


		if (Vel_X == 0) {

			float px = Mathf.Round(transform.position.x / 2) * 2;
			transform.position = new Vector3(px, transform.position.y, transform.position.z);

		} else if (Vel_Z == 0) {

			float pz = Mathf.Round(transform.position.z / 2) * 2;
			transform.position =new Vector3(transform.position.x, transform.position.y,pz);
		}


		Desplazamiento = new Vector3 (Vel_X, 0, Vel_Z);

		transform.position += Desplazamiento * Time.deltaTime;

		Rotacion = Quaternion.LookRotation(Desplazamiento);

		transform.rotation = Rotacion;


	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Limiver")
		{
			Vel_Z = Vel_Z * (-1);

		}
		if (collision.gameObject.tag == "Limihori")
		{
			
			Vel_X = Vel_X * (-1);
		}
		if (collision.gameObject.tag == "CuboDestructible" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "CuboIndestructible")
		{
			Destroy (gameObject);
		}

		if (collision.gameObject.tag == "Espejo_45")
		{
			if (Vel_X == 0) {
				Vel_X = -Vel_Z;
				Vel_Z = 0;
			}else {
				Vel_Z = -Vel_X;
				Vel_X = 0;
			}
		}
		if (collision.gameObject.tag == "Espejo_315")
		{
			if (Vel_X == 0) {
				Vel_X = Vel_Z;
				Vel_Z = 0;
			}else {
				Vel_Z = Vel_X;
				Vel_X = 0;
			}
		}
	}

}
