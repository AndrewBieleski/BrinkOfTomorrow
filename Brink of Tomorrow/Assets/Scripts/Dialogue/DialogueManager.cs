using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
	public TextMeshProUGUI title;
	public TextMeshProUGUI text;
	public Button leftButton;
	public Button rightButton;
    public Dialogue currentDialogue;
	public GameObject DialogueScreen;
	public float typeSpeed = 0.1f;
	public Player player;
	private DialogueTrigger currentSource;

	private void Start()
	{
		leftButton.gameObject.SetActive(false);
		rightButton.gameObject.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKey(KeyCode.Escape) || (DialogueScreen.activeInHierarchy == true && currentSource != null && player.DistanceCheck(currentSource.gameObject)) ){
			DialogueScreen.SetActive(false);
		}
		if (DialogueScreen.activeInHierarchy == true && currentSource != null && player.DistanceCheck(currentSource.gameObject)) {
			Debug.Log(player.DistanceCheck(currentSource.gameObject));
		}
	}

	private void Deactivate()
	{
		currentSource = null;
		DialogueScreen.SetActive(false);
	}

	internal void StartDialogue(Dialogue targetDialogue, DialogueTrigger source)
	{
		currentSource = source;
        currentDialogue = targetDialogue;
		DialogueScreen.SetActive(true);
		DisplayNextDialogue();
	}

	internal void DisplayNextDialogue()
	{
		StopAllCoroutines();
		title.text = "";
		text.text = "";
		leftButton.GetComponentInChildren<TextMeshProUGUI>().text = "";
		rightButton.GetComponentInChildren<TextMeshProUGUI>().text = "";
		StartCoroutine(TypeSentence(currentDialogue.dialogueName, title));
	}

	IEnumerator TypeSentence(string inputText, TextMeshProUGUI targetText)
	{
		foreach (char letter in inputText.ToCharArray()) {
			targetText.text += letter;
			yield return new WaitForSeconds(typeSpeed/2);
		}

		StartCoroutine(TypeContent(currentDialogue.dialogueText, text));
	}
	IEnumerator TypeContent(string inputText, TextMeshProUGUI targetText)
	{
		foreach (char letter in inputText.ToCharArray()) {
			targetText.text += letter;
			yield return new WaitForSeconds(typeSpeed);
		}

		if (currentDialogue.leftChoiceTitle != null) {
			leftButton.gameObject.SetActive(true);
			StartCoroutine(TypeLeftButton(currentDialogue.leftChoiceTitle, leftButton.GetComponentInChildren<TextMeshProUGUI>()));
		} else {
			leftButton.gameObject.SetActive(false);
		}
		if (currentDialogue.leftChoiceTitle != null) {
			rightButton.gameObject.SetActive(true);
			StartCoroutine(TypeRightButton(currentDialogue.rightChoiceTitle, rightButton.GetComponentInChildren<TextMeshProUGUI>()));
		} else {
			rightButton.gameObject.SetActive(true);
		}
	}
	IEnumerator TypeLeftButton(string inputText, TextMeshProUGUI targetText)
	{
			foreach (char letter in inputText.ToCharArray()) {
				targetText.text += letter;
			yield return new WaitForSeconds(typeSpeed);
			}
	}
	IEnumerator TypeRightButton(string inputText, TextMeshProUGUI targetText)
	{
		foreach (char letter in inputText.ToCharArray()) {
			targetText.text += letter;
			yield return new WaitForSeconds(typeSpeed);
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
