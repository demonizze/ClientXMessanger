using System.Windows;
using ClientXMessanger.Libs;

namespace ClientXMessanger.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {

        #region Private Members

        /// <summary>
        /// Основное окно приложения
        /// </summary>
        private Window _window { get; set; }



        #endregion

        #region Public members



        #endregion

        #region Constructor

        /// <summary>
        /// Базовый конструктор модели предсталения окна
        /// </summary>
        /// <param name="window">Окно подключающее DataContext</param>
        public MainWindowViewModel(Window window)
        {
            // Инициализация компонентов
            _window = window;


        }

        #endregion

        #region Methods



        #endregion
    }
}
