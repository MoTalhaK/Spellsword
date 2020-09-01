using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    // 14 = min size in our inspector of our field where we write our text, 
    // 10 = amount of lines before we start to scroll
    [TextArea(14, 10)] [SerializeField] string storyText;

    [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextState() {
        return nextStates;
    }
}
