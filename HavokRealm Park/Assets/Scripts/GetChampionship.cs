using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChampionship : MonoBehaviour
{
    [SerializeField] private GameObject lockToHide, key1, key2, key3;

    // Update is called once per frame
    void Update()
    {
        if (key1.activeSelf && key2.activeSelf && key3.activeSelf)
        {
            lockToHide.SetActive(false);
        }
    }
}
