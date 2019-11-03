using UnityEngine;

[CreateAssetMenu]
public class TranslateBehavior : ScriptableObject
{
    public float speed = 1f;
    
    public void TranslateObj(CharacterController controller)
    {
        controller.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
