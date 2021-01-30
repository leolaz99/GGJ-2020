using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Inventory inventory;
    [SerializeField] private string[] dialogue;
    [SerializeField] public Text dialogeText;
    public bool isDialogueActive;
    private int index;
    [SerializeField] KeyCode continueKey;
    // Start is called before the first frame update
    public void StartDialogue(GameObject other)
    {
        index = 0;
        gameObject.SetActive(true);
        dialogue = other.GetComponent<ItemInfo>().dialogueText;
        isDialogueActive = false;
        dialogeText.text = dialogue[0];
    }

    public void StartReading(GameObject other)
    {
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

            if (index >= dialogue.Length) gameObject.SetActive(false);
            else dialogeText.text = dialogue[index];

        } else
        {
            isDialogueActive = true;
        }
    }
}
