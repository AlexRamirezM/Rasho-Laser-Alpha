using UnityEngine;
using System.Collections;

public class SpawnerT1 : MonoBehaviour {
	public GameObject Minotaur;
	public GameObject MinoConstructor;
	public int cantJu=0;
	public string npl;

	void Start(){
		
			spwan ();

	}





	public void spwan(){
		npl = Network.player.ToString ();
		if(int.Parse(Network.player.ToString())==0){	
			Network.Instantiate (Minotaur, new Vector3 (-10, 0, -10), Quaternion.identity, 0);
		}
		if(int.Parse(Network.player.ToString())==1){
			Network.Instantiate (MinoConstructor, new Vector3 (17, 0, -10), Quaternion.identity, 0);
		}	
//		if(Network.player==3){
//			Network.Instantiate (Minotaur2, new Vector3 (-10, 0, 10), Quaternion.identity, 0);
//		}
//		if(Network.player==4){
//			Network.Instantiate (MinoConstructor2, new Vector3 (17, 0, 10), Quaternion.identity, 0);
//		}


	}


}