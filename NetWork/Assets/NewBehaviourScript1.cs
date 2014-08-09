using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	[SerializeField]
	UISprite sprite;
	// Use this for initialization
	void Start () {

	}

	void OnPress(bool isDown){
		if (isDown) {
			Debug.Log ("wo jiyou tangshao2");	
		}
		else{
			Debug.Log ("wo jiyou tangshao1");
		}
	}
	void OnClick(){
		gameObject.transform.localScale *=0.9f;
		Onc();
		Onc2 ();
	}
	void Onc(){
		Debug.Log ("wo jiyou tangshao");
	}
	void Onc2(){
		Debug.Log ("wo jiyou tangshao2");
	}

	void OnSS(){
		Debug.Log ("wo jiyou tang3333");
	}
}
