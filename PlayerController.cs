using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float dampingFactor;
    public float extraGravity;
    Rigidbody rb;
    float xInput;
    float yInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -3f){
            SceneManager.LoadScene("Game");
        }
    }

    // for smoother movement write movement code in FixedUpdate 
    private void FixedUpdate() {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        Vector3 velocity = rb.linearVelocity;

        Vector3 moveDirection = new Vector3(xInput, 0, yInput).normalized;
        Vector3 targetVelocity = moveDirection * speed;

        rb.linearVelocity = Vector3.Lerp(rb.linearVelocity, targetVelocity, Time.fixedDeltaTime * dampingFactor);
        rb.AddForce(Vector3.down * extraGravity, ForceMode.Acceleration);


    }

    private void OnTriggerEnter(Collider collision)
    {
        // Check if the object the player collided with has the "Collectible" tag
        if (collision.gameObject.CompareTag("Coin"))
        {
            // Update score
            ScoreManager.instance.AddPoint();

            // Destroy the object the player collided with
            Destroy(collision.gameObject);

            // You can also print the score to the console for testing

        }
    }
}
