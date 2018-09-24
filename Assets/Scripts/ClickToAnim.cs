using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToAnim : MonoBehaviour
{

    public Animator animator;
    public string MouseDown = "MouseDown";
    private Camera camera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hitInfo;
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

        if (Physics.Raycast(ray, out hitInfo) && hitInfo.collider.gameObject == gameObject)
        {
            if(Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger(MouseDown);
            }

        }

    }
}
