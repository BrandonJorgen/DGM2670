using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class TargetSelect : MonoBehaviour
{
    public FloatData range ;
    public List<GameObject> enemiesInRange;
    public bool enemyInRange;
    private Transform target;
    private SphereCollider rangeCollider;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range.value);
    }

    private void Start()
    {
        rangeCollider = GetComponent<SphereCollider>();
        rangeCollider.isTrigger = true;
        rangeCollider.radius = range.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("enemy has entered Trigger");
        enemiesInRange.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        enemiesInRange.Remove(other.gameObject);
    }

    private void FixedUpdate()
    {
        UpdateTarget();
    }

    private void UpdateTarget()
    {
        if (enemiesInRange.Count > 0)
        {
            transform.LookAt(enemiesInRange[0].transform, Vector3.up);
            enemyInRange = true;
        }
        else
        {
            enemyInRange = false;
        }
    }
}
