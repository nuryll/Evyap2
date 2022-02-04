using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonIleri : MonoBehaviour
{
    public GameObject panel1, text1, panel2, text2, panel3, text3;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {










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


            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            panel3.SetActive(false);
            panel1.SetActive(false);
            text3.SetActive(false);
            panel1.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            text1.SetActive(false);
            panel2.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            yield return new WaitForSeconds(0.1f);

            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            yield return new WaitForSeconds(0.1f);

            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            yield return new WaitForSeconds(0.1f);
            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            text2.SetActive(true);



        }
        else
        {

            panel2.GetComponent<Image>().color = new Color32(255, 255, 255, 0);
            panel2.SetActive(false);
            text2.SetActive(false);
            panel3.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
            yield return new WaitForSeconds(0.1f);

            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
            yield return new WaitForSeconds(0.1f);

            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
            yield return new WaitForSeconds(0.1f);
            panel3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            text3.SetActive(true);



        }





    }
}