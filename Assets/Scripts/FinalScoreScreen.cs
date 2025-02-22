using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
public class FinalScoreScreen : MonoBehaviour
{
    // UI Document Elements
    private VisualElement root;
    private Label targetsHit, liquidRemaining, streaksAchieved, calculation;
    private Button mainMenuButton, playAgainButton;
    
    // Unity Events
    public UnityEvent OnMainMenuButtonClicked;
    public UnityEvent OnPlayAgainButtonClicked;
    
    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        targetsHit = root.Q<Label>("TargetsHit");
        liquidRemaining = root.Q<Label>("LiquidRemaining");
        streaksAchieved = root.Q<Label>("StreaksAchieved");
        calculation = root.Q<Label>("Calculation");
        mainMenuButton = root.Q<Button>("MainMenuButton");
        playAgainButton = root.Q<Button>("PlayAgainButton");
        
        OnMainMenuButtonClicked ??= new UnityEvent();
        OnPlayAgainButtonClicked ??= new UnityEvent();
        
        mainMenuButton.clicked += () => { OnMainMenuButtonClicked?.Invoke(); };
        playAgainButton.clicked += () => { OnPlayAgainButtonClicked?.Invoke(); };
        
        Hide();
    }

    public void DisplayScore()
    {
        Show();
    }
    
    public void Show()
    {
        root.style.display = DisplayStyle.Flex;
    }

    public void Hide()
    {
        root.style.display = DisplayStyle.None;
    }
}
