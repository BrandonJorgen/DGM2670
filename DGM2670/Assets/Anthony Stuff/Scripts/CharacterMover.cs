using UnityEngine;

[CreateAssetMenu]
public class CharacterMover : ScriptableObject
{
    private CharacterController controller;
    private Vector3 position;
    private int jumpCount;
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    public int jumpCountMax = 2;

    public void Move(CharacterController controller)
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        
        controller.Move(position * Time.deltaTime);
        
    }
}
