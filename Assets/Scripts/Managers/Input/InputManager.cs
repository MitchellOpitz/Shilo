using UnityEngine;

public class InputManager : MonoBehaviour
{

    public InputAxisState[] inputs;
    public InputState inputState;

    // Update is called once per frame
    void Update()
    {
        foreach(var input in inputs)
        {
            inputState.SetButtonValue(input.button, input.value);
        }
    }
}
