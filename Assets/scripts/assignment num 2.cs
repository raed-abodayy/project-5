
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class assignmentnum2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
   {
string[] shop = new string[10]{"Cat","Dog","car","pizza","hat","fish","tree","monkey","ball","bird"};
int counter=0;
while(counter<7)
{Debug.Log(shop[Random.Range(1,10)]);
counter++;
}



    }
}
