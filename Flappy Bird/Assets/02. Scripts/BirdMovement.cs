using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private Rigidbody2D myRigid;
    public float flyPower = 10f;
    public float limitPower = 5f;
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigid.AddForce(Vector3.up * flyPower, ForceMode2D.Impulse);
            if (myRigid.velocity.y >= limitPower)
            {
                myRigid.velocity = new Vector3(myRigid.velocity.x, limitPower);
            }
        }
    }
}
