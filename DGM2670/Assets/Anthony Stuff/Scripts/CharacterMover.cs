using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    private CharacterController controller;
    private Vector3 position;
    private int jumpCount;
    public float moveSpeed = 10f;

    public void Move(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        
        controller.Move(position * Time.deltaTime);
        
    }
}
