using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButonGeri : MonoBehaviour
{
    public GameObject panel, buton, ok, butonac;
    public bool acik = false;
    // Start is called before the first frame update
    void Start()
    {
        

        butonac.SetActive(false);





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
            panel.SetActive(true);
            ok.SetActive(true);
            butonac.SetActive(false);
            yield return new WaitForSeconds(0.1f);
          
            buton.SetActive(true);

        }





    }




}