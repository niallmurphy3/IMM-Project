using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Birdo : MonoBehaviour
{
    // Movement speed
    public float speed = 2;

    // Flap force
    public float force = 300;

    // Use this for initialization
    void Start()
    {
        // Fly towards the right
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        // Flap up
        if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
    }

    // Called when a collision occurs (eg. Bird hits the ground, or a object)
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Ground"))
        {

        }
        else if (coll.gameObject.CompareTag("Obstacle"))
        {
            // Restart
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}