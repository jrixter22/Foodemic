/*#pragma strict
//How quickly the object rotates
var sensitivityX:float = 15;
var sensitivityY:float = 15;
 
//Camera is a point of view to rotate the object relative to
var referenceCamera:Transform;
 
//Doublecheck our variables have valid values
function Start() {
 
        //Ensure the referenceCamera variable has a valid value
        //If the user didn't set a camera manually, try to automatically assign the scene's Main Camera.
        if (!referenceCamera) {
                if (!Camera.main) {
                        Debug.LogError("No Camera with 'Main Camera' as its tag was found. Please either assign a Camera to this script, or change a Camera's tag to 'Main Camera'.");
                        Destroy(this);
                        return;
                }
                referenceCamera = Camera.main.transform;
        }
}
 
//Rotate the object constantly if the user is always moving the mouse
function Update () {
 
        //Get how far the mouse has moved by using the Input.GetAxis()
        var rotationY:float = Input.GetAxis("Mouse Y") * sensitivityX;
 
        //Rotate the object around the camera's "up" axis, and the camera's "right" axis
        transform.RotateAroundLocal( referenceCamera.right      ,  -Mathf.Deg2Rad * rotationY );
 
}*/