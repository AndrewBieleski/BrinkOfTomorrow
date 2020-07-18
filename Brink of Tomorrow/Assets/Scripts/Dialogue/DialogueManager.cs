using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public String title;
	public String text;
	public Button leftButton;
	public Button rightButton;
    public Dialogue currentDialogue;
	public GameObject DialogueScreen;

	private void Start()
	{
		leftButton.gameObject.SetActive(false);
		rightButton.gameObject.SetActive(false);
	}

	internal void StartDialogue(Dialogue targetDialogue)
	{
        currentDialogue = targetDialogue;
		DialogueScreen.SetActive(true);

		DisplayNextDialogue();
	}

	internal void DisplayNextDialogue()
	{
		title = currentDialogue.dialogueName;
		text = currentDialogue.dialogueText;
		if (currentDialogue.leftChoice.leftChoiceTitle != null) {
			leftButton.gameObject.SetActive(true);
			leftButton.GetComponent<Text>().text = currentDialogue.leftChoice.leftChoiceTitle;
		} else {
			leftButton.gameObject.SetActive(false);
		}
		if (currentDialogue.rightChoice.rightChoiceTitle != null) {
			rightButton.gameObject.SetActive(true);
			rightButton.GetComponent<Text>().text = currentDialogue.rightChoice.rightChoiceTitle;
		} else {
			rightButton.gameObject.SetActive(false);
		}
	}

	void OnKeyPressed()
	{
		if (Event.current.keyCode == KeyCode.Escape) {
			CloseDialogue();
		}
	}

		internal void CloseDialogue()
	{
		currentDialogue = null;
		DialogueScreen.SetActive(false);
	}

	internal void LeftButton()
	{
		currentDialogue = currentDialogue.leftChoice;
		DisplayNextDialogue();
	}

	internal void RightButton()
	{
		currentDialogue = currentDialogue.rightChoice;
		DisplayNextDialogue();
	}

}
