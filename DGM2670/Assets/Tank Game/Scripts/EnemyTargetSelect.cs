using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class EnemyTargetSelect : MonoBehaviour
{
    private SphereCollider sightRange;
    private Vector3 lookDir;
    public GameObject target;
    public float rotationSpeed = 1f;
    
    private void Start()
    {
        sightRange = GetComponent<SphereCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        target = other.gameObject;
        //need to look at player
        //need to move close enough to shoot at player
    }

    private void OnTriggerExit(Collider other)
    {
        target = null;
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.rotation, target.transform.rotation);
    }
}