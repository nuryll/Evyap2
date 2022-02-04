using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonLevha2 : MonoBehaviour
{
    public GameObject ok, panel1, panel2,panel3;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {


        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);




    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openPanel()
    {
        StartCoroutine("yanipsönme");


    }
    public IEnumerator yanipsönme()
    {


        acik = !acik;
        if (acik)
        {

            ok.SetActive(false);
            panel2.SetActive(true);
            panel1.SetActive(true);
            panel3.SetActive(true);
            yield return new WaitForSeconds(0.1f);


        }
        else
        {

            ok.SetActive(true);
            panel2.SetActive(false);
            panel1.SetActive(false);
            panel3.SetActive(false);

        }





    }




}