using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame in fixed time
	void FixedUpdate () 
	{	
		if (Input.GetKey(UnityEngine.KeyCode.E))
		{
			GameObject cube = (GameObject)Instantiate(Resources.Load("Prefabs/cube"));
			cube.AddComponent<Rigidbody>();
			cube.transform.position = Vector3.one;
		}
	}
}
