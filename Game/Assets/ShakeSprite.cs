using UnityEngine;
using System.Collections;

public class ShakeSprite : MonoBehaviour {

    public float shakeSpeed = 0.05f;
    bool i, o;
	// Use this for initialization
	void Start () {
        i = true;
        o = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (o)
        {
            this.GetComponent<Transform>().Translate(new Vector3(
                i == true ? shakeSpeed : -shakeSpeed,
                i == true ? shakeSpeed : -shakeSpeed,
                0.0f));
        }
        else
        {
            this.GetComponent<Transform>().Translate(new Vector3(
                i == true ? -shakeSpeed : shakeSpeed,
                i == true ? shakeSpeed : -shakeSpeed,
                0.0f));

            i = !i;
        }
        o = !o;
	}
}
