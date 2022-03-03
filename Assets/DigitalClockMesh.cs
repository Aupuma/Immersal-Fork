using MText;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalClockMesh : MonoBehaviour
{
    Modular3DText modular3DText;

    private void Awake()
    {
        modular3DText = GetComponent<Modular3DText>();
    }

    // Update is called once per frame
    void Update()
    {
        modular3DText.UpdateText(System.DateTime.Now.Hour + " " + System.DateTime.Now.Minute);
    }
}
