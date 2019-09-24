using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    public AudioMixer mixer;
    
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game has been quit");
    }
    
    public void QualityChange(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        Debug.Log(qualityIndex);
    }
    
    public void SetVolume(float volume)
    {
        mixer.SetFloat("volume", volume);
    }
}
