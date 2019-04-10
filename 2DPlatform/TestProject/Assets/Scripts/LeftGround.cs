using UnityEngine;

public class LeftGround : MonoBehaviour
{
    // To control the left side of the platform
    public Transform obj;
    private bool _MouseDown = false;

    private void Update()
    {
        if (_MouseDown)
        {
            if (GlobalVariables._angle >= -6)
                GlobalVariables._angle -= 0.3f;
            obj.transform.rotation = Quaternion.Euler(0, 0, GlobalVariables._angle);
        }
    }

    private void OnMouseDown()
    {
        _MouseDown = true;
        Debug.Log("left platform");
    }

    private void OnMouseUp()
    {
        _MouseDown = false;
    }
}
