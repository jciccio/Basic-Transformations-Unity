using UnityEngine;
using System.Collections;

public class ObjectTransformation : MonoBehaviour {
	
	#region attributes
    [SerializePrivateVariables]
	private GameObject _objectToControl;
	public float rotationSpeed  = 50.5f;
	public float scaleFactor	= 0.1f;
	public float movementSpeed	= 0.1f;
	#endregion
	
	#region methods
	// Use this for initialization
	// This one is called once

	void Start () {
		_objectToControl = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(UnityEngine.KeyCode.R))
		{
			// Delta time is the time (in seconds) that took to complete the last frame
			// This var is used to smooth animation between devices
			_objectToControl.transform.Rotate(new Vector3(1f,0f,0f) * Time.deltaTime * rotationSpeed);
		}
		if (Input.GetKey(UnityEngine.KeyCode.E) || (Input.GetKey(UnityEngine.KeyCode.Q)))
		{
			scaleFactor = (Input.GetKey(UnityEngine.KeyCode.E)) ? Mathf.Abs(scaleFactor) : (- Mathf.Abs(scaleFactor));
			Vector3 currentScale = _objectToControl.transform.localScale;
			float xValue = Mathf.Clamp(currentScale.x+scaleFactor, 0.25f, 5f);
			float yValue = Mathf.Clamp(currentScale.y+scaleFactor, 0.25f, 5f);
			float zValue = Mathf.Clamp(currentScale.z+scaleFactor, 0.25f, 5f);
			_objectToControl.transform.localScale = (new Vector3(xValue,yValue,zValue));
			
		}
		if(Input.GetKey(UnityEngine.KeyCode.W) || Input.GetKey(UnityEngine.KeyCode.S))
		{
			// Movement in Y Axis
			float direction = (Input.GetKey(UnityEngine.KeyCode.W)) ? 1 : -1;
			Vector3 currentPosition = _objectToControl.transform.position;
			_objectToControl.transform.position = new Vector3(currentPosition.x,
															  currentPosition.y + movementSpeed * direction,
															  currentPosition.z);
		}
		if(Input.GetKey(UnityEngine.KeyCode.D) || Input.GetKey(UnityEngine.KeyCode.A))
		{
			// Movement in X Axis
			float direction = (Input.GetKey(UnityEngine.KeyCode.D)) ? 1 : -1;
			Vector3 currentPosition = _objectToControl.transform.position;
			_objectToControl.transform.position = new Vector3(currentPosition.x + movementSpeed * direction,
															  currentPosition.y,
															  currentPosition.z);
		}



        // Joystick Functionality
        Vector3 currentPositionJoystick = _objectToControl.transform.position;
        _objectToControl.transform.position = new Vector3(currentPositionJoystick.x + movementSpeed * Input.GetAxis("Horizontal"),
                                                            currentPositionJoystick.y,
                                                            currentPositionJoystick.z);

        currentPositionJoystick = _objectToControl.transform.position;
        _objectToControl.transform.position = new Vector3(currentPositionJoystick.x,
                                                            currentPositionJoystick.y + movementSpeed * Input.GetAxis("Vertical"),
                                                            currentPositionJoystick.z);

    }
	#endregion
}
