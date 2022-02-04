using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buton1 : MonoBehaviour
{
    public GameObject panel,buton,ok,panel1,panel2;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(true);
        panel2.SetActive(false);




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
            panel.SetActive(false);
            ok.SetActive(false);
            panel2.SetActive(true);
            panel1.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            

        }
        else
        {
            panel.SetActive(true);
            ok.SetActive(true);
            panel2.SetActive(false);
            panel1.SetActive(true);

        }
       




    }




}