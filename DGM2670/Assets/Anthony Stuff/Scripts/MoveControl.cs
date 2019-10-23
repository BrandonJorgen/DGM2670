using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MoveControl : MonoBehaviour
{
    public ScriptableObject mover;
    private CharacterController controller;
    private IMove iMover;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        iMover = mover as IMove;
    }

    void Update()
    {
        iMover.Move(controller);
    }

    public void ChangeMover(ScriptableObject newMover)
    {
        iMover = newMover as IMove;
    }
}