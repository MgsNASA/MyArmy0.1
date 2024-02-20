
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GameManager : MonoBehaviour, Restart, Inilization,ICreatable
{
    [SerializeField] private GameObject [ ] _scriptObjects;
    public void Inilization( )
    {
       
    }

    public void Restart( )
    {
       
    }

    public void StartGame( )
    {
        foreach ( GameObject scriptObjectPrefab in _scriptObjects )
        {
            // Создаем экземпляр объекта, к которому прикреплен компонент скрипта
            GameObject newGameObject = Instantiate ( scriptObjectPrefab , Vector3.zero , Quaternion.identity );

            // Получаем компонент скрипта, прикрепленного к созданному объекту
            Inilization initializationComponent = newGameObject.GetComponent<Inilization> ();

            if ( initializationComponent != null )
            {
                // Вызываем метод Initialize() через интерфейс
                initializationComponent.Inilization ();
            }
            else
            {
                Debug.LogWarning ( "Компонент, реализующий IInitialization, не найден на объекте " + scriptObjectPrefab.name );
            }
        }
    }
}
