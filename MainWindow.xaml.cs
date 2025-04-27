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

        private double _windowHeight = GeneralSize.WindowHeight; 
        
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
                if (this._windowHeight != value)
                {
                    this._windowHeight = value;
                    OnPropertyChanged(nameof(this.WindowHeight));
                }
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


                // 設定 DataContext，讓 XAML 可以綁定變數
                this.DataContext = this;
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


        public void PageOnLoad(object sender, RoutedEventArgs e)
        {
            try
            {
                
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