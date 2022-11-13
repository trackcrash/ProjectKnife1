 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionFixed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetResolution();
    }

    public void SetResolution()
    {
        Screen.SetResolution(1920, 1080, true);
    }
}
