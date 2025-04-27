// 【LICENSE】
///  Copyright 2025 TCT, located in the Galaxy Oasis Arm, Solar System, Earth, Asia, Kaohsiung City, Taiwan. All rights reserved.
///  Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed.
///
/// 【開發者聲明】
/// 本專案由 [蔡承廷/TCT] 開發，遵循開源原則，免費提供給所有有興趣的人員使用、修改和分發.
///
/// 【引用方式】
/// 使用本專案之 DLL 時，請確保包含此聲明，並遵守相關的開源許可證條款.
///
/// 【ACKNOWLEDGEMENTS】
/// 本發行版包含 MicroSoft 開發環境提供的套件.
/// 本發行版包應用於 MicroSoft Windows 系統的軟體.
///
/// 允許使用、複製、修改、分發和銷售本軟體及其文件，無需支付任何費用，前提是上述版權聲明出現在所有副本中，並且該版權聲明和本許可聲明均出現在支持文件中.
/// 上述版權聲明和本許可聲明應包含在所有副本或軟體的重要部分中.
///
/// 本軟體，無任何類型的保證，無論是明示或暗示，包括但不限於對適銷性、特定用途的適用性和不侵權的保證.在任何情況下，TCT 對於因使用本軟體或與本軟體的使用或其他交易相關的任何索賠、損害或其他責任不承擔任何責任，無論是基於合同、侵權或其他原因.
///
/// 除非在本聲明中包含，否則不得在廣告中或其他方式使用 TCT 的名稱來促進本軟體的銷售、使用或其他交易，除非事先獲得 TCT 的書面授權.
///
/// 版權所有 2025 TCT，位於宇宙銀河綠洲臂太陽系地球亞洲臺灣高雄市.保留所有權利.
/// 允許使用、複製、修改和分發本軟體及其文件，無需支付任何費用，前提是上述版權聲明出現在所有副本中，並且該版權聲明和本許可聲明均出現在支持文件中，且不得在有關軟體分發的廣告或宣傳中使用 TCT 的名稱，除非事先獲得具體的書面許可.
///
/// TCT 對於本軟體不承擔任何保證，包括所有隱含的適銷性和適用性保證，在任何情況下，TCT 對於任何特殊、間接或後果性損害或因使用、本資料或利潤損失而產生的任何損害不承擔任何責任，無論是基於合同、過失或其他侵權行為，均不承擔責任.
///
/// 【軟體免責聲明】
/// 本軟體，不提供任何明示或暗示的擔保，包括但不限於對適銷性、特定用途適用性及非侵權的擔保.
/// 在適用法律允許的最大範圍內，對因使用或無法使用本軟體所產生的損害及風險，包括但不限於直接或間接的個人損害、商業利潤的喪失、貿易中斷、商業信息的丟失或任何其他經濟損失，開發者不承擔任何責任.
///
/// 【Developer Declaration】
/// This project is developed by [Tsai Cheng-Ting/TCT] and is freely available for use, modification, and distribution by all interested parties, adhering to open-source principles.
///
/// 【Usage Instructions】
/// When using the DLL of this project, please ensure that this declaration is included and that you comply with the relevant open-source license terms.
///
/// 【ACKNOWLEDGEMENTS】
/// This distribution includes packages provided by the Microsoft development environment.
/// This distribution contains software applicable to the Microsoft Windows system. Copyright 2025 TCT.
///
/// Permission is granted to use, copy, modify, distribute, and sell this software and its documentation without any fee, provided that the above copyright notice appears in all copies and that both the copyright notice and this permission notice are included in supporting documentation.
/// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
///
/// This software is provided without any type of warranty, express or implied, including but not limited to warranties of merchantability, fitness for a particular purpose, and non-infringement. In no event shall TCT be liable for any claims, damages, or other liabilities arising from the use of this software or in connection with the use or other dealings in this software, whether based on contract, tort, or other reasons.
///
/// Except as contained in this notice, the name of TCT shall not be used in advertising or otherwise to promote the sale, use, or other dealings in this software without prior written authorization from TCT.
///
/// Copyright 2025 TCT, located in the Galaxy Oasis Arm, Solar System, Earth, Asia, Kaohsiung City, Taiwan. All rights reserved.
/// Permission is granted to use, copy, modify, and distribute this software and its documentation without any fee, provided that the above copyright notice appears in all copies and that both the copyright notice and this permission notice are included in supporting documentation, and that the name of TCT shall not be used in advertising or publicity pertaining to the distribution of the software without specific, written prior permission.
///
/// TCT disclaims all warranties with regard to this software, including all implied warranties of merchantability and fitness. In no event shall TCT be liable for any special, indirect, or consequential damages or any damages whatsoever resulting from loss of use, data, or profits, whether in an action of contract, negligence, or other tortious action, arising out of or in connection with the use or performance of this software.
///
/// 【Software Disclaimer】
/// This software is provided without any express or implied warranties, including but not limited to the implied warranties of merchantability, fitness for a particular purpose, and non-infringement.
/// To the maximum extent permitted by applicable law, the developer shall not be liable for any damages or risks arising from the use or inability to use this software, including but not limited to direct or indirect personal injury, loss of commercial profits, business interruption, loss of business information, or any other economic loss.

