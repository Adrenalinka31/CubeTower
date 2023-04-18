
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speed = 10f;
    private Transform rotator;

    private void Start()
    {
        rotator = GetComponent<Transform>();
    }
    private void Update()
    {
        rotator.Rotate(0,speed * Time.deltaTime,0);
    }
}
