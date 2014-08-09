using UnityEngine;
using System.Collections;

public class DrawNode : MonoBehaviour {

	public Quad quad;

	public float Scale{
		set{
			quad.mScaleTex = value;
		}
		get{
			return quad.mScaleTex;
		}
	}
	public void SetQuad(Texture2D tex){
		if (quad != null) {
			DestroyObject(quad);
		}
		quad = gameObject.AddComponent<Quad> ();
		quad.mWidth = tex.width;
		quad.mHeight = tex.height;
		quad.SetTexture2D(tex);
		quad.SetUv (new Vector2 (0, 0), new Vector2 (1, 1));
	}
	public void SetAnimation( Texture2D[] texArray , float deltaTime){
		if (quad != null) {
			DestroyObject(quad);
		}
		Animation2D ani = gameObject.AddComponent<Animation2D> ();
		ani.mCount = texArray.Length;
		ani.mDeltaTime = deltaTime;
		ani.SetTextureList (texArray);
		quad = ani;
		ani.SetUv(new Vector2(0,0),new Vector2(1,1));
	} 
	public void SetAnimation(Texture2D tex , Vector2 size , int count , float deltaTime){
		if (quad != null) {
			DestroyObject(quad);
		}
		Animation2DEx ani = gameObject.AddComponent<Animation2DEx> ();
		ani.mCount = count;
		ani.mFrameSize = size;
		ani.mDeltaTime = deltaTime;
		ani.SetTexture2D(tex);
		quad = ani;
	}
	
}
