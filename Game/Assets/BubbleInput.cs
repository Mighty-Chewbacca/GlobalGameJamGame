using UnityEngine;
using System.Collections;

public class BubbleInput : MonoBehaviour {

    bool chosen = false;
    GameObject pair = null;
    Vector3 position;
	// Use this for initialization
	void Start () {
        position = this.GetComponent<Transform>().position;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnMouseDown()
    {
        // Determine if it's being removed from the list
        if (chosen)
        {
            HolderScript hscript = (HolderScript)this.getPair().GetComponent(typeof(HolderScript));
            hscript.setOccupied(false);

            // Set a new position for the bubble in the viewport
            this.GetComponent<Transform>().position = position;
            return;
        }

        // Placing in holders

        GameObject Holder1 = GameObject.Find("Holder1");
        HolderScript hs = (HolderScript)Holder1.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder1.GetComponent<Transform>().position;
            hs.setOccupied(true);
            chosen = true;
            this.setPair(Holder1);
            return;
        }
        GameObject Holder2 = GameObject.Find("Holder2");
        hs = (HolderScript)Holder2.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder2.GetComponent<Transform>().position;
            hs.setOccupied(true);
            chosen = true;
            this.setPair(Holder2);
            return;
        }

        GameObject Holder3 = GameObject.Find("Holder3");
        hs = (HolderScript)Holder3.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder3.GetComponent<Transform>().position;
            hs.setOccupied(true);
            chosen = true;
            this.setPair(Holder3);
            return;
        }

        GameObject Holder4 = GameObject.Find("Holder4");
        hs = (HolderScript)Holder4.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder4.GetComponent<Transform>().position;
            hs.setOccupied(true);
            chosen = true;
            this.setPair(Holder4);
            return;
        }

        GameObject Holder5 = GameObject.Find("Holder5");
        hs = (HolderScript)Holder5.GetComponent(typeof(HolderScript));
        if (!hs.getOccupied())
        {
            this.GetComponent<Transform>().position = Holder5.GetComponent<Transform>().position;
            hs.setOccupied(true);
            chosen = true;
            this.setPair(Holder5);
            return;
        }
    }

    public GameObject getPair()
    {
        return pair;
    }

    public void setPair(GameObject beingheldby)
    {
        pair = beingheldby;
    }
}
