using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class move : MonoBehaviour {

	public float mSpeed = 1;//移動速度

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		var h = Input.GetAxis("Horizontal")*-1;//獲取水平軸向按鍵
		var v = Input.GetAxis("Vertical")*-1;//獲取垂直軸向按鍵
		
		transform.Translate(mSpeed * -h/10,0,mSpeed * -v/10);
	}
}
