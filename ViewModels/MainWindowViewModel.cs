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

        /// <summary>
        /// Высота окна перемещения
        /// </summary>
        private int _WindowTitleHeight { get; set; } = 20;

        private Thickness _resizeBorderThickness { get; set; } = new Thickness(4);
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

        /// <summary>
        /// Высота окна перемещения
        /// </summary>
        public int WindowTitleHeight
        {
            get => _WindowTitleHeight;

            set
            {
                var windowTitleHeight = _WindowTitleHeight;
                Set(ref windowTitleHeight, value);
            } 
        }

        /// <summary>
        /// Толщина границы регулировки размера окна
        /// </summary>
        public Thickness ResizeBorderThickness
        {
            get => _resizeBorderThickness;
            set
            {
                Thickness tmpThickness = _resizeBorderThickness;
                Set<Thickness>(ref tmpThickness, value);
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Базовый конструктор модели предсталения окна
        /// </summary>
        /// <param name="window">Окно подключающее DataContext</param>
        public MainWindowViewModel()
        {
            // Инициализация компонентов
            

        }

        #endregion

        #region Methods



        #endregion
    }
}
