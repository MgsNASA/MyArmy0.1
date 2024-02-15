using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;



public class LoadingScreenManager : MonoBehaviour
{
    [SerializeField] private AssetReference uiElementAssetReference;
    [SerializeField] private GameObject uiElementInstance;

    public IEnumerator ShowLoadingScreen( float displayDuration )
    {
        // Загружаем префаб UiElement асинхронно
        AsyncOperationHandle<GameObject> handle = uiElementAssetReference.InstantiateAsync ( transform.position , Quaternion.identity );
        yield return handle;

        // Проверяем, успешно ли загружен префаб
        if ( handle.Status == AsyncOperationStatus.Succeeded )
        {
            uiElementInstance = handle.Result;
            uiElementInstance.transform.SetParent ( transform );
            uiElementInstance.SetActive ( true );

            // Пауза перед скрытием загрузочного экрана
            yield return new WaitForSeconds ( displayDuration );
        }
        else
        {
            Debug.LogError ( "Failed to load UiElement prefab." );
        }

        // Скрываем загрузочный экран после паузы
        HideLoadingScreen ();
    }

    public void HideLoadingScreen( )
    {
        // Здесь добавьте логику для скрытия загрузочного экрана или уничтожения его экземпляра
        if ( uiElementInstance != null )
        {
            uiElementInstance.SetActive ( false );
        }
    }
}
