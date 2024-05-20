using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    //[SerializeField] private float xPos, yPos, zPos;
    //[SerializeField] private float xRot, yRot, zRot;

    //[SerializeField] private GameObject player;
    //[SerializeField] private GameObject triggerToHide;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        player.transform.position = new Vector3(xPos, yPos, zPos);
    //        //player.transform.Rotate(xRot, yRot, zRot);
    //        player.transform.rotation = Quaternion.Euler(xRot, yRot, zRot);
    //        triggerToHide.SetActive(false);
    //    }
    //}

    [SerializeField] private Vector3 newPosition;
    [SerializeField] private Vector3 newRotation;

    [SerializeField] private GameObject player;

    [SerializeField] private GameObject triggerToHide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Teleport the player to the new position
            player.transform.position = newPosition;

            // Set the player's rotation to the new rotation
            player.transform.rotation = Quaternion.Euler(newRotation);

            triggerToHide.SetActive(false);
        }
    }
}
