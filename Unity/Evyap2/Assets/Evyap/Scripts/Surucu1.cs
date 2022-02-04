using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Surucu1 : MonoBehaviour
{
    public GameObject ok, panel1, text1,alt,butonac,panel2,panel3,text2,text3;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {

        alt.SetActive(false);


        butonac.SetActive(false);
        text1.SetActive(false);
       



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
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            yield return new WaitForSeconds(0.1f);

            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            yield return new WaitForSeconds(0.1f);

            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            yield return new WaitForSeconds(0.1f);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

            alt.SetActive(true);
            text1.SetActive(true);
            butonac.SetActive(true);
        }
        else
        {

            ok.SetActive(true);

            butonac.SetActive(false);
            alt.SetActive(false);
            text1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            text2.SetActive(false);
            text3.SetActive(false);
        }





    }




}