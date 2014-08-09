using UnityEngine;
using System.Collections.Generic;

public class Animation2D : Quad {
	public float mDeltaTime = 0;
	public int mCount = 1;
	public int mCurFrame = -1;
	public Vector2 mFrameSize = Vector2.zero;

	private float time = 0;
	private List<Texture2D> mTexList;

	protected virtual void Awake(){
		base.Awake ();
		mTexList = new List<Texture2D> ();
	}
	protected virtual void Update(){
		if (time <= 0 && mTexList != null && mTexList.Count > 1) {
			time += mDeltaTime;
			NextFrame ();
			mWidth = mTex.width * mScaleTex;
			mHeight = mTex.height * mScaleTex;
		}
		time -= Time.deltaTime;
		base.Update ();
	}
	public void SetTextureList( Texture2D[] texs ){
		mTexList.AddRange (texs);	
	}
	public void NextFrame(){
		if (mCurFrame < mCount - 1 && mTex) {
			++mCurFrame;		
		}
		else{
			mCurFrame = 0;
		}
		NextTex();
	}

	void NextTex(){
		mTex = mTexList[mCurFrame];
	}
}
