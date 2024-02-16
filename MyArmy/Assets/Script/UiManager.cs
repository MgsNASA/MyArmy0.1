using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class UIManager : MonoBehaviour, Inilization, Restart
{
    public enum UIState
    {
        MainMenu,
        Settings,
        Shop,
        GameHud,
        EndGamePanel
        // Добавьте другие состояния по мере необходимости
    }
    public GameObject mainMenuUI;
    public GameObject settingsUI;
    public GameObject shopUI;
    public GameObject gameHud;
    // Добавьте другие объекты UI по мере необходимости

    private UIState currentState = UIState.MainMenu;

    // Создаем статическую ссылку на экземпляр класса
    private static UIManager _instance;
    public static UIManager Instance => _instance;

    private void Awake( )
    {
        // Проверяем, существует ли уже экземпляр
        if ( _instance != null && _instance != this )
        {
            // Уничтожаем текущий экземпляр, если он не совпадает с этим скриптом
            Destroy ( this.gameObject );
        }
        else
        {
            // Устанавливаем этот экземпляр как основной
            _instance = this;
        }
    }

    public void Inilization( )
    {
        SwitchUIState ( UIState.MainMenu );
    }

    private void SwitchUIState( UIState newState )
    {
        // Отключаем все UI окна
        mainMenuUI.SetActive ( false );
        settingsUI.SetActive ( false );
        shopUI.SetActive ( false );
        gameHud.SetActive ( false );
       

        // Включаем UI окно в соответствии с новым состоянием
        switch ( newState )
        {
            case UIState.MainMenu:
                mainMenuUI.SetActive ( true );
                break;

            case UIState.Settings:
                settingsUI.SetActive ( true );
                break;

            case UIState.Shop:
                shopUI.SetActive ( true );
                break;

            case UIState.GameHud:
                gameHud.SetActive ( true );
                break;

      

                // Добавляйте другие случаи по мере добавления состояний
        }

        // Обновляем текущее состояние
        currentState = newState;
    }

    public void SetUIStateMainMenu( )
    {
        SwitchUIState ( UIState.MainMenu );
    }

    public void SetUIStateSettings( )
    {
        SwitchUIState ( UIState.Settings );
    }

    public void SetUIStateShop( )
    {
        SwitchUIState ( UIState.Shop );
    }

    public void SetUIStateGameHud( )
    {
        SwitchUIState ( UIState.GameHud );
    }

    public void SetUIStateEndGamePanel( bool stateEnd )
    {
        SwitchUIState ( UIState.EndGamePanel );
        //endGamePanel.EndGameTextChange ( stateEnd );
    }

    public void StartGame( )
    {
        // Вызывается для старта игры, скрывает все UI окна
        mainMenuUI.SetActive ( false );
        settingsUI.SetActive ( false );
        shopUI.SetActive ( false );
        gameHud.SetActive ( true ); // Показываем GameHud при старте игры
        // Добавьте другие действия, которые необходимы для старта игры
    }

    public void Restart( )
    {
        // Добавьте код для сброса состояния UI и перехода в начальное состояние
        // Пример: переключаемся в главное меню
        SwitchUIState ( UIState.MainMenu );
        // Дополнительно добавьте сброс других параметров, если это необходимо
    }

    // Добавьте другие методы для изменения состояний по мере необходимости
}
