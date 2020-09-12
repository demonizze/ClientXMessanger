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

        /// <summary>
        /// Строка заголовка окна
        /// </summary>
        private string _Title { get; set; } = "XMessanger";

        #endregion

        #region Public members

        /// <summary>
        /// Строка заголовка окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set
            {
                var title = _Title;
                Set(ref title, value);
            }
        }

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
