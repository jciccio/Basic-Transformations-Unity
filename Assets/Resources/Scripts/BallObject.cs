using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallObject : GameObjectClass
{
    private GameObject ball;
    public BallObject() {
        Ball = (GameObject)MonoBehaviour.Instantiate(Resources.Load("Prefabs/sphere"));
        Ball.AddComponent<Rigidbody>();
        Ball.transform.position = Vector3.one;
    }

    public GameObject Ball
    {
        get
        {
            return ball;
        }

        set
        {
            ball = value;
        }
    }
}
