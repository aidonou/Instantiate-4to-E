using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int CloneAmount;
    public Text txtUserCloneAmount;
    

    public void TripleInstantiate()
    {
        CloneAmount = int.Parse(txtUserCloneAmount.text);
        int counter = 0;
        while (counter < CloneAmount)
        {
            Instantiate(objectToClone);
            counter++;
        }
    }
}
