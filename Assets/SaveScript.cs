using UnityEngine;
using  UnityEngine.UI;
using System.Collections;

public class SaveScript : MonoBehaviour
{
    private string str;
    public InputField inputField;
    public Text text;

    public void SaveText()
    {
        str = inputField.text;
        text.text = str;
        inputField.text = "";
    }
}
