using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMethod : MonoBehaviour
{
    // The script with the useful method to the button
    public void RestartTheLevel()
    {
        GlobalVariables._angle = 0;
        GlobalVariables._score = 0;
        SceneManager.LoadScene("2DPlatform");
    }
}
