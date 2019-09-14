using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    public UnityEvent sceneChange;
    
    [Header("Pause Game Settings")]
    public UnityEvent EscapePressedEvent;

    private void OnEnable() 
    { 
        SceneManager.sceneLoaded += SceneChangeManagement; 
    } 
     
    private void OnDisable() 
    { 
        SceneManager.sceneLoaded -= SceneChangeManagement; 
    } 
     
    private void SceneChangeManagement(Scene scene, LoadSceneMode current) 
    { 
        sceneChange.Invoke();
    } 
    
    void Update()
    {
        //PAUSE GAME BEHAVIOR
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EscapePressedEvent?.Invoke();
        }
    }
}