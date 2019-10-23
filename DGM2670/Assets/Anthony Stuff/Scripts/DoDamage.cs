using UnityEngine;

[CreateAssetMenu]
public class DoDamage : ScriptableObject, IRun
{
    public void Run()
    {
        Debug.Log("DoDamage");
    }
}