using ILogger.AP;
using ILogger.Enum;
using Judgment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace MouseKeyboardSpirit.WindowView
{
    /// <summary>
    /// WindowSplashScreen.xaml 的互動邏輯
    /// </summary>
    public partial class WindowSplashScreen : Window
    {
        #region Property
        /// <summary>
        /// 下一個要呈現的主要視窗
        /// </summary>
        private MainWindow? mainWindow { set; get; }

        /// <summary>
        /// 確認下一個要呈現的主要視窗初始化完成
        /// </summary>
        private bool _isMainWindowInitFinish { set; get; }

        private DispatcherTimer? timer { set; get; }
        #endregion

        #region Init
        public WindowSplashScreen()
        {
            try
            {
                InitializeComponent();

                this._isMainWindowInitFinish = false;

                // 創建一個 DoubleAnimation
                DoubleAnimation progressAnimation = new DoubleAnimation
                {
                    From = 0,
                    To = 380,
                    Duration = new Duration(TimeSpan.FromSeconds(0.5)),
                    EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseInOut } // 絲滑動畫
                };

                // 設定動畫完成時的事件處理函式
                progressAnimation.Completed += ProgressAnimation_Completed!;

                // 將動畫應用到進度條
                this.progressBarRectangle.BeginAnimation(Rectangle.WidthProperty, progressAnimation);

                // 這裡將 MainWindow 的創建操作調度回主執行緒
                Application.Current.Dispatcher.Invoke(() =>
                {
                    this.mainWindow = new MainWindow();
                    this._isMainWindowInitFinish = true;
                });
            }
            catch (ExpectedInfo ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.ExpectedInfo}[{ex}]", ex.ReasonCode);

                //BMolecule.Communication?.Invoke(new LogInfo(this.Name, this.GetType().Name, MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.ExpectedInfo, ex.ReasonCode, ILogType.Error, ex, null));
                //BMolecule.Communication?.Invoke(new LogInfo(this.Name, this.GetType().Name, MethodBase.GetCurrentMethod()!.Name, Key.ExpectedInfo, ex.ReasonCode, ex.ILogType, ex, null));
            }
            catch (Exception ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.Catch}[{ex}]", Code.FCT_002);

                //BMolecule.Communication?.Invoke(new LogInfo(this.Name, this.GetType().Name, MethodBase.GetCurrentMethod()!.Name, HolyGift.Key.Catch, Code.FCT_002, ILogType.Catch, ex, null));
            }
            finally
            {

            }
        }

        /// <summary>
        /// 設定動畫完成時的事件處理函式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProgressAnimation_Completed(object sender, EventArgs e)
        {
            try
            {
                //設定檢查條件，使用 DispatcherTimer 每隔一段時間檢查
                this.timer = new DispatcherTimer
                {
                    Interval = TimeSpan.FromMilliseconds(200) // 每 200 毫秒檢查一次
                };
                this.timer.Tick += (sender, e) => CheckAndStopAnimation();
                this.timer.Start();
            }
            catch (ExpectedInfo ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.ExpectedInfo}[{ex}]", ex.ReasonCode);
            }
            catch (Exception ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.Catch}[{ex}]", Code.FCT_002);
            }
            finally
            {
            }
        }

        /// <summary>
        /// 確認完成並呈現下一個要呈現的主要視窗即關閉目前視窗
        /// </summary>
        private void CheckAndStopAnimation()
        {
            try
            {
                if (this._isMainWindowInitFinish && this.mainWindow != null)
                {
                    // 停止檢查
                    this.timer!.Stop();

                    this.mainWindow!.Show();
                    // 創建動畫
                    DoubleAnimation fadeInAnimation = new DoubleAnimation
                    {
                        From = 0.6,    // 起始透明度
                        To = 1.0,      // 目標透明度
                        Duration = new Duration(TimeSpan.FromSeconds(0.5)), // 動畫時間
                        EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseOut } // 動畫效果
                    };
                    this.mainWindow!.BeginAnimation(Window.OpacityProperty, fadeInAnimation);

                    DoubleAnimation closeAnimation = new DoubleAnimation
                    {
                        From = 1.0,    // 起始透明度
                        To = 0.0,      // 目標透明度
                        Duration = new Duration(TimeSpan.FromSeconds(0.5)), // 動畫時間
                        EasingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseIn } // 動畫效果
                    };
                    this.BeginAnimation(Window.OpacityProperty, closeAnimation);
                    this.Hide();
                    closeAnimation.Completed += (s, _) => this.Close(); // 關閉目前視窗
                }
            }
            catch (ExpectedInfo ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.ExpectedInfo}[{ex}]", ex.ReasonCode);
            }
            catch (Exception ex)
            {
                throw new ExpectedInfo($@"[{this.GetType().Name},{MethodBase.GetCurrentMethod()!.Name}]:{HolyGift.Key.Catch}[{ex}]", Code.FCT_002);
            }
            finally
            {
            }
        }

        #endregion
    }
}
