using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Server : MonoBehaviour {
	


	private int iniciopartida=0;
	public bool useNat = false;
	private int numconectados=0;
	private int numUsarios = 1;
	public Text textnumconectados;


	public InputField Puerto;
	public InputField IP;
	public InputField NombreUsuario;


	public Toggle Chattoggle;
	public Text Datosdeusuario;
	//Guis
	public GameObject Minotaur;
	public GameObject MinoConstructor;


	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		CrearServidor ();



	}
	void Update(){
		//Iniciar el juego en el momento que hayan x cantidad de personas conectadas
		if (numconectados==numUsarios && iniciopartida==0) {
			iniciopartida = 1;
			SceneManager.LoadScene ("Game");
		}
		numconectados=Network.connections.Length+1;
		//Mostrar al jugador la cantidad de jugadores estan conectadas
		textnumconectados.text = numconectados.ToString();

	}
	public void CrearServidor(){
		if(Network.peerType == NetworkPeerType.Disconnected){
			
				Network.InitializeServer(numUsarios, 9000, useNat);
				foreach(GameObject go in FindObjectsOfType(typeof(GameObject)) as GameObject[]){
					go.SendMessage("OnNetworkLoadedLevel", SendMessageOptions.DontRequireReceiver);
				}

		}
		 

	}
	private void OnServerInitialized(){
		
		print ("Servidor iniciado correctamente");
//		GuiOffline.SetActive (false);
//		if (NombreUsuario.text != "")
//			Variables.Username = NombreUsuario.text;
//		else
//			Variables.Username = "Servidor";
//
//		GuiChat.SetActive (true);
//		BotonIngameGuiMenu.SetActive (true);
	}


	private void OnConnectedToServer(){
		foreach(GameObject go in FindObjectsOfType(typeof(GameObject)) as GameObject[]){
			go.SendMessage("OnNetworkLoadedLevel", SendMessageOptions.DontRequireReceiver);

			Network.Instantiate (Minotaur, new Vector3 (-10, 0, -10), Quaternion.identity, 0);
		}



		print ("Coneccion Correcta");

//		GuiOffline.SetActive (false);
//		if (NombreUsuario.text != "")
//			Variables.Username = NombreUsuario.text;
//		else
//			Variables.Username = "Usuario: " + Network.time;
//		GuiChat.SetActive (true);
//		BotonIngameGuiMenu.SetActive (true);
		}

	public void Conecctarse(){
		if (Network.peerType == NetworkPeerType.Disconnected)
			Network.Connect (IP.text, 9000);
	}

//	void Update(){
//		GuiChat.SetActive (Chattoggle.isOn);
//		IngameGuiMenu.SetActive (BotonIngameGuiMenu.GetComponent<Toggle>().isOn);
//		Datosdeusuario.text = "<color=red><b>Datos de usuario</b></color> \nIP: " + Network.player.ipAddress + ":" + Network.player.port + "\nIP Global: " + Network.player.externalIP + ":" + Network.player.externalPort+"\nNombre de usuario: "+ Variables.Username;
//	}
	public void Desconectar(){
		if(Network.peerType != NetworkPeerType.Disconnected)
			Network.Disconnect (500);
	}

//	void OnDisconnectedFromServer(NetworkDisconnection info) {
//		GuiOffline.SetActive (true);
//		Variables.Username = "";
//		GuiChat.SetActive (false);
//		BotonIngameGuiMenu.SetActive (false);
//		Chattoggle.isOn = false;
//		BotonIngameGuiMenu.GetComponent<Toggle> ().isOn = false;
//		IngameGuiMenu.SetActive (false);
//
//		foreach(GameObject go in GameObject.FindGameObjectsWithTag("Player")){
//			Destroy(go);
//		}
//
//	}


}
