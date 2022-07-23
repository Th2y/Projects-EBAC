using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonsInteractions : MonoBehaviour
{
    [SerializeField] private HorizontalLayoutGroup layoutGroup;
    [SerializeField] private Image panelImage;
    [SerializeField] private TextMeshProUGUI textOnClickButton;
    [SerializeField] private Transform localToInstantiate;
    [SerializeField] private GameObject prefabImageAllComplete;
    [SerializeField] private TextMeshProUGUI almostThere;
    [SerializeField] private TextMeshProUGUI almostThereReverse;
    [SerializeField] private Color[] colors;
    [SerializeField] private TextMeshProUGUI[] buttonText;
    [SerializeField] private Image[] girls;
    [SerializeField] private Button[] buttons;

    private bool[] clickOnButton = new bool[] { false, false, false, false, false };
    private int clicksOnButtons = 0;
    private int imagesAllComplete = 0;

    private void ActiveGirlOnLastButton(int lastButton)
    {
        for(int i = 0; i < girls.Length; i++)
        {
            if (i == lastButton)
            {
                girls[i].gameObject.SetActive(true);
            }
            else
            {
                girls[i].gameObject.SetActive(false);
            }
        }
    }

    private void OnClickAnyButton()
    {
        clicksOnButtons++;
        textOnClickButton.text = "Cliques em botões: " + clicksOnButtons;
        if(clickOnButton[0] && clickOnButton[1] && clickOnButton[2] && clickOnButton[3] && clickOnButton[4])
        {
            for(int i = 0; i < 5; i++)
            {
                buttons[i].interactable = false;
            }
            buttons[5].gameObject.SetActive(true);
        }
    }

    public void OnClickButton0()
    {
        clickOnButton[0] = true;
        panelImage.color = colors[0];
        buttonText[0].text = "Olá,";
        if (clickOnButton[0] && clickOnButton[1] && clickOnButton[2] && clickOnButton[3] && clickOnButton[4])
        {
            almostThereReverse.gameObject.SetActive(true);
        }
        ActiveGirlOnLastButton(0);
        OnClickAnyButton();
    }

    public void OnClickButton1()
    {
        clickOnButton[1] = true;
        panelImage.color = colors[1];
        buttonText[1].text = " você";
        ActiveGirlOnLastButton(1);
        OnClickAnyButton();
    }

    public void OnClickButton2()
    {
        clickOnButton[2] = true;
        layoutGroup.childAlignment = TextAnchor.LowerCenter;
        textOnClickButton.color = Color.blue;
        buttonText[2].text = " já";
        ActiveGirlOnLastButton(2);
        OnClickAnyButton();
    }

    public void OnClickButton3()
    {
        clickOnButton[3] = true;
        layoutGroup.childAlignment = TextAnchor.MiddleCenter;
        textOnClickButton.color = Color.black;
        buttonText[3].text = " clicou";
        ActiveGirlOnLastButton(3);
        OnClickAnyButton();
    }

    public void OnClickButton4()
    {
        clickOnButton[4] = true;
        layoutGroup.childAlignment = TextAnchor.UpperCenter;
        buttonText[4].text = " aqui";
        if (clickOnButton[0] && clickOnButton[1] && clickOnButton[2] && clickOnButton[3] && clickOnButton[4])
        {
            almostThere.gameObject.SetActive(true);
        }
        ActiveGirlOnLastButton(4);
        OnClickAnyButton();
    }

    public void OnClickButton5()
    {
        buttons[5].interactable = false;
        panelImage.color = colors[2];
        layoutGroup.childAlignment = TextAnchor.UpperCenter;
        textOnClickButton.color = Color.black;
        imagesAllComplete++;
        Instantiate(prefabImageAllComplete, localToInstantiate);
        ActiveGirlOnLastButton(5);
        OnClickAnyButton();
        Invoke(nameof(OnClickAllButtons), 1f);
    }

    private void OnClickAllButtons()
    {
        for (int i = 0; i < 5; i++)
        {
            buttons[i].interactable = true;
            buttonText[i].text = "Button";
            clickOnButton[i] = false;
        }
        buttons[5].interactable = true;
        buttons[5].gameObject.SetActive(false);
        clicksOnButtons = 0;
        textOnClickButton.text = "Cliques em botões: " + clicksOnButtons;
    }
}
