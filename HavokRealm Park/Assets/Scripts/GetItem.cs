using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GetItem : MonoBehaviour
//{
//    [SerializeField] private GameObject SpriteToHide, SpriteToShow, ObjectToHide, LockToHide/*, ChampionshipToHideSprite, ChampionshipToShowSprite*/;
//    //[SerializeField] private bool isKey, isChampionship;
//    private bool hasChampionship;

//    private int keyCounter = 0;
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            SpriteToHide.SetActive(false);
//            SpriteToShow.SetActive(true);
//            ObjectToHide.SetActive(false);

//            //if (isKey)
//            //{
//            //    keyCounter++;
//            //    {
//            //        if(keyCounter == 3)
//            //        {
//            //            readyToUnlock = true;
//            //            LockToHide.SetActive(false);
//            //        }
//            //    }
//            //}
//            if (this.gameObject.name == "Item_Key" || this.gameObject.name == "Item_Key (1)" || this.gameObject.name == "Item_Key (2)") 
//            {
//                keyCounter++;
//            }
//        }

//    }
//    private void Update()
//    {
//        if (keyCounter == 3)
//        {
//            hasChampionship = true;
//            //ChampionshipToHideSprite.SetActive(false);
//            //ChampionshipToShowSprite.SetActive(true);
//            LockToHide.SetActive(false);
//        }
//    }
//}


public class GetItem : MonoBehaviour
{
    [SerializeField] private GameObject spriteToHide;
    [SerializeField] private GameObject spriteToShow;
    [SerializeField] private GameObject objectToHide;
    [SerializeField] private GameObject lockToHide;
    // [SerializeField] private GameObject championshipToHideSprite;
    // [SerializeField] private GameObject championshipToShowSprite; // Uncomment if needed

    private static int keyCounter = 0;
    private static bool hasChampionship = false;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider that entered the trigger belongs to the player
        if (other.CompareTag("Player"))
        {
            // Hide and show relevant sprites and objects
            if (spriteToHide != null)
            {
                spriteToHide.SetActive(false);
                Debug.Log("SpriteToHide has been set to inactive.");
            }
            if (spriteToShow != null)
            {
                spriteToShow.SetActive(true);
                Debug.Log("SpriteToShow has been set to active.");
            }
            if (objectToHide != null)
            {
                objectToHide.SetActive(false);
                Debug.Log("ObjectToHide has been set to inactive.");
            }

            // Check if the item is a key and update the key counter if it is
            if (this.gameObject.name == "Item_Key" || this.gameObject.name == "Item_Key (1)" || this.gameObject.name == "Item_Key (2)")
            {
                keyCounter++;
                Debug.Log("Key collected. Total keys: " + keyCounter);
                Destroy(this.gameObject); // Destroy the key object after collection
            }
        }
    }

    private void Update()
    {
        // Check if the player has collected all 3 keys and hasn't unlocked the championship yet
        if (keyCounter == 3 && !hasChampionship)
        {
            hasChampionship = true;
            if (lockToHide != null)
            {
                lockToHide.SetActive(false);
                Debug.Log("LockToHide has been set to inactive.");
            }
            else
            {
                Debug.Log("LockToHide is not assigned.");
            }

            Debug.Log("All keys collected. Championship unlocked!");
            // if (championshipToHideSprite != null) championshipToHideSprite.SetActive(false);
            // if (championshipToShowSprite != null) championshipToShowSprite.SetActive(true);
        }
    }
}