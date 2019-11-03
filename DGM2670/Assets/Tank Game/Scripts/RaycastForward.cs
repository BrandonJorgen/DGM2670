using UnityEngine;

public class RaycastForward : MonoBehaviour
{
    public Vector3Data location;
    
    private void FixedUpdate()
    {
        Debug.Log(Vector3.Dot(transform.TransformDirection(Vector3.forward), (location.data - transform.position)));
    }
}