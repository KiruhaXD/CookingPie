using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject _panelMenu;
    [SerializeField] GameObject _panelSettings;
    private int _keyPress = 1;
    [SerializeField] Animator _animator;

    [Header("DisablesScripts")]
    [SerializeField] Button[] _buttonsForSpawn;

    private void Start()
    {
        _panelMenu.SetActive(false);
        _panelSettings.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            _panelMenu.SetActive(true);
            switch (_keyPress) 
            {
                case 1:
                    _animator.SetBool("IsOpen", true);
                    _keyPress = 2;

                    DisablesButtons();
                    break;
                case 2:
                    _animator.SetBool("IsOpen", false);
                    _keyPress = 1;

                    _panelSettings.SetActive(false);
                    EnablesButtons();
                    break;
            }
        }
    }

    public void DisablesButtons() 
    {
        foreach (Button button in _buttonsForSpawn)
        {
            button.GetComponent<Button>().enabled = false;
        }
    }

    public void EnablesButtons()
    {
        foreach (Button button in _buttonsForSpawn)
        {
            button.GetComponent<Button>().enabled = true;
        }
    }

    public void Setting() 
    {
        _panelSettings.SetActive(true);
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
