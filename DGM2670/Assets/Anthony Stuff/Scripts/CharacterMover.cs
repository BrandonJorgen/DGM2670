using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    private Vector3 position;
    private int jumpCount;
    public float moveSpeed = 10f, rotationSpeed = 1f;

    public void MoveCharacter(CharacterController controller)
    {
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        
        controller.Move(position * Time.deltaTime);
    }
}