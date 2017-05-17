using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class GameObjectFactory {

    /*An extremely basic spawning function*/
    public GameObject SpawnObject (ObjectType objectType)
    {
        GameObject factoryObject = null;
        switch (objectType)
        {

            /*We simply just return a new object based on what is passed into the function. 
             Since these all extend GameObject, and we return a GameObject, 
             we can do this.*/

            case ObjectType.Ball:
                GameObjectClass ball = new BallObject();
                factoryObject = ((BallObject)ball).Ball;
                break;

            case ObjectType.Crate:
                GameObjectClass crate = new CrateObject();
                factoryObject = ((CrateObject)crate).Cube;
                break;
           
            
        }
        return factoryObject;
    }
}
