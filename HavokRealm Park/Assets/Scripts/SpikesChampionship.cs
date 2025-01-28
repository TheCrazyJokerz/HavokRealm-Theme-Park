using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesChampionship : MonoBehaviour
{
    [SerializeField] private Animator myAnim;

    [SerializeField] private string animName;

    [SerializeField] private GameObject triggerToHide;

    [SerializeField] private GameObject championshipFullIcon;

    public GameObject lockToHide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (championshipFullIcon.activeSelf)
            {
                lockToHide.SetActive(false);
                myAnim.Play(animName, 0, 0.0f); //temps que triga en play anim
                triggerToHide.SetActive(false);
            }
        }
    }
}
