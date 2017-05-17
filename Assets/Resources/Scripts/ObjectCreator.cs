using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour {

    GameObjectFactory factory;

	// Use this for initialization
	void Start () {
        factory = new GameObjectFactory();
	}

    // Called in fixed time
    void FixedUpdate()
    {
        if (Input.GetKey(UnityEngine.KeyCode.E))
        {
            factory.SpawnObject(GameObjectFactory.ObjectType.Crate);
        }
        else if (Input.GetKey(UnityEngine.KeyCode.W))
        {
            factory.SpawnObject(GameObjectFactory.ObjectType.Ball);
        }
    }
}
