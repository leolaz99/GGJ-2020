using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inventory;
    [SerializeField] private string[] dialogue;
    [SerializeField] public Text dialogeText;
    public bool isDialogueActive;
    private bool dontAsk = true;
    private int index;
    public int itemCollected = 0;
    private GameObject obj;

    public GameObject HomeDoor, HomeSign;
    [SerializeField] KeyCode continueKey;
    // Start is called before the first frame update
    public void StartDialogue(GameObject other)
    {
        obj = other;
        itemCollected++;
        index = 0;
        gameObject.SetActive(true);
        dialogue = other.GetComponent<ItemInfo>().dialogueText;
        isDialogueActive = false;
        dialogeText.text = dialogue[0];
    }


    public void StartReading(GameObject other)
    {
        obj = other;
        index = 0;
        gameObject.SetActive(true);
        dialogue = other.GetComponent<SignInfo>().dialogueText;
        isDialogueActive = false;
        dialogeText.text = dialogue[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(continueKey) && isDialogueActive == true)
        {
            index++;
            if (index >= dialogue.Length) 
            {
                if (obj.tag == "sign")
                {
                    if (obj.GetComponent<SignInfo>().isCasa)
                    {
                        SceneManager.LoadScene("Menu");
                    }
                }

                if (itemCollected == 6)
                {
                    HomeDoor.SetActive(true);
                    HomeSign.SetActive(true);
                    if(dontAsk == true)
                    {
                        dontAsk = false;
                        dialogeText.text = "Tt's getting late... I should go back to my house";
                    }
                    else
                    {
                        gameObject.SetActive(false);
                    }
                } 
                else
                {
                    gameObject.SetActive(false);
                }
            } 
            else dialogeText.text = dialogue[index];

        } else
        {
            isDialogueActive = true;
        }
    }
}
