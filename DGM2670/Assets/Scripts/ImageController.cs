using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageController : MonoBehaviour
{
    private Image imageComponent;
    public FloatData floatDataObj;
    
    private void Start()
    {
        imageComponent = GetComponent<Image>();
    }

    public void UpdateImageComponent()
    {
        imageComponent.fillAmount = floatDataObj.value;
    }

    private void Update()
    {
        UpdateImageComponent();
    }
}