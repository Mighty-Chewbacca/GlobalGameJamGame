using UnityEngine;
using System.Collections;

public class BubbleInput : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown()
    {
        GameObject Holder1 = GameObject.FindGameObjectWithTag("Holder1");
        HolderScript hs = (HolderScript)Holder1.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder1.GetComponent<Transform>().position;
            hs.setOccupied(true);
            return;
        }
        GameObject Holder2 = GameObject.FindGameObjectWithTag("Holder2");
        hs = (HolderScript)Holder2.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder2.GetComponent<Transform>().position;
            hs.setOccupied(true);
            return;
        }

        GameObject Holder3 = GameObject.FindGameObjectWithTag("Holder3");
        hs = (HolderScript)Holder3.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder3.GetComponent<Transform>().position;
            hs.setOccupied(true);
            return;
        }

        GameObject Holder4 = GameObject.FindGameObjectWithTag("Holder4");
        hs = (HolderScript)Holder4.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder4.GetComponent<Transform>().position;
            hs.setOccupied(true);
            return;
        }

        GameObject Holder5 = GameObject.FindGameObjectWithTag("Holder5");
        hs = (HolderScript)Holder5.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder5.GetComponent<Transform>().position;
            hs.setOccupied(true);
            return;
        }
    }
}
