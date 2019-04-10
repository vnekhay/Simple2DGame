using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Score
    public Text txt;

    private void Update()
    {
        txt.text = "Score :" + GlobalVariables._score;
    }
}
