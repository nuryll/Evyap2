using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonU1 : MonoBehaviour
{
    public GameObject panel ;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        





    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openPanel()
    {
         acik = !acik;
        if (acik)
        {
            panel.SetActive(true);
            
            
    

        }
        else
        {
            panel.SetActive(false);
        }
       

        



    }




}