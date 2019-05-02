using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 target;
    public Text txt;
    public List<string> lText = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //lText.Add("table");
        //lText.Add("ban");
        //lText.Add("giuong");
        //int index = Random.Range(0, lText.Count - 1);
        //txt.text = lText[index];
        LookAtCursor();
    }
    void LookAtCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }
        transform.LookAt(target);
    }
}
