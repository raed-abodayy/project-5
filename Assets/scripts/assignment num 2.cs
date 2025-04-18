using UnityEngine;

public class assignmentnum2 : MonoBehaviour
{
    void Start()
    {
        string[] shop = { "Cat", "Dog", "car", "pizza", "hat", "fish", "tree", "monkey", "ball", "bird" };
        string result = "";
        int counter = 0;

        while (counter < 7)
        {
            result += shop[Random.Range(0, 10)] + " ";
            counter++;
        }

        Debug.Log(result);
    }
}
