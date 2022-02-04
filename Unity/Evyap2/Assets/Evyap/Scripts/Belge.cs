using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Belge: MonoBehaviour
{
    public GameObject ImageKapat,ImageKapat2,ImageKapat3;
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
            bool isActive = ImageKapat.activeSelf;
            if (isActive = ImageKapat.activeSelf)
            {
                ImageKapat.SetActive(false);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
                yield return new WaitForSeconds(0.1f);

                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
                yield return new WaitForSeconds(0.1f);

                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
                yield return new WaitForSeconds(0.1f);
                ImageKapat.GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                ImageKapat2.SetActive(true);
            }
            else if (isActive = ImageKapat2.activeSelf)
            {
                ImageKapat2.SetActive(false);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
                yield return new WaitForSeconds(0.1f);

                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
                yield return new WaitForSeconds(0.1f);

                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
                yield return new WaitForSeconds(0.1f);
                ImageKapat2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                ImageKapat3.SetActive(true);
            }
            else if (isActive = ImageKapat3.activeSelf)
            {
               ImageKapat3.SetActive(false);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 20);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 50);
                yield return new WaitForSeconds(0.1f);

                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 70);
                yield return new WaitForSeconds(0.1f);

                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 90);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 110);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 140);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 180);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 200);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 230);
                yield return new WaitForSeconds(0.1f);
                ImageKapat3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                ImageKapat.SetActive(true);
            }
            
            
           

          



        }
       



    }


}
