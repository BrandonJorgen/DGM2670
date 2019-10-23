using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineController : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    
    void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void TransformHandler(Transform transformObj)
    {
        virtualCamera.Follow = transformObj;
    }
}
