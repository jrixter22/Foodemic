/*#pragma strict
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
        var rotationX:float = Input.GetAxis("Mouse X") * sensitivityY;
        //var radians:float = Mathf.Deg2Rad * rotationX;
        //make sure the object doesn't rotate beyond 90 degrees
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        if(rotationX >= 90)
        {
        	Debug.Log("yeah");
        }
 
        //Rotate the object around the camera's "up" axis
        transform.RotateAroundLocal( referenceCamera.up         ,  Mathf.Deg2Rad * rotationX );
 
}
/*var goTarget : GameObject;
var maxDegreesPerSecond : float = 30.0;
private var qTo : Quaternion;
 
function Start () {
	qTo = goTarget.transform.localRotation;
}
 
function Update () {
    var v3T = goTarget.transform.position - transform.position;
    v3T.y = transform.position.y;
    qTo = Quaternion.LookRotation(v3T, Vector3.up);        
    transform.rotation = Quaternion.RotateTowards(transform.rotation, qTo, maxDegreesPerSecond * Time.deltaTime);
}*/