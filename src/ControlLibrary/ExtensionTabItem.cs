using System.Windows;
using System.Windows.Controls;

namespace RedisManage.ControlLibrary
{
    public class ExtensionTabItem : TabItem
    {
        private static readonly RoutedEvent CloseItemEvent = EventManager.RegisterRoutedEvent("Close", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ExtensionTabItem));

        /// <summary>
        /// 关才Item事件
        /// </summary>
        public event RoutedEventHandler Close
        {
            add => AddHandler(CloseItemEvent, value);
            remove => RemoveHandler(CloseItemEvent, value);
        }
    }
}