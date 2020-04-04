using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodedView : MonoBehaviour
{

    private GameObject cyl1;
    private GameObject cyl2;
    private GameObject cyl3;
    private GameObject piston1;
    private GameObject piston2;
    private GameObject piston3;

    //defualt
    private Vector3 c1Def;
    private Vector3 c2Def;
    private Vector3 c3Def;
    private Vector3 p1Def;
    private Vector3 p2Def;
    private Vector3 p3Def;

    //checks
    bool c1 = false;
    bool c2 = false;


    // Start is called before the first frame update
    void Start()
    {
        cyl1 = transform.GetChild(0).gameObject;
        cyl2 = transform.GetChild(1).gameObject;
        cyl3 = transform.GetChild(2).gameObject;
        piston1 = transform.GetChild(4).gameObject;
        piston2 = transform.GetChild(5).gameObject;
        piston3 = transform.GetChild(6).gameObject;
        c1Def = cyl1.transform.position;
        c2Def = cyl2.transform.position;
        c3Def = cyl3.transform.position;
        p1Def = piston1.transform.position;
        p2Def = piston2.transform.position;
        p3Def = piston3.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount>0) {
            if (!c1 && !c2) {
                c1 = true;
            }
            else if (c1 && !c2)
            {
                c2 = true;
            }
            else
            {
                c1 = false;
                c2 = false;
            }
        }
        if (c1 && !c2)
        {
            view2();
        }
        else if (c1 && c2)
        {
            view3();
        }
        else
        {
            view1();
        }
    }

    private void view1() {
        cyl1.transform.position = Vector3.MoveTowards(cyl1.transform.position, c1Def, .01f);  
        cyl2.transform.position = Vector3.MoveTowards(cyl2.transform.position, c2Def, .01f);
        cyl3.transform.position = Vector3.MoveTowards(cyl3.transform.position, c3Def, .01f);
        piston1.transform.position = Vector3.MoveTowards(piston1.transform.position, p1Def, .01f);
        piston2.transform.position = Vector3.MoveTowards(piston2.transform.position, p2Def, .01f);
        piston3.transform.position = Vector3.MoveTowards(piston3.transform.position, p3Def, .01f);
    }

    private void view2()
    {
        Vector3 c1 = new Vector3( .79f, c1Def.y, c1Def.z);
        Vector3 c2 = new Vector3(-0.327f, -0.159f, -0.566f);
        Vector3 c3 = new Vector3(-0.389f, -0.159f, 0.672f);

        cyl1.transform.position = Vector3.MoveTowards(cyl1.transform.position, c1,.01f);
        cyl2.transform.position = Vector3.MoveTowards(cyl2.transform.position, c2, .01f);
        cyl3.transform.position = Vector3.MoveTowards(cyl3.transform.position, c3, .01f);
    }

    private void view3()
    {
        Vector3 p1 = new Vector3( .5f, p1Def.y, p1Def.z);
        Vector3 p2 = new Vector3(-0.241f, p2Def.y, -0.321f);
        Vector3 p3 = new Vector3(-0.343f, p3Def.y, 0.413f);

        piston1.transform.position = Vector3.MoveTowards(piston1.transform.position, p1, .01f); ;
        piston2.transform.position = Vector3.MoveTowards(piston2.transform.position, p2, .01f); ;
        piston3.transform.position = Vector3.MoveTowards(piston3.transform.position, p3, .01f); ;
    }
}
