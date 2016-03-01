#pragma strict
//How quickly the object rotates
var sensitivityX:float = 5;
var sensitivityY:float = 5;
 
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
 
        //Get how far the mouse has moved by using the Input.GetAxis().
        //var rotationX:float = Input.GetAxis("Mouse X") /* sensitivityY*/;
       // Debug.Log(rotationX);
        var rotationVector = Vector3(0,0,0);
        rotationVector = Input.mousePosition;
        rotationVector.x = Input.mousePosition.x * 5;
        /*rotationVector.y *= 2.0f;*/
        //var radians:float = Mathf.Deg2Rad * rotationX;
        //make sure the object doesn't rotate beyond 90 degrees
 		//transform.eulerAngles = rotationVector;
        //Rotate the object around the camera's "up" axis
       // transform.Rotate(rotationVector, Space.Self/*referenceCamera.up         /*,  Mathf.Deg2Rad * rotationX*/ );
       
       transform.LookAt(rotationVector);
 
}