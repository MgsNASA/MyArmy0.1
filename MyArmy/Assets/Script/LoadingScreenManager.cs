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
        // ��������� ������ UiElement ����������
        AsyncOperationHandle<GameObject> handle = uiElementAssetReference.InstantiateAsync ( transform.position , Quaternion.identity );
        yield return handle;

        // ���������, ������� �� �������� ������
        if ( handle.Status == AsyncOperationStatus.Succeeded )
        {
            uiElementInstance = handle.Result;
            uiElementInstance.transform.SetParent ( transform );
            uiElementInstance.SetActive ( true );

            // ����� ����� �������� ������������ ������
            yield return new WaitForSeconds ( displayDuration );
        }
        else
        {
            Debug.LogError ( "Failed to load UiElement prefab." );
        }

        // �������� ����������� ����� ����� �����
        HideLoadingScreen ();
    }

    public void HideLoadingScreen( )
    {
        // ����� �������� ������ ��� ������� ������������ ������ ��� ����������� ��� ����������
        if ( uiElementInstance != null )
        {
            uiElementInstance.SetActive ( false );
        }
    }
}
