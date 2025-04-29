using ILogger.AP;
using ILogger.Enum;
using ILogger.Interface;
using Judgment;
using MouseKeyboardSpirit.GeneralSettings;
using OLogger.AP;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MouseKeyboardSpirit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        #region Property

        /// <summary>
        /// 宣告輸出用的 Log 資訊
        /// </summary>
        private OLogInfo? _ologinfo { set; get; }

        /// <summary>
        /// 預設視窗高度
        /// </summary>
        private double _windowHeight = GeneralSize.WindowDefaultHeight;
        //private double _windowHeight = GeneralSize.WindowExpandHeight;

        /// <summary>
        /// 預設視窗高度
        /// </summary>
        public double WindowHeight
        {
            get
            {
                return this._windowHeight;
            }
            set
            {
                this._windowHeight = value;
                OnPropertyChanged(nameof(this.WindowHeight));
            }
        }

        /// <summary>
        /// 預設視窗寬度
        /// </summary>
        private double _windowWidth = GeneralSize.WindowWidth;

        /// <summary>
        /// 預設視窗寬度
        /// </summary>
        public double WindowWidth
        {
            get
            {
                return this._windowWidth;
            }
            set
            {
                this._windowWidth = value;
                OnPropertyChanged(nameof(this.WindowWidth));
            }
        }

        /// <summary>
        /// 預設 ControlRow 高度
        /// </summary>
        private double _windowControlRowHeight { set; get; }

        /// <summary>
        /// 預設 ControlRow 高度
        /// </summary>
        public double WindowControlRowHeight
        {
            get
            {
                return this._windowControlRowHeight;
            }
            set
            {
                this._windowControlRowHeight = value;
                OnPropertyChanged(nameof(this.WindowControlRowHeight));
            }
        }

        /// <summary>
        /// 預設 MessageRow 高度
        /// </summary>
        private double _windowMessageRowHeight { set; get; }

        /// <summary>
        /// 預設 MessageRow 高度
        /// </summary>
        public double WindowMessageRowHeight
        {
            get
            {
                return this._windowMessageRowHeight;
            }
            set
            {
                this._windowMessageRowHeight = value;
                OnPropertyChanged(nameof(this.WindowMessageRowHeight));
            }
        }

        /// <summary>
        /// 預設 TabViewRow 高度
        /// </summary>
        private double _windowTabViewRowHeight { set; get; }

        /// <summary>
        /// 預設 TabViewRow 高度
        /// </summary>
        public double WindowTabViewRowHeight
        {
            get
            {
                return this._windowTabViewRowHeight;
            }
            set
            {
                this._windowTabViewRowHeight = value;
                OnPropertyChanged(nameof(this.WindowTabViewRowHeight));
            }
        }

        /// <summary>
        /// 預設 SelfRow 高度
        /// </summary>
        private double _windowSelfRowHeight = GeneralSize.WindowSelfRowHeight;

        /// <summary>
        /// 預設 SelfRow 高度
        /// </summary>
        public double WindowSelfRowHeight
        {
            get
            {
                return this._windowSelfRowHeight;
            }
            set
            {
                this._windowSelfRowHeight = value;
                OnPropertyChanged(nameof(this.WindowSelfRowHeight));
            }
        }

        /// <summary>
        /// 按鈕 PullPush 的尺寸
        /// </summary>
        private double _buttonPullPushSize = GeneralSize.ButtonPullPushSize;

        /// <summary>
        /// 按鈕PullPush的尺寸
        /// </summary>
        public double ButtonPullPushSize
        {
            get
            {
                return this._buttonPullPushSize;
            }
            set
            {
                this._buttonPullPushSize = value;
                OnPropertyChanged(nameof(this.ButtonPullPushSize));
            }
        }

        /// <summary>
        /// 下拉按鈕圖片
        /// </summary>
        private string? _buttonPullPushImageSourcePath = GeneralString.PullImageSourcePath;

        public string ButtonPullPushImageSourcePath
        {
            get
            {
                return this._buttonPullPushImageSourcePath!;
            }
            set
            {
                this._buttonPullPushImageSourcePath = value;
                OnPropertyChanged(nameof(this.ButtonPullPushImageSourcePath));
            }
        }

        /// <summary>
        /// 按下 PullPush 按鈕展現或收縮
        /// </summary>
        private bool _isPullPushVisible;

        /// <summary>
        /// 按下 PullPush 按鈕展現或收縮
        /// </summary>
        public bool IsPullPushVisible
        {
            get => this._isPullPushVisible;
            set
            {
                this._isPullPushVisible = value;
                OnPropertyChanged(nameof(this.IsPullPushVisible));
            }
        }

        #endregion


        #region Interface(INotifyPropertyChanged)
        /// <summary>
        /// 事件觸發
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        #region Init
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                // 設定 DataContext，讓 XAML 可以綁定變數
                this.DataContext = this;

                // 產出 Log 物件
                this._ologinfo = new OLogInfo(Assembly.GetExecutingAssembly().GetName().Name, 30, 3, 777);
                
                //設置溝通實際執行函式
                LogInfo.Communication = Communication;

                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, $@"
        /***********************************************
                          _ooOoo_
                         o8888888o
                         88"" . ""88
                         (| -_- |)
                         O\  =  /O
                      ____/`---'\____
                    .'  \\|     |//  `.
                   /  \\|||  :  |||//  \
                  /  _||||| -:- |||||-  \
                  |   | \\\  -  /// |   |
                  | \_|  ''\---/''  |   |
                  \  .-\__  `-`  ___/-. /
                ___`. .'  /--.--\  `. . __
             ."""" '<  `.___\_<|>_/___.'  >'"""".
            | | :  `- \`.;`\ _ /`;.`/ - ` : | |
            \  \ `-.   \_ __\ /__ _/   .-` /  /
       ======`-.____`-.___\_____/___.-`____.-'======
                          `=---='
       ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                佛祖保佑       永無BUG
       *********************************************/
