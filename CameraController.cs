using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void FixedUpdate(){
        transform.LookAt(target);
    }
}
