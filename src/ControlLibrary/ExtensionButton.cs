using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RedisManage.ControlLibrary
{
    /// <summary>
    /// Button扩展类
    /// </summary>
    public class ExtensionButton : Button
    {
        public static readonly DependencyProperty ExistIconProperty = DependencyProperty.Register("ExistIcon", typeof(bool), typeof(ExtensionButton), new PropertyMetadata(true));

        /// <summary>
        /// 是否有图标
        /// </summary>
        public bool ExistIcon
        {
            get => (bool) GetValue(ExistIconProperty);
            set => SetValue(ExistIconProperty, value);
        }


        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon", typeof(ImageSource), typeof(ExtensionButton), new PropertyMetadata(null));

        /// <summary>
        /// 图标
        /// </summary>
        public ImageSource Icon
        {
            get => (ImageSource) GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty = DependencyProperty.Register("IconWidth", typeof(int), typeof(ExtensionButton), new PropertyMetadata(24));

        /// <summary>
        /// 图标宽度
        /// </summary>
        public int IconWidth
        {
            get => (int) GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconHeightProperty = DependencyProperty.Register("IconHeight", typeof(int), typeof(ExtensionButton), new PropertyMetadata(24));

        /// <summary>
        /// 图标高度
        /// </summary>
        public int IconHeight
        {
            get => (int) GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty MoveBorderBrushProperty = DependencyProperty.Register("MoveBorderBrush", typeof(SolidColorBrush), typeof(ExtensionButton), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(3, 3, 3))));

        /// <summary>
        /// 鼠标移上时边框颜色
        /// </summary>
        public SolidColorBrush MoveBorderBrush
        {
            get => (SolidColorBrush) GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty MoveBackgroundProperty = DependencyProperty.Register("MoveBackground", typeof(SolidColorBrush), typeof(ExtensionButton), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(0, 122, 204))));

        /// <summary>
        /// 鼠标移上时背景颜色
        /// </summary>
        public SolidColorBrush MoveBackground
        {
            get => (SolidColorBrush) GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty ExistContentProperty = DependencyProperty.Register("ExistContent", typeof(bool), typeof(ExtensionButton), new PropertyMetadata(true));

        /// <summary>
        /// 是否有内容
        /// </summary>
        public bool ExistContent
        {
            get => (bool) GetValue(ExistContentProperty);
            set => SetValue(ExistContentProperty, value);
        }

        public static readonly DependencyProperty MoveFontColorProperty = DependencyProperty.Register("MoveFontColor", typeof(SolidColorBrush), typeof(ExtensionButton), new PropertyMetadata(new SolidColorBrush(Color.FromRgb(3, 3, 3))));

        /// <summary>
        /// 鼠标移上时字体颜色
        /// </summary>
        public SolidColorBrush MoveFontColor
        {
            get => (SolidColorBrush) GetValue(IconHeightProperty);
            set => SetValue(IconHeightProperty, value);
        }

        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register("Orientation", typeof(OrientationEnum), typeof(ExtensionButton), new PropertyMetadata(OrientationEnum.Vertical));

        /// <summary>
        /// 布局方向值
        /// </summary>
        public OrientationEnum Orientation
        {
            get => (OrientationEnum) GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }

        /// <summary>
        /// 图标排列方向枚举
        /// </summary>
        public enum OrientationEnum
        {
            /// <summary>
            /// 水平方向
            /// </summary>
            Horizontal,

            /// <summary>
            /// 垂直方向
            /// </summary>
            Vertical
        }
    }
}