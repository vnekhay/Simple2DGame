using UnityEngine;

public class RightGround : MonoBehaviour
{
    // To control the right side of the platform
    public Transform obj;
    private bool _MouseDown = false;

    private void Update()
    {
        if (_MouseDown)
        {
            if (GlobalVariables._angle <= 6)
                GlobalVariables._angle += 0.3f;
            obj.transform.rotation = Quaternion.Euler(0, 0, GlobalVariables._angle);
        }
    }

    private void OnMouseDown()
    {
        _MouseDown = true;
        Debug.Log("right");
    }

    private void OnMouseUp()
    {
        _MouseDown = false;
    }
}
