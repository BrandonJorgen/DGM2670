using UnityEngine;

[CreateAssetMenu]
public class LookAtBehavior : ScriptableObject
{
    private Ray ray;
    private RaycastHit hit;
    private float rayDistance;
    private Vector3 point;
    private Vector3 correctPoint;

    public void LookAtCursor(CharacterController controller)
    {
        //Set up the raycast and create something for the ray to hit
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.forward, 0); //Apparently this is better/quicker to do than
                                                //setting up the plane the player is already on?
        
        //if the ray hits something, report the distance from the camera to the collision
        if (groundPlane.Raycast(ray, out rayDistance))
        {
            point = ray.GetPoint(rayDistance);
            Debug.DrawLine(ray.origin, point, Color.red);
            correctPoint = new Vector3(point.x, point.y, controller.transform.position.z); //adjust transform for Y height
            controller.transform.LookAt(correctPoint); //look in the direction of the ray collision
        }
    }
}