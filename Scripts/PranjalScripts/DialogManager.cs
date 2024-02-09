using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI text_display;
    public string[] sentences;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    public void cstart() {
        //StopAllCoroutines(); 
    StartCoroutine(Write()); }
    IEnumerator Write() {
        text_display.text = "";
        int index = Random.Range(0,7);
        foreach (var a in sentences[index].ToCharArray())
        {
            text_display.text += a;
            yield return new WaitForSeconds(0.08f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
