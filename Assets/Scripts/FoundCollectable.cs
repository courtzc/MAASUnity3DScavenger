using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class FoundCollectable : MonoBehaviour
{
    public Image Slot1;
    public Image Slot2;
    public Image Slot3;
    public Image Slot4;
    public Image Slot5;
    public Image Slot6;
    public Image Slot7;
    public Image Slot8;
    public Image Slot9;
    public Sprite[] collectableBlocks;
    public Sprite shadow;
    public GameObject objClicked;

    void Start ()
    {

    }

    void Update ()
    {

    }

    public static void TransferCollectable ()
    {
        //Destroy(objClicked);
        //Slot1.sprite = collectableBlocks[whatever];
            
    }

}
