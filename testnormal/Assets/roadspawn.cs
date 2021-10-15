using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class roadspawn : MonoBehaviour
{
    public List<GameObject> roads;
    private float length = 9300f;
    void Start()
    {
        print("hello");
        if(roads!=null)
        {
            print("yass");
            roads=roads.OrderBy(a => a.transform.position.x).ToList();
        }
       
    }

   public void Roadss()
    {
       
        GameObject rr = roads[0];
        roads.Remove(rr);
        
        float newposx = roads[roads.Count - 1].transform.position.x + length;
        print(rr.name+" "+newposx);
        rr.transform.position = new Vector3(newposx, 0, 0);
        roads.Add(rr);
    }
}
