using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Timer
    public Text txt;
    [SerializeField]
    private float _timer = 0;

    void Update()
    {
        _timer += 1 * Time.deltaTime;
        txt.text = "Time :" + _timer; 
    }
}
