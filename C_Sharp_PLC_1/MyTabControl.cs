using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_PLC_1
{
    public partial class MyTabControl : TabControl
    {
        // 构造函数
        private int iconWidth = 16;
        private int iconHeight = 16;
        private Bitmap icon = null;
        private Brush biaocolor = Brushes.Silver; //选项卡的背景色
        Brush unselected_color =new SolidBrush( Color.FromArgb(222, 223, 228));
        public MyTabControl()
            : base()
        {
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(100, 25); //设置选项卡标签的大小,可改变高不可改变宽 
            //this.Appearance = TabAppearance.Buttons; //选项卡的显示模式
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            icon = Properties.Resources.close;
            iconWidth = icon.Width; iconHeight = icon.Height;
        }
        /// <summary>
        /// 设置父窗口
        /// </summary>
        /// <param name="fp">画图窗口</param>
        
        /// <summary>
        /// 重写的绘制事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)//重写绘制事件。
        {
            Graphics g = e.Graphics;
            Rectangle r = GetTabRect(e.Index);
            if (e.Index == this.SelectedIndex)    //当前选中的Tab页，设置不同的样式以示选中
            {
                Brush selected_color = Brushes.White; //选中的项的背景色
                g.FillRectangle(selected_color, r); //改变选项卡标签的背景色
                string title = this.TabPages[e.Index].Text + "   ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置
                r.Offset(r.Width - iconWidth - 3, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y + 2));//选项卡上的图标的位置 fntTab = new System.Drawing.Font(e.Font, FontStyle.Bold);
            }
            else//非选中的
            {
                
                g.FillRectangle(unselected_color, r); //改变选项卡标签的背景色
                string title = this.TabPages[e.Index].Text + "   ";
                g.DrawString(title, this.Font, new SolidBrush(Color.Black), new PointF(r.X + 3, r.Y + 6));//PointF选项卡标题的位置
                r.Offset(r.Width - iconWidth - 3, 2);
                g.DrawImage(icon, new Point(r.X - 2, r.Y + 2));//选项卡上的图标的位置
            }
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            #region 左键判断是否在关闭区域
            if (e.Button == MouseButtons.Left)
            {
                Point p = e.Location;
                Rectangle r = GetTabRect(this.SelectedIndex);
                r.Offset(r.Width - iconWidth - 3, 2);
                r.Width = iconWidth;
                r.Height = iconHeight;
                if (r.Contains(p)) //点击特定区域时才发生
                {
                    this.TabPages.Remove(this.SelectedTab);
                }
            }
            #endregion
        }
    }
}
