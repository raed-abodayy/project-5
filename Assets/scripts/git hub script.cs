using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Analytics;

public class githubscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      int Counter=0;
      while (Counter<10)
      {int randomNumber = Random.Range(1,21);
      Debug.Log(randomNumber);
      if(randomNumber==5)
    {continue;}
    if(randomNumber==15)
     {break;}
    Counter++;

    }
}
}