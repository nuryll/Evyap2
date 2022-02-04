using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eg : MonoBehaviour
{
    public GameObject ok, panel1, panel2, panel3,panel4,panel5;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {


        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(false);
        panel5.SetActive(false);




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
           
            panel1.SetActive(true);
            panel2.SetActive(true);
            yield return new WaitForSeconds(1);
            panel3.SetActive(true);
            yield return new WaitForSeconds(1);
            panel4.SetActive(true);
            yield return new WaitForSeconds(1);
            panel5.SetActive(true);


        }
        else
        {

            ok.SetActive(true);
            panel2.SetActive(false);
            panel1.SetActive(false);
            panel3.SetActive(false);
            panel4.SetActive(false);
            panel5.SetActive(false);

        }





    }




}