using UnityEngine;
using UnityEngine.UIElements;

public class GameUIHandler : MonoBehaviour
{
    public PlayerController PlayerControl;
    public UIDocument UIDoc;

    private Label m_HealthLabel;

    private void Start()
    {
        PlayerControl.vie += HealthChanged;
        m_HealthLabel = UIDoc.rootVisualElement.Q<Label>("VIE");

        HealthChanged();
    }


    void HealthChanged()
    {
        m_HealthLabel.text = $"{PlayerControl.vie}/{PlayerControl.MaxVie}";
    }
}