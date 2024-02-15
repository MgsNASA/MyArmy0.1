using System.Collections;
using UnityEngine;


    public class BootstrapEntryPoint : MonoBehaviour
    {

        [SerializeField] private LoadingScreenManager _loadingScreenManager;
        [SerializeField] private GameManager _gameManager;

        private IEnumerator Start( )
        {
            // Показываем загрузочный экран
            yield return _loadingScreenManager.ShowLoadingScreen ( 10 );
            // Ваш код загрузки или инициализации
            Debug.Log ( "Загрузка..." );
            _gameManager.StartGameCreate ();
            _gameManager.Inilization ();
            // Завершение загрузки
            Debug.Log ( "Инициализация и Загрузка объектов завершена !" );
            // Скрываем загрузочный экран после завершения загрузки
            _loadingScreenManager.HideLoadingScreen ();
        }




    }

