using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class FoundCollectable : MonoBehaviour
{
    public Image[] Slots;
    public Sprite[] collectableBlocks;
    public Sprite shadow;
    public GameObject objClicked;

    void Start ()
    {

    }

    void Update ()
    {

    }

    public void TransferCollectable (int slot)
    {
        Debug.Log("hello");
        Slots[slot-1].sprite = collectableBlocks[slot-1];
        Destroy(objClicked);
        if (AllCollected() == 1)
        {
            //end game
        }
    }

    public void CollectableOne ()
    {
        Debug.Log("Collected One.");
        TransferCollectable(1);
       
    }

    public void CollectableTwo ()
    {
        TransferCollectable(2);
    }

    public void CollectableThree ()
    {
        TransferCollectable(3);
    }

    public void CollectableFour ()
    {
        TransferCollectable(4);
    }

    public void CollectableFive ()
    {
        TransferCollectable(5);
    }

    public void CollectableSix ()
    {
        TransferCollectable(6);
    }

    public void CollectableSeven ()
    {
        TransferCollectable(7);
    }

    public void CollectableEight ()
    {
        TransferCollectable(8);
    }

    public void CollectableNine ()
    {
        TransferCollectable(9);
    }

    public int AllCollected()
    {
        int value = 1;
        int i = 0;
        while (value == 1)   
        {
            if (Slots[i].sprite == shadow)
            {
                value = 0;
            }
            i++;
        }

        return value;
    }

}
