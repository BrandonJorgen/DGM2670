using UnityEngine;
using UnityEngine.Events;

public class TriggerBehavior : MonoBehaviour
{
    //private Collider trigger;
    public UnityEvent triggerEnter;
    
   /* private void Start()
    {
        trigger = GetComponent<Collider>();
        trigger.isTrigger = true;
    }
*/
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("yup");
        triggerEnter.Invoke();
    }
}
