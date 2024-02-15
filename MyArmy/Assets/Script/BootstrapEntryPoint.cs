using System.Collections;
using UnityEngine;


    public class BootstrapEntryPoint : MonoBehaviour
    {

        [SerializeField] private LoadingScreenManager _loadingScreenManager;
        [SerializeField] private GameManager _gameManager;

        private IEnumerator Start( )
        {
            // ���������� ����������� �����
            yield return _loadingScreenManager.ShowLoadingScreen ( 10 );
            // ��� ��� �������� ��� �������������
            Debug.Log ( "��������..." );
            _gameManager.StartGameCreate ();
            _gameManager.Inilization ();
            // ���������� ��������
            Debug.Log ( "������������� � �������� �������� ��������� !" );
            // �������� ����������� ����� ����� ���������� ��������
            _loadingScreenManager.HideLoadingScreen ();
        }




    }

