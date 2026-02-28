using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GreetingWindow : MonoBehaviour
{
    [SerializeField] GameObject _panelButtons;
    [SerializeField] List<GameObject> _buttons;

    [SerializeField] GameObject _panelGreeting;

    private int _timeClose = 5;

    private void Start()
    {
       _panelGreeting.SetActive(true);

        foreach (GameObject button in _buttons) 
        {
            button.SetActive(false);
        }

        _panelButtons.SetActive(false);
    }

    private void Update() 
    {
        StartCoroutine(ClosePanelGreeting());
    }

    IEnumerator ClosePanelGreeting() 
    {
        yield return new WaitForSeconds(_timeClose);
        _panelGreeting.SetActive(false);

        foreach (GameObject button in _buttons)
        {
            button.SetActive(true);
        }

        _panelButtons.SetActive(true);
    }
}
