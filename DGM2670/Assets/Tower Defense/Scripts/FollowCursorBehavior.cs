using UnityEngine;

[CreateAssetMenu]
public class FollowCursorBehavior : ScriptableObject
{
    private Vector3 position;

    public void MoveWithCursor(CharacterController controller)
    {
        controller.transform.position = Input.mousePosition;
    }
}