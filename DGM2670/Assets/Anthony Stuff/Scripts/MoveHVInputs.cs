using UnityEngine;

[CreateAssetMenu]
public class MoveHVInputs : ScriptableObject, IMove
{
    public Vector3 location { get; set; }
    public Vector3 newLoc;

    public void Move(CharacterController controller)
    {
        newLoc.x = Input.GetAxis("Horizontal");
        controller.Move(newLoc);
    }
}