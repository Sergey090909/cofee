using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ggg : MonoBehaviour {

    public Text aaa;

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(1.18f, 1.18f, 1.1f);
    }
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
