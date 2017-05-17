using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateObject : GameObjectClass
{
    private GameObject cube;

    public CrateObject() {
        Cube = (GameObject)MonoBehaviour.Instantiate(Resources.Load("Prefabs/cube"));
        Cube.AddComponent<Rigidbody>();
        Cube.transform.position = Vector3.one;
    }

    public GameObject Cube
    {
        get
        {
            return cube;
        }

        set
        {
            cube = value;
        }
    }
}
