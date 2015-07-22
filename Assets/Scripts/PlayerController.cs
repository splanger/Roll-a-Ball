using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // A reference to the game object's rigidbody component
    private Rigidbody rb;
    public float speed;

    // Called only once when the script is attached to an object
    //
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update () {
	
	}

    // Called beforeperforming any physics calculations 
    // This is where our physics code will go
    //
    // The ball is moved by applied forces to the rigid body
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
        //Destroy(other.gameObject);
    }
}
