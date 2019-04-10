using UnityEngine;

public class GameManage : MonoBehaviour
{
    // Random spawn the enemies every two seconds
    private GameObject _plus;
    private GameObject _minus;
    [SerializeField]
    private float _timer = 0f;
    [SerializeField]
    private int _number = 0;
    [SerializeField]
    private int _number2 = 0;

    private void Awake()
    {
        _plus = Resources.Load<GameObject>("PlusScore");
        _minus = Resources.Load<GameObject>("MinusScore");
    }

    private void Start()
    {
        Instantiate(_plus, new Vector2(_number, 5), Quaternion.identity);
    }

    private void Update()
    {
        _number = Random.Range(-5, 5);
        _number2 = Random.Range(-5, 5);
        if (_number == _number2)
            _number = 0;
        _timer += 1 * Time.deltaTime;
        if (_timer > 2)
        {
            Instantiate(_plus, new Vector2(_number, 5), Quaternion.identity);
            Instantiate(_minus, new Vector2(_number2, 5), Quaternion.identity);
            _timer = 0;
        }
    }
}