", Code.IFO_000));

                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, @"
    /**************************************************************

      [       遵從自然規律，讓萬物自行發揮       ]  <-----------
                            |                                   |
                            |                                   |
      [        遵從自然規律，讓萬物自行相剋      ]              |
                            |                                   |
                            |                                   |
      [          精通萬物一切原理熟知於心        ]              |
                            |                                   |
                            |                                   |
      [          運用萬物一切原理強身健體        ]              |
                            |                                   |
                            |                                   |
      [  緣起緣滅，讓萬物一切自動運轉，自生自滅  ]              |
                            |                                   |
                            |                                   |
      [        時有時無，萬物一切可有可無        ]              |
                            |                                   |
                            |                                   |
      [             天人合一，無欲無求           ]              |
                            |                                   |
                            |                                   |
      [              萬物一切歸為無              ]              |
                            |                                   |
                            |                                   |
      [           心有所想，創建美妙世界         ] --------------

    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
              如何成為長官的秘訣            劉彩萍指揮官
    ***************************************************************/
            ", Code.IFO_000));

                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, $@"Start...", Code.IFO_000));


                
            }
            catch (ExpectedInfo ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.ExpectedInfo, ex.ReasonCode, ILogType.Error, ex, null));
            }
            catch (Exception ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.Catch, Code.FCT_002, ILogType.Catch, ex, null));
            }
            finally
            {
                SpinWait.SpinUntil(() => false, 1000);
            }
        }

        #endregion

        #region Method

        /// <summary>
        /// 載入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WindowOnLoad(object sender, RoutedEventArgs e)
        {
            try
            {
                this.WindowControlRowHeight = GeneralSize.WindowControlRowHeight;
                this.WindowMessageRowHeight = GeneralSize.WindowMessageRowHeight;
                this.WindowTabViewRowHeight = GeneralSize.WindowTabViewRowHeight;
                this.WindowSelfRowHeight = GeneralSize.WindowSelfRowHeight;
            }
            catch (ExpectedInfo ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.ExpectedInfo, ex.ReasonCode, ILogType.Error, ex, null));
            }
            catch (Exception ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.Catch, Code.FCT_002, ILogType.Catch, ex, null));
            }
            finally
            {
            }
        }

        /// <summary>
        /// 當滑鼠按下時開始拖曳視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                // 這行會讓視窗跟隨滑鼠移動
                this.DragMove();
            }
            catch (ExpectedInfo ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.ExpectedInfo, ex.ReasonCode, ILogType.Error, ex, null));
            }
            catch (Exception ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.Catch, Code.FCT_002, ILogType.Catch, ex, null));
            }
            finally
            {
            }
        }

        private void DoExpandedPanel(object sender, RoutedEventArgs e)
        {
            try
            {
                //123
                //this.WindowHeight
                this.IsPullPushVisible = !this.IsPullPushVisible;
                
                double targetHeight = this.IsPullPushVisible ? GeneralSize.WindowExpandHeight : GeneralSize.WindowDefaultHeight;

                // 創建動畫
                DoubleAnimation heightAnimation = new DoubleAnimation
                {
                    To = targetHeight,
                    Duration = TimeSpan.FromSeconds(GeneralString.AnimationDuration),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut } // 絲滑動畫
                };

                // 執行動畫
                this.BeginAnimation(Window.HeightProperty, heightAnimation);

                //this.PullButtonImageSourcePath = BaseScreenshot.PushImageSourcePath;
            }
            catch (ExpectedInfo ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.ExpectedInfo, ex.ReasonCode, ILogType.Error, ex, null));
            }
            catch (Exception ex)
            {
                Communication(new LogInfo(HolyGift.Key.System, MethodBase.GetCurrentMethod()!.DeclaringType!.ToString(), MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.Catch, Code.FCT_002, ILogType.Catch, ex, null));
            }
            finally
            {
            }
        }

        /// <summary>
        /// 溝通(可用來記錄 Log)
        /// </summary>
        /// <param name="li"></param>
        private void Communication(ILogInfo li)
        {
            try
            {
                switch (li.Type)
                {
                    case ILogType.Info:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}] {li.Info}");
                        break;
                    case ILogType.Alarm:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}] {li.Info}");
                        break;
                    case ILogType.Error:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}");
                        break;
                    case ILogType.Catch:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}");
                        break;
                    case ILogType.Fail:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}");
                        break;
                    case ILogType.Pass:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}] {li.Info}");
                        break;                            
                    case ILogType.ShowInfo:
                        //var tpm = $@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}] {li.Info}";
                        //this._ologinfo!.Logger.Info(tpm);
                        //var windowBW = new MessageBoxWindow("Info", tpm, MessageBoxWindowShowType.Info, MessageBoxWindowButtonType.Close);
                        //windowBW.Show();
                        break;
                    case ILogType.ShowAlarm:
                        //tpm = $@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}] {li.Info}";
                        //this._ologinfo!.Logger.Info(tpm);
                        //windowBW = new MessageBoxWindow("Alarm", tpm, MessageBoxWindowShowType.Alarm, MessageBoxWindowButtonType.Close);
                        //windowBW.Show();
                        break;
                    case ILogType.ShowError:
                        //tpm = $@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}";
                        //this._ologinfo!.Logger.Info(tpm);
                        //windowBW = new MessageBoxWindow("Error", tpm, MessageBoxWindowShowType.Error, MessageBoxWindowButtonType.Close);
                        //windowBW.Show();
                        break;
                    case ILogType.ShowCatch:
                        //tpm = $@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}";
                        //this._ologinfo!.Logger.Info(tpm);
                        //windowBW = new MessageBoxWindow("Catch", tpm, MessageBoxWindowShowType.Error, MessageBoxWindowButtonType.Close);
                        //windowBW.Show();
                        break;
                    case ILogType.ShowFail:
                        //tpm = $@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}";
                        //this._ologinfo!.Logger.Info(tpm);
                        //windowBW = new MessageBoxWindow("Fail", tpm, MessageBoxWindowShowType.Error, MessageBoxWindowButtonType.Close);
                        //windowBW.Show();
                        break;
                    default:
                        this._ologinfo!.Logger.Info($@"<{li.Name},{li.Class}>[{li.Method}][{li.ResultCode}][{li.Info}] {li.Error}");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.Catch}[{ex}]");
            }
            finally
            {
            }
        }
        #endregion

    }
}