using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject, IRun, ITest
{
    public void Run()
    {
        Debug.Log("PowerUp");
    }

    public void Test()
    {
        Debug.Log("PowerUp Test");
    }
}
