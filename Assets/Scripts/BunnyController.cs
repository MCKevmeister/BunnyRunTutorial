using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    private Animator myAnim;
    public float bunnyJumpForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * bunnyJumpForce);
        }
        // myAnim.SetFloat("vVelocity", Mathf.Abs(myRigidBody.velocity.y));
        myAnim.SetFloat("vVelocity", myRigidBody.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene( );
    }
}
