﻿using UnityEngine;
using UnityEngine.Events;

public class OnEnableEvent : MonoBehaviour
{
    public UnityEvent onEnableEvent;
    
    private void OnEnable()
    {
        onEnableEvent?.Invoke();
    }
}