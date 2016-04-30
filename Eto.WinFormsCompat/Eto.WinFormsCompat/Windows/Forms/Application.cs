using Eto;

namespace System.Windows.Forms
{
    /// <summary>
    /// The Application class on the Eto WinForms Compatibility Layer
    /// </summary>
    public static class Application
    {
        #region Private Fields

        private static Eto.Forms.Application _etoApplication;

        #endregion Private Fields

        #region Internal Properties

        internal static bool IsInitialized { get; set; }

        #endregion Internal Properties

        #region Internal Methods

        internal static void Initialize()
        {
            _etoApplication = new Eto.Forms.Application(Platform.Detect);
        }

        #endregion Internal Methods

        #region Public Methods

        [EtoWinFormsCompatStubOnly]
        public static void EnableVisualStyles() { }

        public static void Run(Form form)
        {
            _etoApplication.Run(form.EtoForm);
        }

        [EtoWinFormsCompatStubOnly]
        public static void SetCompatibleTextRenderingDefault(bool defaultValue) { }

        #endregion Public Methods
    }
}