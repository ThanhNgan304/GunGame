using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RandomString : MonoBehaviour
{
    // Start is called before the first frame update
    public Text txt;
    public List<string> lText = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
       // ChangText();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ChangText()
    {
        lText.Add("table");
        lText.Add("ban");
        lText.Add("giuong");
        int index = Random.Range(0, lText.Count - 1);
        txt.text = lText[index];
    }
}
