using UnityEngine;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	List<Texture2D> texList;
	void Start () {
		texList = new List<Texture2D> ();
		for (int i = 1; i < 9; ++i) {
			texList.Add(Resources.Load("Effect/run0"+i) as Texture2D);	
		}
		gameObject.GetComponent<DrawNode> ().SetAnimation (texList.ToArray (), 0.0001f);
	}
	

}
