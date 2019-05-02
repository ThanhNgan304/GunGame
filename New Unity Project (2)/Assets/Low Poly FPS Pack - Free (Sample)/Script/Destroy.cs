using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Destroy : MonoBehaviour
{
    public int index=0;
    public Text txt;
    public Text dan;
    public int sodan = 10;
    public List<string> lText = new List<string>();
    public List<string> lKeyWord = new List<string>();
    // Start is called before the first frame update
    void Start()
    {

        KhoiTao();
    }

    // Update is called once per frame
    void Update()
    {
        if(sodan > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                sodan--;
                Fire();
                dan.text = sodan.ToString();

            }

        }
        else
        {
            txt.text = "END";
        }
    }
    void Fire()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
       
            if (Physics.Raycast(ray, out hit))
            {
                if (lKeyWord.Count > 0)
                {
                    if (hit.transform.tag.Equals(lKeyWord[index]))
                    {
                        Destroy(hit.transform.gameObject);
                        ChangeText();
                    }
                }
                else
                {
                    txt.text = "end";
                }
        }
       
    }
    public void KhoiTao()
    {
        lText.Add("table");
        lText.Add("ban");
        lText.Add("giuong");
        lKeyWord.Add("table");
        lKeyWord.Add("light");
        lKeyWord.Add("giuong");
        index = Random.Range(0, lText.Count - 1);
        txt.text = lKeyWord[index];
    }
    public void ChangeText()
    {
        lKeyWord.Remove(lKeyWord[index]);
        index = Random.Range(0, lKeyWord.Count - 1);
        txt.text = lKeyWord[index];
    }

}
