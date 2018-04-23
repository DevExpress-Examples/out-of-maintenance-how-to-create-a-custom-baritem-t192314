using DevExpress.Xpf.Bars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication1
{
    public static class CustomBarElementsRegistrator
    {
        public static void Register()
        {
            BarItemLinkCreator.Default.RegisterObject(typeof(MyBarButtonItem), typeof(MyBarButtonItemLink), link => new MyBarButtonItemLink());
            BarItemLinkControlCreator.Default.RegisterObject(typeof(MyBarButtonItemLink), typeof(MyBarButtonItemLinkControl), link => new MyBarButtonItemLinkControl((MyBarButtonItemLink)link));
        }
    }

    public class MyBarButtonItemLinkControl : BarButtonItemLinkControl
    {
        public MyBarButtonItemLinkControl()
        {
        }
        public MyBarButtonItemLinkControl(MyBarButtonItemLink link)
            : base(link)
        {
            
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            //demo test
            this.LayoutPanel.Background = Brushes.Red;
        }
    }

    public class MyBarButtonItemLink : BarButtonItemLink
    {

    }


    public class MyBarButtonItem : BarButtonItem
    {
        protected override Type GetLinkType()
        {
            return typeof(MyBarButtonItemLink);
        }
    }

}
