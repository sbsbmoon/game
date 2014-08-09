using UnityEngine;

public class Quad : MonoBehaviour {
	protected Vector3[] mVertices;
	protected Vector2[] mUvs;

	public float mHeight = 0;
	public float mWidth = 0;
	public float mScaleTex = 1;

	protected Texture2D mTex;


	private MeshFilter mMeshFt; 

	public void SetTexture2D( Texture2D tex ){
		mTex = tex;  
	}


	public void SetUv( Vector2 leftTop , Vector2 rightDown ){

		mUvs [0] = new Vector2 (leftTop.x, leftTop.y);
		mUvs [1] = new Vector2 (rightDown.x, leftTop.y);
		mUvs [2] = new Vector2 (leftTop.x, rightDown.y);
		mUvs [3] = new Vector2 (rightDown.x, rightDown.y);

	}

	protected virtual void Awake(){

		mVertices = new Vector3[4];
		mUvs = new Vector2[4];
		SetUv (new Vector2 (0, 0), new Vector2 (1, 1));
		mMeshFt = gameObject.GetComponent<MeshFilter> ();
	}

	protected virtual void Update(){
		//Time.time;
		//
		Draw ();
	}
	public virtual void Draw(){
		if (mMeshFt != null) {
			mMeshFt.mesh.Clear ();
			mVertices [2].y = mVertices [3].y = mHeight * mScaleTex * 0.5f;
			mVertices [1].y = mVertices [0].y = -mHeight * mScaleTex * 0.5f;
			mVertices [0].x = mVertices [2].x = -mHeight * mScaleTex * 0.5f;
			mVertices [3].x = mVertices [1].x = mWidth * mScaleTex * 0.5f;

			int[] indices = {0,1,2,1,3,2};

			Vector3[] normals = new Vector3[4]{Vector3.forward,Vector3.forward,Vector3.forward,Vector3.forward};
			Color32[] colors = new Color32[4]{Color.white,Color.white,Color.white,Color.white};

			mMeshFt.mesh.vertices = mVertices;
			mMeshFt.mesh.colors32 = colors;
			mMeshFt.mesh.triangles = indices;
			mMeshFt.mesh.normals = normals;
			mMeshFt.mesh.uv = mUvs;
		 }
		if (mTex) {
			renderer.material.mainTexture = mTex;		
		}
	}
}
