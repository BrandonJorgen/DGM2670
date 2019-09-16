using UnityEngine;

public class TransformController : MonoBehaviour
{
    public FloatData speed;
    private void Update()
    {
        transform.Translate(new Vector3(speed.value * Time.deltaTime, 0, 0));
    }
}