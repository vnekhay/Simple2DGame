using UnityEngine;

public class TriggerMinus : MonoBehaviour
{
    // Bad coin trigger to the main character
    [SerializeField]
    private float _timer = 0f;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        MainCharacter main = collider.GetComponent<MainCharacter>();

        if (main)
        {
            GlobalVariables._score -= 10;
            Destroy(gameObject);
        }
    }

    // The object dies anyway
    private void Update()
    {
        _timer += 1 * Time.deltaTime;
        if (_timer > 8)
            Destroy(gameObject);
    }
}
