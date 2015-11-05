using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySDR
{
    /// <summary>
    /// 主窗体
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        public MainForm(IMainFormPM pm)
        {
            InitializeComponent();
            PM = pm;
            PM.Form = this;
        }

        public IMainFormPM PM { get; set; }

        public string InputString 
        {
            get { return rtbInput.Text; }
            set { rtbInput.Text = value; }
        }

        public string SendPlanString
        {
            get { return rtbOutput.Text; }
            set { rtbOutput.Text = value; }
        }

        public string DelaySDRString
        {
            get { return rtbDelay.Text; }
            set { rtbDelay.Text = value; }
        }


        private void btnCall_Click(object sender, EventArgs e)
        {
            try
            {
                PM.WorkPlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"执行错误!");
            }
        }
    }

    public interface IMainForm
    {
        /// <summary>
        /// 呈现器
        /// </summary>
        IMainFormPM PM { get; set; }

        /// <summary>
        /// 输入数据
        /// </summary>
        string InputString { get; set; }

        /// <summary>
        /// 延迟送货文本
        /// </summary>
        string DelaySDRString { get; set; }

        /// <summary>
        /// 送货计划文本
        /// </summary>
        string SendPlanString { get; set; }
    }
}
