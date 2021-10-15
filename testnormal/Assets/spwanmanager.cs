using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwanmanager : MonoBehaviour
{
    roadspawn roadspwaner;
    void Start()
    {
        roadspwaner = GetComponent<roadspawn>();
    }

    public void spawntrigg()
    {
        roadspwaner.Roadss();
    }
}
