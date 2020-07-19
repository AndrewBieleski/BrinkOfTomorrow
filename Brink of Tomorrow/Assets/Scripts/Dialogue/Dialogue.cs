using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{

    public string dialogueName;
    [TextArea(3, 10)]
    public string dialogueText;
    public Dialogue leftChoice;
    public Dialogue rightChoice;
    public string leftChoiceTitle;
    public string rightChoiceTitle;

    public virtual void DialogueEvent() {}

}
