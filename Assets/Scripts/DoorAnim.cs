using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{

    public Animator animator;
    public LayerMask Player;

    void Start()
    {
        Player = GetComponent<LayerMask>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            animator.SetBool("Door Open", true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            StartCoroutine("ExitTimer");
        }
    }


    IEnumerator ExitTimer()
    {
        yield return new WaitForSeconds(2);
        animator.SetBool("Door Open", false);
    }
}

