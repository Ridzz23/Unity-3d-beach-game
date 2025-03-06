using UnityEngine;

public class CoinController : MonoBehaviour
{

    public float rotSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, rotSpeed);
    }
}
