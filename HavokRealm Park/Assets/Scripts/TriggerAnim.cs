using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnim : MonoBehaviour
{
    [SerializeField] private Animator myAnim;

    [SerializeField] private string animName;

    [SerializeField] private GameObject triggerToHide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myAnim.Play(animName, 0, 0.0f); //temps que triga en play anim
            triggerToHide.SetActive(false);
        }
    }
}



