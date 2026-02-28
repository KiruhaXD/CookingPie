using UnityEngine;

public class PackingInTrack : MonoBehaviour
{
    [SerializeField] Transform[] _pointForPackingInCar;

    [SerializeField] GameObject _boxPrefab;

    private int _maxBoxes = 10;

    [SerializeField] FinishWindow _finishWindow;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Box")) 
        {
            int rand = Random.Range(0, _pointForPackingInCar.Length);

            Instantiate(_boxPrefab, _pointForPackingInCar[rand].position, Quaternion.identity);

            _maxBoxes--;

            _finishWindow.UpdateScoreText(_maxBoxes);

            if (_maxBoxes <= 0) 
            {
                _maxBoxes = 0;
                _finishWindow.UpdateScoreText(_maxBoxes);
                _finishWindow.FinishGame();
            }
        }
    }
}
