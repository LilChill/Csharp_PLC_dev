using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTabControl
{
    public partial class MyTabControl : TabControl
    {
        public MyTabControl()
        {
           // InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // 在此添加自定义的绘制逻辑
            base.OnPaint(e);
        }
    }
}
