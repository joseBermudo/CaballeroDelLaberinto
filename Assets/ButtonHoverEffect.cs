using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonHoverEffect : MonoBehaviour
{
    private TMP_Text buttonText;
    private Color normalColor;
    public Color hoverColor;
    public bool underlineOnHover;

    private void Start()
    {
        buttonText =GetComponentInChildren<TMP_Text>();
        normalColor = buttonText.color;
    }

    public void OnPointerEnter()
    {
        buttonText.color = hoverColor;
        Debug.Log("ENTRE");
        if (underlineOnHover)
        {
            buttonText.fontStyle = FontStyles.Bold | FontStyles.Italic;

        }
    }

    public void OnPointerExit()
    {
        buttonText.color = normalColor;

        if (underlineOnHover)
        {
           buttonText.fontStyle = FontStyles.Normal;

        }
    }

    
}
