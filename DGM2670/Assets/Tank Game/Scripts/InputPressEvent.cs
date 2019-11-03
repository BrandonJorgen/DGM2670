using UnityEngine;
using UnityEngine.Events;

public class InputPressEvent : MonoBehaviour
{
    public UnityEvent fire1Event, fire2Event, fire3Event, jumpEvent;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire1Pressed();
        }
        
        if (Input.GetButtonDown("Fire2"))
        {
            Fire2Pressed();
        }
        
        if (Input.GetButtonDown("Fire3"))
        {
            Fire3Pressed();
        }
        
        if (Input.GetButtonDown("Jump"))
        {
            JumpPressed();
        }
    }

    private void Fire1Pressed()
    {
        fire1Event?.Invoke();
    }

    private void Fire2Pressed()
    {
        fire2Event?.Invoke();
    }
    
    private void Fire3Pressed()
    {
        fire3Event?.Invoke();
    }
    
    private void JumpPressed()
    {
        jumpEvent?.Invoke();
    }
}
