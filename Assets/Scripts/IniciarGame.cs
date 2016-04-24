using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class IniciarGame : MonoBehaviour {
	

	public void iniciar(){
		SceneManager.LoadScene ("Game");
	}
}
