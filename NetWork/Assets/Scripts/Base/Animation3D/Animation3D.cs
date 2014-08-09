using UnityEngine;
using System.Collections.Generic;

public class Animation3D : MonoBehaviour {
	protected Animation mSkinAnimation;
	
	void Start(){
		mSkinAnimation = gameObject.GetComponent<Animation> ();
		mSkinAnimation.wrapMode = WrapMode.Loop;
		mSkinAnimation.Play ("idle_look");
		//mSkinAnimation.Play ("ALLANIMS");
	}	

}
