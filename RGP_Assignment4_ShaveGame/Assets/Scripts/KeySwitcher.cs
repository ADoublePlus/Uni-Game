using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeySwitcher : MonoBehaviour
{
    public GameObject testObject1;
    public GameObject testObject2;
    public GameObject testObject3;
    public GameObject testObject4;

    public GUIElement menuItemTester; // Connect to ui element in inspector

    void Start()
    {
        testObject1.gameObject.SetActive(false);
        testObject2.gameObject.SetActive(false);
        testObject3.gameObject.SetActive(false);
        testObject4.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            testObject1.gameObject.SetActive(true);
            testObject2.gameObject.SetActive(false);
            testObject3.gameObject.SetActive(false);
            testObject4.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            testObject2.gameObject.SetActive(true);
            testObject1.gameObject.SetActive(false);
            testObject3.gameObject.SetActive(false);
            testObject4.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            testObject3.gameObject.SetActive(true);
            testObject1.gameObject.SetActive(false);
            testObject2.gameObject.SetActive(false);
            testObject4.gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            testObject4.gameObject.SetActive(true);
            testObject1.gameObject.SetActive(false);
            testObject2.gameObject.SetActive(false);
            testObject3.gameObject.SetActive(false);
        }
    }

    // Run a serialized property/object that can detect which element of the array/ list is being accessed.
    // REFERENCE:
    //      https://catlikecoding.com/unity/tutorials/editor/custom-list/

    // Run a test case that will visually display the correct data in al
    // Decentralized data, find the correct application to run.

    void AccessInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            // Access when key is pressed
            menuItemTester.enabled = true;

            if (Input.GetKeyDown(KeyCode.Q))
            {
                testObject1.SetActive(true);
                testObject2.SetActive(false);
                testObject3.SetActive(false);
                testObject4.SetActive(false);
            }
        }
    }


    protected virtual void OnGUIExited()
    {
        bool exitedUI;

        if (exitedUI == null)
        {

        }
    }
}