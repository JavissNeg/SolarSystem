using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{

    public TextMeshProUGUI dialogueText;

    public string[] lines;

    public float textSpeed = 0.1f; //velocidad de nuestro texto

    int index; //saber en que linea estamos

    void Start()
    {
        dialogueText.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && dialogueText.text == lines[0])
        {
            NextLine();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && dialogueText.text == lines[1])
        {
            NextLine();
        }
        else if (Input.GetKey(KeyCode.A) && dialogueText.text == lines[2])
        {
            NextLine();
        }
        else if (Input.GetKey(KeyCode.D) && dialogueText.text == lines[3])
        {
            NextLine();
        }
        else if (Input.GetKey(KeyCode.W) && dialogueText.text == lines[4])
        {
            NextLine();
        }
        else if (Input.GetKey(KeyCode.S) && dialogueText.text == lines[5])
        {
            NextLine();
        } 
        else if (Input.GetKey(KeyCode.LeftShift) && dialogueText.text == lines[6]) {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            dialogueText.text = lines[index];
        }
    }

    public void StartDialogue() 
    {
        index = 0; 
        StartCoroutine(WriteLine());
    }

    //metodo para escribir las lineas 
    

    IEnumerator WriteLine() 
    {
        foreach (char leteer in lines[index].ToCharArray())
        {
            dialogueText.text += leteer;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //metodo para pasar de lineas
    public void NextLine() 
    {
        if (index < lines.Length - 1)
        {
            index++;
            dialogueText.text = string.Empty; //evitar que se escriba una linea sobre otra
            StartCoroutine(WriteLine());
        }
        else 
        {
            gameObject.SetActive(false);
        }
    }
}
