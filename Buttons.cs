using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Text txtControlType = null;

    private void Start()
    {
        txtControlType.text = Globals.SetControlType_GetDesc(Globals.ControlType);
    }
    public void btnKeyboard_Click()
    {
        txtControlType.text = Globals.SetControlType_GetDesc(1);        
    }
    public void btnMouse_Click()
    {
        txtControlType.text = Globals.SetControlType_GetDesc(2);
    }
    public void btnPlay_Click()
    {
        SceneManager.LoadScene(1);
    }
}
