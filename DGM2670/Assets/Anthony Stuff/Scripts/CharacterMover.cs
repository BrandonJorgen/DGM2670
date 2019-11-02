using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    private Vector3 position, orientation;
    private int jumpCount;
    public float moveSpeed = 10f, rotationSpeed = 1f;

    public void MoveCharacter(CharacterController controller)
    {
        position.Set(0, 0, Input.GetAxis("Vertical") * moveSpeed);
        orientation.y = rotationSpeed * Input.GetAxis("Horizontal");
        
        controller.transform.Rotate(orientation);
        position = controller.transform.TransformDirection(position);
        controller.Move(position * Time.deltaTime);
    }
}