using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{

    [SerializeField]
    GameObject avatar;

    [SerializeField]
    GameObject sourceObject;

    [SerializeField]
    float eulerAngX;

   


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = avatar.GetComponent<Animator>();
        eulerAngX = transform.localEulerAngles.x;
        if (eulerAngX >= 30 && eulerAngX < 90f)
        {
            animator.SetBool("isMoving", true);
        }
        if (eulerAngX >= 360f - 30)
        {
            animator.SetBool("isMoving", false);

        }

      


    }
}
