using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySDR.Presenter;

namespace MySDR.View
{
    /// <summary>
    ///     主视图
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        private readonly string[] busyStrs = {"—", @"\", "|", "/"};
        private int idx;

        public MainForm(IMainFormPM pm)
        {
            InitializeComponent();
            PM = pm;
            PM.Form = this;
        }

        /// <summary>
        ///     设置状态字符
        /// </summary>
        public string StatusString
        {
            set { BeginInvoke(new Action(() => lblProcessStatus.Text = value)); }
        }

        public IMainFormPM PM { get; set; }

        /// <summary>
        ///     设置送货计划结果
        /// </summary>
        public string SendPlanString
        {
            set { BeginInvoke(new Action(() => rtbOutput.Text = value)); }
        }

        /// <summary>
        ///     设置延时计划结果
        /// </summary>
        public string DelaySDRString
        {
            set { BeginInvoke(new Action(() => rtbDelay.Text = value)); }
        }

        //运算
        private void btnCall_Click(object sender, EventArgs e)
        {
            try
            {
                var inputstr = rtbInput.Text;
                //单线程
                //PM.WorkPlan();

                //异步调用
                tmRun.Start();
                var task = new Task(() =>
                {
                    Thread.Sleep(1000);
                    PM.WorkPlan(inputstr);
                });

                task.ContinueWith(x =>
                {
                    tmRun.Stop();
                    StatusString = "就绪";
                });

                task.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "执行错误!");
            }
        }

        
        private void tmRun_Tick(object sender, EventArgs e)
        {
            lblProcessStatus.Text = busyStrs[idx];
            idx++;
            idx = idx%4;
        }
    }
}