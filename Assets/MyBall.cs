using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;


    // Start is called before the first frame update
    void Start()
    {
        // Bring it own Component which is T Type.
        // rigid is Rigidbody Type, so we are going to use Rigidbody 
        // instead of using T.
        // It won't work if puts 3D Component into 2D Component.
        rigid = GetComponent<Rigidbody>();

        /* Object will move to right for itself. */
        // rigid.velocity = Vector3.right;

        /* Or, you can set the way this Object moving way as left. */
        //rigid.velocity = Vector3.left;
        rigid.velocity = new Vector3(2, 4, -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
