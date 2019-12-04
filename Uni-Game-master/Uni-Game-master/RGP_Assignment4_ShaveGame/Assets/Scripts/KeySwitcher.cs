using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeySwitcher : MonoBehaviour
{
    public List<GameObject> hairs = new List<GameObject>();
    public List<GameObject> beards = new List<GameObject>();
    public List<GameObject> moustache = new List<GameObject>();

    public List<GameObject> objects = new List<GameObject>();
    int index;
    int listOfIndexes;

    [SerializeField]
    private GameObject item, item1;

    int requestIndex;

    bool onePressed, twoPressed, threePressed;

    public List<GameObject> requests = new List<GameObject>();

    public int rand = 0;



    void Start()
    {
        item = GetComponent<GameObject>();
        item1 = GetComponent<GameObject>();
    }

    void Update()
    {
       switchLists();

        Wins();
    }

    void switchLists()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            onePressed = true;
            twoPressed = false;
            threePressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            onePressed = false;
            twoPressed = true;
            threePressed = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            onePressed = false;
            twoPressed = false;
            threePressed = true;
        }


        if (onePressed == true)
        {
            keyInput(hairs);

            listOfIndexes = 0;

            Debug.Log("hair list beith here");
        }
        else if(twoPressed == true)
        {
            keyPressed(beards);

            listOfIndexes = 1;

            Debug.Log("beard list beith here");
        }
        else if(threePressed == true)
        {
            keyPressed(moustache);

            listOfIndexes = 2;

            Debug.Log("moustache list beith here");
        }
    }

    public void keyInput(List<GameObject> objects)
    {

        Debug.Log(objects);
        if(Input.GetKeyDown(KeyCode.Q))
        {   
            Debug.Log("q down q down");
            index = 0;
            item = objects[index];
        }
         else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("w down w down");
            index = 1;
            item = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("e down e down");
            index = 2;
            item = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a down a down");
            index = 3;
            item = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("s down s down");
            index = 4;
            item = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("d down d down");
            index = 5;
            item = objects[index];
        }

        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);

            if (obj == item)
            {
                item.SetActive(true);
            }
        }
    }

    public void keyPressed(List<GameObject> objects)
    {
        Debug.Log(objects);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("q down q down");
            index = 0;
            item1 = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("w down w down");
            index = 1;
            item1 = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("e down e down");
            index = 2;
            item1 = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a down a down");
            index = 3;
            item1 = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("s down s down");
            index = 4;
            item1 = objects[index];
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("d down d down");
            index = 5;
            item1 = objects[index];
        }
        
        foreach (GameObject obj in objects)
        {
            obj.SetActive(false);

            if (obj == item1)
            {
                item1.SetActive(true);
            }
        }
    }

    void Requests()
    {
        /*int requestIndex;
        int requestListIndex;
        /*Random.Range(0, requestH.Count);
        Random.Range(0, requestBM.Count);

        for (int i = 0; i < requestH.Count; i++)
        {
            for (int j = 0; j < requestBM.Count; j++)
            {
                
            }
        }*/

       

        
        
    }

    void Wins()
    {
        /*if (listOfIndexes == 0 && index == 0 && listOfIndexes == 1 && index == 0)
        {
            Debug.Log("Win");
        }*/


       
        if (item.name == "Hair_01" && item1.name == "Beard_01" && rand == 0)
        {
            rand++;
            
            Debug.Log("ABOUT FUCKING TIME");
        }

        if (item.name == "Hair_02" && item1.name == "Beard_02" && rand == 1)
        {
            rand++;
            Debug.Log("ABOUT FUCKING TIME2");
        }

        if (item.name == "Hair_03" && item1.name == "Beard_03" && rand == 2)
        {
            rand++;
            Debug.Log("ABOUT FUCKING TIME3");
        }

        if (item.name == "Hair_02" && item1.name == "Beard_04" && rand == 3)
        {
            rand++;
            Debug.Log("ABOUT FUCKING TIME4");
        }

        if (item.name == "Hair_03" && item1.name == "Beard_05" && rand == 4)
        {
            rand++;
            Debug.Log("ABOUT FUCKING TIME5");
        }

        if (rand == 5)
        {
            SceneManager.LoadScene(2);
        }

        foreach (GameObject obj in requests)
         {
             obj.SetActive(false);

             if (requests[rand] == obj)
             {
                requests[rand].gameObject.SetActive(true);
            }
         }

       

    }
}