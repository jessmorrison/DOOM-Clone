using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook2 : MonoBehaviour {

    public enum DropDownControls
    {
        MouseXandY = 0,
        MouseX = 1,
        MouseY = 2
    }

    public DropDownControls controls = DropDownControls.MouseXandY;
    public float sensitiveX = 9.0f;
    public float sensitiveY= 9.0f;

    public float minimumvert = -45.0f;
    public float maximumvert = 45.0f;

    public float _rotationX = 0;

	void Update () {
        if (controls == DropDownControls.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitiveX, 0);
        } else if (controls == DropDownControls.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitiveY;
            _rotationX = Mathf.Clamp(_rotationX, minimumvert, maximumvert);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        } 
        
	}
}
